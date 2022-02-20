using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ControladorDisplayMomentoInteracao : MonoBehaviour
{
    [SerializeField] private MomentoInteracao momento;
    [SerializeField] private DisplayDeAluno displayAluno;
    [SerializeField] private EstadoDeAulaInvertida estado;
    private bool dontShowDropDown;

    public MomentoInteracao Momento
    {
        get
        {
            return momento;
        }
        set
        {
            totalDePaginas = value.paginas.Length;
            paginaAtual = 0;
            paginaDropdown = value.paginaDoDropdown;
            momento = value;
            if (displayAluno != null)
            {
                displayAluno.estaFeliz = momento.alunoFeliz;
                displayAluno.AtualizarDisplay();
            }

            // Prepara o dropdown
            dropdown.ClearOptions();
            List<Dropdown.OptionData> listaDeEscolhas = new List<Dropdown.OptionData>();
            listaDeEscolhas.Add(new Dropdown.OptionData(""));

            List<string> escolhas = new List<string>(value.opcoesDeEscolha.Valor.Split('\n'));
            escolhaErrada = new Dropdown.OptionData(escolhas[escolhas.Count - 1]);
            // Adiciona as escolhas aleatoriamente
            while (escolhas.Count > 0)
            {
                int index = Random.Range(0, escolhas.Count);
                listaDeEscolhas.Add(new Dropdown.OptionData(escolhas[index]));
                escolhas.RemoveAt(index);
            }
            if (paginaDropdown == -2)
                dontShowDropDown = true;
            else
                dontShowDropDown = false;
            dropdown.AddOptions(listaDeEscolhas);
            escolhaAtual = dropdown.options[0];
            AtualizarPagina();
        }
    }

    [System.Serializable] public class ChoiceConfirmEvent : UnityEvent<bool> { }
    public ChoiceConfirmEvent OnChoiceConfirm;
    public UnityEvent OnRightChoiceConfirm;
    public UnityEvent OnWrongChoiceConfirm;
    public UnityEvent OnExitWithNoDropdown;

    public void UpdateMomento()
    {
        Momento = momento;
        escolhaAtual = dropdown.options[0];
    }

    private int paginaAtual;
    private int paginaDropdown;
    private int totalDePaginas;
    private Dropdown.OptionData escolhaErrada;

    private bool isDropdownPage
    {
        get
        {
            if (paginaDropdown < 0)
                return ultimaPagina;
            else
                return (paginaDropdown == paginaAtual);
        }
    }

    private bool ultimaPagina
    {
        get
        {
            if (paginaAtual == totalDePaginas - 1)
                return true;
            else
                return false;
        }
    }

    private Dropdown.OptionData escolhaAtual;

    [SerializeField] private Text titulo;
    [SerializeField] private Text texto;
    [SerializeField] private Button setaDireita;
    [SerializeField] private Button setaEsquerda;
    [SerializeField] private Dropdown dropdown;

    public void OnValidate()  // Faz atualizar o momento quando alterado pelo inspector
    {
        Momento = momento;
    }

    private void OnEnable()
    {
        //Serve de trigger para o setter
        Momento = momento;
        if (escolhaAtual == null)
            escolhaAtual = new Dropdown.OptionData("");
        //Atualiza o display para primeira pagina
        paginaAtual = 0;
        AtualizarPagina();

        //Faz os botões chamarem o avanco/volta pagina
        setaDireita.onClick.AddListener(AvançarPagina);
        setaEsquerda.onClick.AddListener(RetrocederPagina);
        dropdown.onValueChanged.AddListener(ValidarEscolha);
    }

    private void OnDisable()
    {
        setaDireita.onClick.RemoveListener(AvançarPagina);
        setaEsquerda.onClick.RemoveListener(RetrocederPagina);
        dropdown.onValueChanged.RemoveListener(ValidarEscolha);
    }

    public void ValidarEscolha(int escolha)
    {
        escolhaAtual = dropdown.options[escolha];
        if (escolhaAtual.text != "")
            setaDireita.interactable = true;
        else
            setaDireita.interactable = false;
    }

    private void AtualizarPagina()
    {
        PaginaInteracao pagina = momento.paginas[paginaAtual];

        titulo.text = pagina.titulo;
        texto.text = pagina.texto.Valor;

        if (isDropdownPage && !dontShowDropDown)
        {
            dropdown.gameObject.SetActive(true);
            if (escolhaAtual.text == "")
                setaDireita.interactable = false;
        }
        else
        {
            setaDireita.interactable = true;
            dropdown.gameObject.SetActive(false);
        }
        setaEsquerda.interactable = !(paginaAtual == 0);  // Seta esquerda esta ativada com excessão da primeira pagina
    }

    public void AvançarPagina()
    {
        if (ultimaPagina)
        {
            if (escolhaAtual.text != "")
                ConfirmarResposta();
            if (dontShowDropDown)
                OnExitWithNoDropdown.Invoke();
        }

        paginaAtual++;
        if (paginaAtual >= totalDePaginas - 1)
            paginaAtual = totalDePaginas - 1;

        AtualizarPagina();
    }

    public void RetrocederPagina()
    {
        paginaAtual--;
        if (paginaAtual < 0)
            paginaAtual = 0;
        AtualizarPagina();
    }

    private void ConfirmarResposta()
    {
        if (dontShowDropDown)
            return;

        bool acertou = escolhaAtual.text != escolhaErrada.text;

        OnChoiceConfirm.Invoke(acertou);

        if (acertou)
            OnRightChoiceConfirm.Invoke();
        else
            OnWrongChoiceConfirm.Invoke();
    }
}
