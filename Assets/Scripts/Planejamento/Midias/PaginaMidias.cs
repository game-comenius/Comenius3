using UnityEngine;
using UnityEngine.UI;

public class PaginaMidias : MonoBehaviour
{
    [SerializeField] private string nomePadrao;
    [SerializeField] private IconManager iconManager;
    [SerializeField] private Text nomeDoSelecionado;
    [SerializeField] private Text descricaoDoSelecionado;
    [SerializeField] private Button botaoConfirmar;
    [SerializeField] private Button botaoProximaMidia;
    [SerializeField] private GameObject botaoMidiaAnterior;
    [SerializeField] private GameObject botaoPainelAnterior;
    [SerializeField] private Image anelDeSelecao;
    [SerializeField] [TextArea] private string descricaoPadrao;
    [SerializeField] [TextArea] private string ajuda;
    [SerializeField] private Text textoAjuda;
    [SerializeField] private GameObject[] paginas;
    [SerializeField] private Button botaoProximaPagina;
    [SerializeField] private Button botaoPaginaAnterior;

    private IconeMidias primeiroIconeSelecionado;
    private IconeMidias segundoIconeSelecionado;
    private bool primeiraMidia;
    private int paginaAtual;

    private void Start()
    {
        anelDeSelecao.enabled = false;
        botaoConfirmar.interactable = false;
        botaoProximaMidia.interactable = false;
        primeiraMidia = true;
        paginaAtual = 0;

        nomeDoSelecionado.text = nomePadrao;
        descricaoDoSelecionado.text = descricaoPadrao;
    }

    private void OnEnable()
    {
        textoAjuda.text = ajuda;

        iconManager.ShowIcon(1);

        if (primeiroIconeSelecionado)
        {
            iconManager.SetIcon(0, primeiroIconeSelecionado.GetComponent<Image>().sprite);
            primeiraMidia = false;
        }

        if (segundoIconeSelecionado)
        {
            iconManager.SetIcon(1, segundoIconeSelecionado.GetComponent<Image>().sprite);
        }
    }

    private void OnDisable()
    {
        iconManager.ResetIcon(0);
        iconManager.ResetIcon(1);
        iconManager.HideIcon(1);
    }

    public void Selecao(IconeMidias icone)
    {
        AudioManager.instance.TocarSFX("clique");

        if (!icone.selecionado)  // O ícone foi selecionado
        {
            if (primeiraMidia)
            {
                if (primeiroIconeSelecionado)
                {
                    primeiroIconeSelecionado.selecionado = false;
                }

                primeiroIconeSelecionado = icone;
            }
            else
            {
                if (segundoIconeSelecionado)
                {
                    segundoIconeSelecionado.selecionado = false;
                }

                segundoIconeSelecionado = icone;
            }

            // Posiciona o anel de seleção sobre o botão selecionado
            anelDeSelecao.enabled = true;
            var posicaoDoIcone = icone.GetComponent<RectTransform>().anchoredPosition;
            anelDeSelecao.rectTransform.anchoredPosition = posicaoDoIcone;

            atualizarTexto(icone);
            atualizarEstadoDeJogo(icone);
        }
        else  // Cancela a seleção do ícone caso o jogador clique nele de novo
        {
            // Redefine a seleção
            if (primeiraMidia)
            {
                primeiroIconeSelecionado = null;
            }
            else
            {
                segundoIconeSelecionado = null;
            }

            anelDeSelecao.enabled = false;

            resetarTexto();
            resetarEstadoDeJogo();
        }

        icone.selecionado = !icone.selecionado;  // Inverte o estado de seleção
    }

    public void HoverEnter(IconeMidias icone)
    {
        if (primeiraMidia)
        {
            if (!primeiroIconeSelecionado)
            {
                atualizarTexto(icone);
            }
        }
        else
        {
            if (!segundoIconeSelecionado)
            {
                atualizarTexto(icone);
            }
        }
    }

    public void HoverExit()
    {
        if (primeiraMidia)
        {
            if (!primeiroIconeSelecionado)
            {
                resetarTexto();
            }
        }
        else
        {
            if (!segundoIconeSelecionado)
            {
                resetarTexto();
            }
        }
    }

    public void atualizarTexto(IconeMidias icone)
    {
        nomeDoSelecionado.text = icone.midia.nome;
        descricaoDoSelecionado.text = icone.midia.descricao;
    }

    public void resetarTexto()
    {
        nomeDoSelecionado.text = nomePadrao;
        descricaoDoSelecionado.text = descricaoPadrao;
    }

    public void atualizarEstadoDeJogo(IconeMidias icone)
    {
        // Altera o sprite do pequeno guia da página para o sprite do selecionado
        int indice = 0;

        if (!primeiraMidia)
        {
            indice = 1;
            botaoConfirmar.interactable = true;
        }
        else
        {
            botaoProximaMidia.interactable = true;
        }

        iconManager.SetIcon(indice, icone.GetComponent<Image>().sprite);
        EstadoDoJogo.Instance.MidiasSelecionadas[indice] = icone.midia;
        EstadoDoJogo.Instance.MidiasSelecionadas[indice].sprite = icone.GetComponent<Image>().sprite;
    }

    public void resetarEstadoDeJogo()
    {
        int indice = 0;

        if (!primeiraMidia)
        {
            indice = 1;
            botaoConfirmar.interactable = false;
        }
        else
        {
            botaoProximaMidia.interactable = false;
        }

        iconManager.ResetIcon(indice);
        EstadoDoJogo.Instance.MidiasSelecionadas[indice].sprite = null;
        EstadoDoJogo.Instance.MidiasSelecionadas[indice] = null;
    }

    public void Confirmar()
    {
        primeiraMidia = false;

        botaoPainelAnterior.SetActive(false);
        botaoProximaMidia.gameObject.SetActive(false);
        botaoMidiaAnterior.SetActive(true);
        botaoConfirmar.gameObject.SetActive(true);

        ResetarPaginas();
        resetarTexto();
    }

    public void Voltar()
    {
        primeiraMidia = true;

        botaoPainelAnterior.SetActive(true);
        botaoProximaMidia.gameObject.SetActive(true);
        botaoMidiaAnterior.SetActive(false);
        botaoConfirmar.gameObject.SetActive(false);

        ResetarPaginas();
        resetarTexto();
    }

    public void AvancarPagina()
    {
        paginas[paginaAtual].SetActive(false);
        paginaAtual++;
        anelDeSelecao.gameObject.transform.SetParent(paginas[paginaAtual].transform);
        paginas[paginaAtual].SetActive(true);

        DefinirEstadoDoAnelDeSelecao();

        if (paginaAtual + 1 == paginas.Length)
        {
            botaoProximaPagina.interactable = false;
        }
        else if (paginaAtual == 1)
        {
            botaoPaginaAnterior.interactable = true;
        }
    }

    public void VoltarPagina()
    {
        paginas[paginaAtual].SetActive(false);
        paginaAtual--;
        anelDeSelecao.gameObject.transform.SetParent(paginas[paginaAtual].transform);
        paginas[paginaAtual].SetActive(true);

        DefinirEstadoDoAnelDeSelecao();

        if (paginaAtual == paginas.Length - 2)
        {
            botaoProximaPagina.interactable = true;
        }
        else if (paginaAtual == 0)
        {
            botaoPaginaAnterior.interactable = false;
        }
    }

    private void ResetarPaginas()
    {
        paginas[paginaAtual].SetActive(false);
        paginaAtual = 0;
        anelDeSelecao.gameObject.transform.SetParent(paginas[paginaAtual].transform);
        paginas[paginaAtual].SetActive(true);

        DefinirEstadoDoAnelDeSelecao();

        botaoProximaPagina.interactable = true;
        botaoPaginaAnterior.interactable = false;
    }

    private void DefinirEstadoDoAnelDeSelecao()
    {
        if (primeiraMidia)
        {
            if (primeiroIconeSelecionado != null)
            {
                if (primeiroIconeSelecionado.gameObject.activeInHierarchy)
                {
                    anelDeSelecao.enabled = true;
                    var posicaoDoIcone = primeiroIconeSelecionado.GetComponent<RectTransform>().anchoredPosition;
                    anelDeSelecao.rectTransform.anchoredPosition = posicaoDoIcone;
                    return;
                }
            }
        }
        else
        {
            if (segundoIconeSelecionado != null)
            {
                if (segundoIconeSelecionado.gameObject.activeInHierarchy)
                {
                    anelDeSelecao.enabled = true;
                    var posicaoDoIcone = segundoIconeSelecionado.GetComponent<RectTransform>().anchoredPosition;
                    anelDeSelecao.rectTransform.anchoredPosition = posicaoDoIcone;
                    return;
                }
            }
        }

        anelDeSelecao.enabled = false;
    }
}
