using UnityEngine;
using UnityEngine.UI;

public class PaginaAgrupamentos : PaginaPlanejamento
{
    [SerializeField] private Text descricaoDoSelecionado;
    [SerializeField] [TextArea] private string descricaoPadrao;
    [SerializeField][TextArea] private string descricaoPT;
    [SerializeField][TextArea] private string descricaoEua;
    [SerializeField][TextArea] private string descricaoEspanhol;
    [SerializeField] private Button botaoConfirmar;
    [SerializeField] private Button botaoProximaMidia;
    [SerializeField] private GameObject botaoMidiaAnterior;
    [SerializeField] private GameObject botaoPainelAnterior;
    [SerializeField] private Image agrupamentoEmFocoImagem;
    [SerializeField] private Image molduraDeSelecao;
    [SerializeField] private Agrupamento[] agrupamentos;
    [SerializeField] private Sprite[] agrupamentosSpritesInfantil;
    [SerializeField] private Sprite[] agrupamentosSpritesRegular;
    [SerializeField] private string[] agrupamentosNomes;
    [SerializeField] [TextArea] private string[] agrupamentosDescricao;
    [SerializeField][TextArea] private string[] agrupamentosDescricaoPtbr;
    [SerializeField][TextArea] private string[] agrupamentosDescricaoEua;
    [SerializeField][TextArea] private string[] agrupamentosDescricaoEspanhol;
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
        AtualizarTextos();
        textoAjuda.text = ajuda;

        fundo.sprite = spriteFundo;

        iconManager.ShowIcon(0);
        iconManager.ShowIcon(1);
        iconManager.HideIcon(2);
        iconManager.HideIcon(3);

        iconManager.SetIcon(0, EstadoDoJogo.Instance.Midias[2].sprite);
        iconManager.SetIcon(1, EstadoDoJogo.Instance.Midias[3].sprite);

        switch (Textos.GetIdiomaSelecionado())
        {
            case Idiomas.INGLES:
                descricaoDoSelecionado.text = descricaoEua;
                break;
            case Idiomas.PORTUGUES:
                descricaoDoSelecionado.text = descricaoPT;
                break;
            case Idiomas.ESPANHOL:
                descricaoDoSelecionado.text = descricaoEspanhol;
                break;
            default:
                break;
        }
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
        molduraDeSelecao.enabled = false;

        if (EstadoDoJogo.Instance.NivelDeEnsino == NivelDeEnsino.EducacaoInfantil)
        {
            agrupamentosSprites = agrupamentosSpritesInfantil;
        }
        else
        {
            agrupamentosSprites = agrupamentosSpritesRegular;
        }

        agrupamentoEmFocoImagem.sprite = agrupamentosSprites[agrupamentoEmFoco];
        switch (Textos.GetIdiomaSelecionado())
        {
            case Idiomas.INGLES:
                descricaoDoSelecionado.text = descricaoEua;
                break;
            case Idiomas.PORTUGUES:
                descricaoDoSelecionado.text = descricaoPT;
                break;
            case Idiomas.ESPANHOL:
                descricaoDoSelecionado.text = descricaoEspanhol;
                break;
            default:
                break;
        }
    }

    private void atualizar(int agrupamentoEmFocoArg, bool mostrarSemSelecao = false)
    {
        if (agrupamentoEmFocoArg != -1)
        {
            if (mostrarSemSelecao)
            {
             //   descricaoDoSelecionado.text = agrupamentosDescricao[agrupamentoEmFocoArg];


                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas.INGLES:
                        descricaoDoSelecionado.text = agrupamentosDescricaoEua[agrupamentoEmFocoArg];
                        break;
                    case Idiomas.PORTUGUES:
                        descricaoDoSelecionado.text = agrupamentosDescricaoPtbr[agrupamentoEmFocoArg];
                        break;
                    case Idiomas.ESPANHOL:
                        descricaoDoSelecionado.text = agrupamentosDescricaoEspanhol[agrupamentoEmFocoArg];
                        break;
                    default:
                        break;
                }
            }
            else
            {
                if (primeiroAgrupamento)
                {
                    if(primeiroAgrupamentoSelecionado != -1)
                    {
                        switch (Textos.GetIdiomaSelecionado())
                        {
                            case Idiomas.INGLES:
                                descricaoDoSelecionado.text = agrupamentosDescricaoEua[primeiroAgrupamentoSelecionado];
                                break;
                            case Idiomas.PORTUGUES:
                                descricaoDoSelecionado.text = agrupamentosDescricaoPtbr[primeiroAgrupamentoSelecionado];
                                break;
                            case Idiomas.ESPANHOL:
                                descricaoDoSelecionado.text = agrupamentosDescricaoEspanhol[primeiroAgrupamentoSelecionado];
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        switch (Textos.GetIdiomaSelecionado())
                        {
                            case Idiomas.INGLES:
                                descricaoDoSelecionado.text = descricaoEua;
                                break;
                            case Idiomas.PORTUGUES:
                                descricaoDoSelecionado.text = descricaoPT;
                                break;
                            case Idiomas.ESPANHOL:
                                descricaoDoSelecionado.text = descricaoEspanhol;
                                break;
                            default:
                                break;
                        }

                    }
                    molduraDeSelecao.enabled = primeiroAgrupamentoSelecionado == agrupamentoEmFocoArg ? true : false;
                }
                else
                {

                    if (segundoAgrupamentoSelecionado != -1)
                    {
                        switch (Textos.GetIdiomaSelecionado())
                        {
                            case Idiomas.INGLES:
                                descricaoDoSelecionado.text = agrupamentosDescricaoEua[segundoAgrupamentoSelecionado];
                                break;
                            case Idiomas.PORTUGUES:
                                descricaoDoSelecionado.text = agrupamentosDescricaoPtbr[segundoAgrupamentoSelecionado];
                                break;
                            case Idiomas.ESPANHOL:
                                descricaoDoSelecionado.text = agrupamentosDescricaoEspanhol[segundoAgrupamentoSelecionado];
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        switch (Textos.GetIdiomaSelecionado())
                        {
                            case Idiomas.INGLES:
                                descricaoDoSelecionado.text = descricaoEua;
                                break;
                            case Idiomas.PORTUGUES:
                                descricaoDoSelecionado.text = descricaoPT;
                                break;
                            case Idiomas.ESPANHOL:
                                descricaoDoSelecionado.text = descricaoEspanhol;
                                break;
                            default:
                                break;
                        }

                    }
                    molduraDeSelecao.enabled = segundoAgrupamentoSelecionado == agrupamentoEmFocoArg ? true : false;
                }

                agrupamentoEmFocoImagem.sprite = agrupamentosSprites[agrupamentoEmFocoArg];
            }
        }
        else
        {
            switch (Textos.GetIdiomaSelecionado())
            {
                case Idiomas.INGLES:
                    descricaoDoSelecionado.text = descricaoEua;
                    break;
                case Idiomas.PORTUGUES:
                    descricaoDoSelecionado.text = descricaoPT;
                    break;
                case Idiomas.ESPANHOL:
                    descricaoDoSelecionado.text = descricaoEspanhol;
                    break;
                default:
                    break;
            }
            agrupamentoEmFocoImagem.sprite = agrupamentosSprites[0];
            molduraDeSelecao.enabled = false;
        }
    }

    private void atualizarEstadoDeJogo(int agrupamentoSelecionado)
    {
        if (agrupamentoSelecionado != -1)
        {
            switch (Textos.GetIdiomaSelecionado())
            {
                case Idiomas.INGLES:
                    descricaoDoSelecionado.text = agrupamentosDescricaoEua[agrupamentoSelecionado];
                    break;
                case Idiomas.PORTUGUES:
                    descricaoDoSelecionado.text = agrupamentosDescricaoPtbr[agrupamentoSelecionado];
                    break;
                case Idiomas.ESPANHOL:
                    descricaoDoSelecionado.text = agrupamentosDescricaoEspanhol[agrupamentoSelecionado];
                    break;
                default:
                    break;
            }

            if (primeiroAgrupamento)
            {
                EstadoDoJogo.Instance.Midias[2].agrupamento = agrupamentos[agrupamentoSelecionado];
            }
            else
            {
                EstadoDoJogo.Instance.Midias[3].agrupamento = agrupamentos[agrupamentoSelecionado];
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

    public void HoverEnter()
    {
        atualizar(agrupamentoEmFoco, true);
    }

    public void HoverExit()
    {
        atualizar(agrupamentoEmFoco);
    }

    private void ResetarAgrupamentos()
    {
        agrupamentoEmFoco = 0;
        agrupamentoEmFocoImagem.sprite = agrupamentosSprites[agrupamentoEmFoco];

        atualizar(agrupamentoEmFoco);

        botaoProximoAgrupamento.interactable = true;
        botaoAgrupamentoAnterior.interactable = false;


        switch (Textos.GetIdiomaSelecionado())
        {
            case Idiomas.INGLES:
                descricaoDoSelecionado.text = descricaoEua;
                break;
            case Idiomas.PORTUGUES:
                descricaoDoSelecionado.text = descricaoPT;
                break;
            case Idiomas.ESPANHOL:
                descricaoDoSelecionado.text = descricaoEspanhol;
                break;
            default:
                break;
        }
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
