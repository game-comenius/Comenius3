using UnityEngine;
using UnityEngine.UI;

public class PaginaAgrupamentos : PaginaPlanejamento
{
    [SerializeField] private Text nomeDoSelecionado;
    [SerializeField] private Text descricaoDoSelecionado;
    [SerializeField] private Button botaoConfirmar;
    [SerializeField] private Button botaoProximaMidia;
    [SerializeField] private GameObject botaoMidiaAnterior;
    [SerializeField] private GameObject botaoPainelAnterior;
    [SerializeField] private Image agrupamentoEmFocoImagem;
    [SerializeField] private Agrupamento[] agrupamentos;
    [SerializeField] private Sprite[] agrupamentosSprites;
    [SerializeField] private string[] agrupamentosNomes;
    [SerializeField] [TextArea] private string[] agrupamentosDescricao;
    [SerializeField] private Button botaoProximoAgrupamento;
    [SerializeField] private Button botaoAgrupamentoAnterior;

    private int primeiroAgrupamentoSelecionado;
    private int segundoAgrupamentoSelecionado;
    private int agrupamentoEmFoco;
    private bool primeiroAgrupamento;

    protected override void OnEnable()
    {
        textoAjuda.text = ajuda;

        iconManager.ShowIcon(1);

        iconManager.SetIcon(0, EstadoDoJogo.Instance.MidiasSelecionadas[0].sprite);
        iconManager.SetIcon(1, EstadoDoJogo.Instance.MidiasSelecionadas[1].sprite);
    }

    private void OnDisable()
    {
        iconManager.ResetIcon(0);
        iconManager.ResetIcon(1);
        iconManager.HideIcon(1);
    }

    private void Start()
    {
        primeiroAgrupamento = true;
        primeiroAgrupamentoSelecionado = 0;
        segundoAgrupamentoSelecionado = 0;
        agrupamentoEmFoco = 0;
        agrupamentoEmFocoImagem.sprite = agrupamentosSprites[agrupamentoEmFoco];

        nomeDoSelecionado.text = agrupamentosNomes[agrupamentoEmFoco];
        descricaoDoSelecionado.text = agrupamentosDescricao[agrupamentoEmFoco];
    }

    private void atualizar(int agrupamentoSelecionado)
    {
        nomeDoSelecionado.text = agrupamentosNomes[agrupamentoSelecionado];
        descricaoDoSelecionado.text = agrupamentosDescricao[agrupamentoSelecionado];
        agrupamentoEmFocoImagem.sprite = agrupamentosSprites[agrupamentoSelecionado];
    }

    private void atualizarEstadoDeJogo(int agrupamentoSelecionado)
    {
        if (primeiroAgrupamento)
        {
            EstadoDoJogo.Instance.MidiasSelecionadas[0].agrupamento = agrupamentos[agrupamentoSelecionado];
        }
        else
        {
            EstadoDoJogo.Instance.MidiasSelecionadas[1].agrupamento = agrupamentos[agrupamentoSelecionado];
        }
    }

    public void Confirmar()
    {
        if (primeiroAgrupamento)
        {
            primeiroAgrupamentoSelecionado = agrupamentoEmFoco;
        }
        else
        {
            segundoAgrupamentoSelecionado = agrupamentoEmFoco;
        }

        agrupamentoEmFoco = segundoAgrupamentoSelecionado;
        primeiroAgrupamento = false;

        botaoPainelAnterior.SetActive(false);
        botaoProximaMidia.gameObject.SetActive(false);
        botaoMidiaAnterior.SetActive(true);
        botaoConfirmar.gameObject.SetActive(true);

        atualizarEstadoDeJogo(agrupamentoEmFoco);
        atualizar(segundoAgrupamentoSelecionado);
        atualizarBotoes();
    }

    public void Voltar()
    {
        agrupamentoEmFoco = primeiroAgrupamentoSelecionado;
        primeiroAgrupamento = true;

        botaoPainelAnterior.SetActive(true);
        botaoProximaMidia.gameObject.SetActive(true);
        botaoMidiaAnterior.SetActive(false);
        botaoConfirmar.gameObject.SetActive(false);

        atualizar(primeiroAgrupamentoSelecionado);
        atualizarBotoes();
    }

    public void AvancarAgrupamento()
    {
        agrupamentoEmFoco++;
        agrupamentoEmFocoImagem.sprite = agrupamentosSprites[agrupamentoEmFoco];

        atualizar(agrupamentoEmFoco);
        atualizarBotoes();
    }

    public void VoltarAgrupamento()
    {
        agrupamentoEmFoco--;
        agrupamentoEmFocoImagem.sprite = agrupamentosSprites[agrupamentoEmFoco];

        atualizar(agrupamentoEmFoco);
        atualizarBotoes();
    }

    private void ResetarAgrupamentos()
    {
        agrupamentoEmFoco = 0;
        agrupamentoEmFocoImagem.sprite = agrupamentosSprites[agrupamentoEmFoco];

        atualizar(agrupamentoEmFoco);

        botaoProximoAgrupamento.interactable = true;
        botaoAgrupamentoAnterior.interactable = false;
    }

    private void atualizarBotoes()
    {
        if (agrupamentoEmFoco + 1 == agrupamentos.Length)
        {
            botaoProximoAgrupamento.interactable = false;
        }
        else
        {
            botaoProximoAgrupamento.interactable = true;
        }

        if (agrupamentoEmFoco == 0)
        {
            botaoAgrupamentoAnterior.interactable = false;
        }
        else
        {
            botaoAgrupamentoAnterior.interactable = true;
        }
    }
}
