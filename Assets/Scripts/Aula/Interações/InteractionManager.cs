﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class InteractionManager : MonoBehaviour
{
    public MomentoInteracao Interaction
    {
        get
        {
            return interaction;
        }
        set
        {
            totalPageCount = value.paginas.Length;
            currentPage = 0;
            pageDropdown = value.paginaDoDropdown;
            interaction = value;

            if (studentDisplay != null)
            {
                studentDisplay.estaFeliz = interaction.alunoFeliz;
                studentDisplay.AtualizarDisplay();
            }

            // Prepara o dropdown
            dropdown.ClearOptions();
            List<Dropdown.OptionData> listaDeEscolhas = new List<Dropdown.OptionData>();
            listaDeEscolhas.Add(new Dropdown.OptionData(""));

            List<string> escolhas = new List<string>(value.opcoesDeEscolha.Valor.Split('\n'));
            wrongChoice = new Dropdown.OptionData(escolhas[escolhas.Count - 1]);

            // Adiciona as escolhas aleatoriamente
            while (escolhas.Count > 0)
            {
                int index = Random.Range(0, escolhas.Count);
                listaDeEscolhas.Add(new Dropdown.OptionData(escolhas[index]));
                escolhas.RemoveAt(index);
            }

            if (pageDropdown == -2)
                dontShowDropDown = true;
            else
                dontShowDropDown = false;

            dropdown.AddOptions(listaDeEscolhas);
            currentChoice = dropdown.options[0];
            UpdatePage();
        }
    }

    [System.Serializable] public class ChoiceConfirmEvent : UnityEvent<bool, string> { }
    [System.Serializable] public class ScoreChangeEvent : UnityEvent<int> { }
    public ChoiceConfirmEvent OnChoiceConfirm;
    public ScoreChangeEvent OnScoreChange;
    public UnityEvent OnExitWithNoDropdown;

    [SerializeField] private MomentoInteracao interaction;
    [SerializeField] private DisplayDeAluno studentDisplay;
    [SerializeField] private StateMachine stateMachine;
    [SerializeField] private Text title;
    [SerializeField] private Text text;
    [SerializeField] private Button okButton;
    [SerializeField] private Dropdown dropdown;
    [SerializeField] private int scoreOnRightAnswer;

    private bool isDropdownPage
    {
        get
        {
            if (pageDropdown < 0)
                return isLastPage;
            else
                return (pageDropdown == currentPage);
        }
    }

    private bool isLastPage
    {
        get
        {
            if (currentPage == totalPageCount - 1)
                return true;
            else
                return false;
        }
    }

    private bool dontShowDropDown;
    private int totalPageCount;
    private int currentPage;
    private int pageDropdown;
    private Dropdown.OptionData currentChoice;
    private Dropdown.OptionData wrongChoice;
    private int tempScore;

    public void OnValidate()  // Faz atualizar o momento quando alterado pelo inspetor
    {
        Interaction = interaction;
    }

    private void OnEnable()
    {
        //Serve de trigger para o setter
        Interaction = interaction;
        if (currentChoice == null)
            currentChoice = new Dropdown.OptionData("");
        //Atualiza o display para primeira pagina
        currentPage = 0;
        UpdatePage();

        //Faz os botões chamarem o avanco/volta pagina
        okButton.onClick.AddListener(AdvancePage);
        dropdown.onValueChanged.AddListener(ValidateChoice);

        tempScore = 0;
    }

    private void OnDisable()
    {
        okButton.onClick.RemoveListener(AdvancePage);
        dropdown.onValueChanged.RemoveListener(ValidateChoice);
    }

    public void ValidateChoice(int choice)
    {
        currentChoice = dropdown.options[choice];

        if (currentChoice.text != "")
            okButton.interactable = true;
        else
            okButton.interactable = false;
    }

    private void UpdatePage()
    {
        PaginaInteracao page = interaction.paginas[currentPage];

        title.text = page.titulo;
        text.text = page.texto.Valor;

        if (isDropdownPage && !dontShowDropDown)
        {
            dropdown.gameObject.SetActive(true);
            if (currentChoice.text == "")
                okButton.interactable = false;
        }
        else
        {
            okButton.interactable = true;
            dropdown.gameObject.SetActive(false);
        }
    }

    public void AdvancePage()
    {
        if (isLastPage)
        {
            if (currentChoice.text != "")
                ConfirmChoice();
            if (dontShowDropDown)
                OnExitWithNoDropdown.Invoke();
        }

        currentPage++;

        if (currentPage >= totalPageCount - 1)
            currentPage = totalPageCount - 1;

        UpdatePage();
    }

    public void UpdateScore()
    {
        OnScoreChange.Invoke(tempScore);
    }

    private void ConfirmChoice()
    {
        if (dontShowDropDown)
            return;

        bool choseRightAnswer = currentChoice.text != wrongChoice.text;

        string reaction = choseRightAnswer ? interaction.reacaoPositiva : interaction.reacaoNegativa;

        OnChoiceConfirm.Invoke(choseRightAnswer, reaction);

        if (choseRightAnswer)
            tempScore = scoreOnRightAnswer;
        else
            tempScore = 0;
    }
}
