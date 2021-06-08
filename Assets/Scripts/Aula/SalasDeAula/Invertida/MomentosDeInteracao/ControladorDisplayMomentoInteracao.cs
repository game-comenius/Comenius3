using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ControladorDisplayMomentoInteracao : MonoBehaviour
{
    [SerializeField] private MomentoInteracao momento;
    [SerializeField] bool isAutomatic = false;

    public MomentoInteracao Momento
    {
        get
        {
            return momento;
        }
        set
        {
            if (isAutomatic)
                value = GeradorDeMomentosDaPlanilha.GetRandomMomento();

            totalDePaginas = value.paginas.Length;
            paginaAtual = 0;
            momento = value;
            //Prepara o dropdown
            dropdown.ClearOptions();
            List<Dropdown.OptionData> listaDeEscolhas = new List<Dropdown.OptionData>();
            listaDeEscolhas.Add(new Dropdown.OptionData(""));

            List<string> escolhas = new List<string>(value.opcoesDeEscolha.Valor.Split('\n'));
            escolhaErrada = new Dropdown.OptionData(escolhas[escolhas.Count - 1]);
            //Adiciona as escolhas aleatoriamente
            while (escolhas.Count > 0)
            {
                int index = Random.Range(0, escolhas.Count);
                listaDeEscolhas.Add(new Dropdown.OptionData(escolhas[index]));
                escolhas.RemoveAt(index);
            }

            dropdown.AddOptions(listaDeEscolhas);
            AtualizarPagina();
        }
    }

    [System.Serializable] public class ChoiceConfirmEvent : UnityEvent<bool> { }
    public ChoiceConfirmEvent OnChoiceConfirm;

    public void UpdateMomento()
    {
        Momento = momento;
        escolhaAtual = dropdown.options[0];
    }

    private int paginaAtual;
    private int totalDePaginas;
    private Dropdown.OptionData escolhaErrada;
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

    private void OnValidate()//Faz atualizar o momento quando alterado pelo inspector
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

        if (ultimaPagina)
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
        setaEsquerda.interactable = !(paginaAtual == 0);//Seta esquerda esta ativada com excessão da primeira pagina
    }

    public void AvançarPagina()
    {
        if (ultimaPagina && escolhaAtual.text != "")
            OnChoiceConfirm.Invoke(escolhaAtual.text != escolhaErrada.text);


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
}
