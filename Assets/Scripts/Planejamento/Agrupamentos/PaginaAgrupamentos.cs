using UnityEngine;
using UnityEngine.UI;

public class PaginaAgrupamentos : PaginaPlanejamento
{
    [SerializeField] private Text descricaoDoSelecionado;
    [SerializeField] [TextArea] private string descricaoPadrao;
    [SerializeField] private Button botaoConfirmar;
    [SerializeField] private Button botaoProximaMidia;
    [SerializeField] private GameObject botaoMidiaAnterior;
    [SerializeField] private GameObject botaoPainelAnterior;
    [SerializeField] private Image agrupamentoEmFocoImagem;
    [SerializeField] private Agrupamento[] agrupamentos;
    [SerializeField] private Sprite[] agrupamentosSpritesInfantil;
    [SerializeField] private Sprite[] agrupamentosSpritesRegular;
    [SerializeField] private string[] agrupamentosNomes;
    [SerializeField] [TextArea] private string[] agrupamentosDescricao;
    [SerializeField] private Button botaoProximoAgrupamento;
    [SerializeField] private Button botaoAgrupamentoAnterior;
    [SerializeField] private GameObject setaPrimeiraMidia;
    [SerializeField] private GameObject setaSegundaMidia;

    private Sprite[] agrupamentosSprites;
    private int primeiroAgrupamentoSelecionado;
    private int segundoAgrupamentoSelecionado;
    private int agrupamentoEmFoco;
    private bool primeiroAgrupamento;

    protected override void OnEnable()
    {
        textoAjuda.text = ajuda;

        fundo.sprite = spriteFundo;

        iconManager.ShowIcon(0);
        iconManager.ShowIcon(1);
        iconManager.HideIcon(2);
        iconManager.HideIcon(3);

        iconManager.SetIcon(0, EstadoDoJogo.Instance.MidiasSelecionadas[2].sprite);
        iconManager.SetIcon(1, EstadoDoJogo.Instance.MidiasSelecionadas[3].sprite);
    }

    private void OnDisable()
    {
        iconManager.ResetIcon(0);
        iconManager.ResetIcon(1);
    }

    private void Start()
    {
        primeiroAgrupamento = true;
        primeiroAgrupamentoSelecionado = -1;
        segundoAgrupamentoSelecionado = -1;
        agrupamentoEmFoco = 0;

        if (EstadoDoJogo.Instance.NivelDeEnsinoSelecionado == NivelDeEnsino.EducacaoInfantil)
        {
            agrupamentosSprites = agrupamentosSpritesInfantil;
        }
        else
        {
            agrupamentosSprites = agrupamentosSpritesRegular;
        }

        agrupamentoEmFocoImagem.sprite = agrupamentosSprites[agrupamentoEmFoco];
        descricaoDoSelecionado.text = descricaoPadrao;
    }

    private void atualizar(int agrupamentoEmFoco)
    {
        if (agrupamentoEmFoco != -1)
        {
            if (primeiroAgrupamento)
            {
                descricaoDoSelecionado.text = primeiroAgrupamentoSelecionado != -1 ? agrupamentosDescricao[primeiroAgrupamentoSelecionado] : descricaoPadrao;
            }
            else
            {
                descricaoDoSelecionado.text = segundoAgrupamentoSelecionado != -1 ? agrupamentosDescricao[segundoAgrupamentoSelecionado] : descricaoPadrao;
            }

            agrupamentoEmFocoImagem.sprite = agrupamentosSprites[agrupamentoEmFoco];
        }
        else
        {
            descricaoDoSelecionado.text = descricaoPadrao;
            agrupamentoEmFocoImagem.sprite = agrupamentosSprites[0];
        }
    }

    private void atualizarEstadoDeJogo(int agrupamentoSelecionado)
    {
        if (agrupamentoSelecionado != -1)
        {
            descricaoDoSelecionado.text = agrupamentosDescricao[agrupamentoSelecionado];

            if (primeiroAgrupamento)
            {
                EstadoDoJogo.Instance.MidiasSelecionadas[2].agrupamento = agrupamentos[agrupamentoSelecionado];
            }
            else
            {
                EstadoDoJogo.Instance.MidiasSelecionadas[3].agrupamento = agrupamentos[agrupamentoSelecionado];
            }
        }
    }

    public void Selecao()
    {
        if (primeiroAgrupamento)
        {
            if (primeiroAgrupamentoSelecionado == agrupamentoEmFoco)
            {
                primeiroAgrupamentoSelecionado = -1;
                botaoProximaMidia.interactable = false;
            }
            else
            {
                primeiroAgrupamentoSelecionado = agrupamentoEmFoco;
                botaoProximaMidia.interactable = true;
            }

            atualizar(primeiroAgrupamentoSelecionado);
            atualizarEstadoDeJogo(primeiroAgrupamentoSelecionado);
        }
        else
        {
            if (segundoAgrupamentoSelecionado == agrupamentoEmFoco)
            {
                segundoAgrupamentoSelecionado = -1;
                botaoConfirmar.interactable = false;
            }
            else
            {
                segundoAgrupamentoSelecionado = agrupamentoEmFoco;
                botaoConfirmar.interactable = true;
            }

            atualizar(segundoAgrupamentoSelecionado);
            atualizarEstadoDeJogo(segundoAgrupamentoSelecionado);
        }
    }

    public void Confirmar()
    {
        agrupamentoEmFoco = segundoAgrupamentoSelecionado == -1 ? 0 : segundoAgrupamentoSelecionado;
        primeiroAgrupamento = false;

        setaPrimeiraMidia.SetActive(false);
        setaSegundaMidia.SetActive(true);
        botaoPainelAnterior.SetActive(false);
        botaoProximaMidia.gameObject.SetActive(false);
        botaoMidiaAnterior.SetActive(true);
        botaoConfirmar.gameObject.SetActive(true);

        atualizar(segundoAgrupamentoSelecionado);
        atualizarBotoes();
    }

    public void Voltar()
    {
        agrupamentoEmFoco = primeiroAgrupamentoSelecionado == -1 ? 0 : primeiroAgrupamentoSelecionado;
        primeiroAgrupamento = true;

        setaPrimeiraMidia.SetActive(true);
        setaSegundaMidia.SetActive(false);
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
