
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PaginaMidias : PaginaPlanejamento
{
    [System.Serializable] public class ViewAdvance : UnityEvent<PaginaMidias> { }
    public ViewAdvance OnViewAdvance;

    [System.Serializable] public class ViewReturn : UnityEvent<PaginaMidias> { }
    public ViewReturn OnViewReturn;

    [SerializeField] private TextMeshProUGUI descriptionText;
    [SerializeField] private Button botaoConfirmar;
    [SerializeField] private Image anelDeSelecao;
    [SerializeField] [TextArea] private string descricaoPadrao;
    [SerializeField] private Button botaoProximaMidia;
    [SerializeField] private GameObject botaoMidiaAnterior;
    [SerializeField] private GameObject botaoPainelAnterior;
    [SerializeField] private GameObject[] paginas;
    [SerializeField] private Button botaoProximaPagina;
    [SerializeField] private Button botaoPaginaAnterior;
    [SerializeField] private bool segundaEtapa;
    [SerializeField] private GameObject setaPrimeiraMidia;
    [SerializeField] private GameObject setaSegundaMidia;
    [SerializeField] private GameObject setaTerceiraMidia;

    [SerializeField] private Image mediaIcon;
    [SerializeField] private bool firstMedia;

    [SerializeField] private Text subtitulo;
    private IconeMidias primeiroIconeSelecionado;
    private IconeMidias segundoIconeSelecionado;
    private IconeMidias terceiroIconeSelecionado;
    public IconeMidias help;
    private bool primeiraMidia;
    private int paginaAtual;
    private string locationName;
    public Text tituloSala2;
    private void Start()
    {
        EstadoDoJogo gameState = EstadoDoJogo.Instance;
        gameState.Lugar = LocationChecker.EvaluateLocation();
        locationName = LocationChecker.EvaluateLocationName();

      
        if(SceneManager.GetActiveScene().name == "Mídias Pós Sala 1.1") {
            if (firstMedia)
            {
                mediaIcon.sprite = gameState.Midias[0].sprite;
            }
        
            else
                mediaIcon.sprite = gameState.Midias[1].sprite;

            subtitulo.text = "Escolha a mídia que será usada no: " + locationName;
        }

        anelDeSelecao.enabled = false;
        botaoConfirmar.interactable = false;
        botaoProximaMidia.interactable = false;
        primeiraMidia = true;
        paginaAtual = 0;

        descriptionText.text = descricaoPadrao;

        if(tituloSala2)
        tituloSala2.text = "<b>Pegue dentro do armário mídias para utilizar </b>" + "<b>" +  locationName +"</b>";
    }

    protected override void OnEnable()
    {
        if(textoAjuda)                           
        textoAjuda.text = ajuda;

        if(spriteFundo)
        fundo.sprite = spriteFundo;

        iconManager.ShowIcon(0);
        iconManager.ShowIcon(1);
        if (SceneManager.GetActiveScene().name == "Mídias Pós Sala 1.1")
        {
            iconManager.ShowIcon(2);
        }
        else
        {
            iconManager.HideIcon(2);
        }
         
        iconManager.HideIcon(3);

        if (primeiroIconeSelecionado != null)
        {
            iconManager.SetIcon(0, primeiroIconeSelecionado.GetComponent<Image>().sprite);
        }
        else
        {
            iconManager.ResetIcon(0);
        }

        if (segundoIconeSelecionado != null)
        {
            iconManager.SetIcon(1, segundoIconeSelecionado.GetComponent<Image>().sprite);
        }
        else
        {
            iconManager.ResetIcon(1);
        }
    }

    private void OnDisable()
    {
        iconManager.ResetIcon(0);
        iconManager.ResetIcon(1);
    }

    public void Selecao(IconeMidias icone)
    {
        Debug.Log(EstadoDoJogo.Instance.Midias.Length);

        AudioManager.instance.TocarSFX("clique");
        if (SceneManager.GetActiveScene().name == "Mídias Pós Sala 1.1")
        {
            iconManager.ShowIcon(2);
        }
        if (!icone.selecionado)  // O ícone foi selecionado
        {
            if (primeiraMidia)
            {
                if (primeiroIconeSelecionado != null)
                {
                    primeiroIconeSelecionado.selecionado = false;
                }

                primeiroIconeSelecionado = icone;
            }
            else
            {
                if (segundoIconeSelecionado != null)
                {
                    segundoIconeSelecionado.selecionado = false;
                }

                segundoIconeSelecionado = icone;
            }

            // Posiciona o anel de seleção sobre o botão selecionado
            anelDeSelecao.enabled = true;
            anelDeSelecao.transform.SetParent(icone.transform);
            anelDeSelecao.rectTransform.anchoredPosition = Vector2.zero;

            atualizar(icone);
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

            resetar();
            resetarEstadoDeJogo();
        }

        icone.selecionado = !icone.selecionado;  // Inverte o estado de seleção
    }

    public void HoverEnter(IconeMidias icone)
    {
        if (primeiraMidia)
        {
            if (primeiroIconeSelecionado == null)
            {
                atualizar(icone);
            }
        }
        else
        {
            if (segundoIconeSelecionado == null)
            {
                atualizar(icone);
            }
        }
    }

    public void HoverExit()
    {
        if (primeiraMidia)
        {
            if (primeiroIconeSelecionado == null)
            {
                resetar();
            }
        }
        else
        {
            if (segundoIconeSelecionado == null)
            {
                resetar();
            }
        }
    }

    private void atualizar(IconeMidias icone)
    {
        descriptionText.text = icone.midia.descricao;
    }

    private void resetar()
    {
        descriptionText.text = descricaoPadrao;
    }

    private void atualizarEstadoDeJogo(IconeMidias icone)
    {
        int indice = segundaEtapa ? 2 : 0;
        int indiceIcone = 0;

        if (!primeiraMidia)
        {
            indice++;
            indiceIcone++;
            botaoConfirmar.interactable = true;
        }
        else
        {
            botaoProximaMidia.interactable = true;
        }

        iconManager.SetIcon(indiceIcone, icone.GetComponent<Image>().sprite);
        if(SceneManager.GetActiveScene().name == "Mídias Pós Sala 1.1")
        {
            Midia[] temp = EstadoDoJogo.Instance.Midias;
            temp[indice + 1] = icone.midia;
            temp[indice + 1].sprite = icone.GetComponent<Image>().sprite;
            EstadoDoJogo.Instance.Midias = temp;
        }

        else if(SceneManager.GetActiveScene().name == "Sala de Aula ABProj 1-2")
        {
            Midia[] temp = EstadoDoJogo.Instance.Midias;
            temp[indice + 3] = icone.midia;
            temp[indice + 3].sprite = icone.GetComponent<Image>().sprite;
            EstadoDoJogo.Instance.Midias = temp;
        }
        else
        {
            Midia[] temp = EstadoDoJogo.Instance.Midias;
            temp[indice] = icone.midia;
            temp[indice].sprite = icone.GetComponent<Image>().sprite;
            EstadoDoJogo.Instance.Midias = temp;
        }
     
    }

    private void resetarEstadoDeJogo()
    {
        int indice = segundaEtapa ? 2 : 0;
        int indiceIcone = 0;

        if (!primeiraMidia)
        {
            indice++;
            indiceIcone++;
            botaoConfirmar.interactable = false;
        }
        else
        {
            botaoProximaMidia.interactable = false;
        }

        iconManager.ResetIcon(indiceIcone);

        Midia[] temp = EstadoDoJogo.Instance.Midias;
        temp[indice] = null;
        EstadoDoJogo.Instance.Midias = temp;
    }

    public void Confirmar()
    {
        if (SceneManager.GetActiveScene().name == "Mídias Pós Sala 1.1")
        {
            subtitulo.text = "Escolha a mídia para o momento final da aula";
        }
            OnViewAdvance.Invoke(this);
        primeiraMidia = false;

        primeiroIconeSelecionado.GetComponent<Button>().interactable = false;

        if (segundoIconeSelecionado != null)
        {
            segundoIconeSelecionado.GetComponent<Button>().interactable = true;
        }
        if (setaPrimeiraMidia.activeInHierarchy)
        {
            setaPrimeiraMidia.SetActive(false);
            setaSegundaMidia.SetActive(true);
        }
        else if(setaSegundaMidia.activeInHierarchy)
        {
            setaSegundaMidia.SetActive(false);
            if (setaTerceiraMidia)
                setaTerceiraMidia.SetActive(true);
        }
        else
        {

        }
        botaoPainelAnterior.SetActive(false);
        botaoProximaMidia.gameObject.SetActive(false);
        botaoMidiaAnterior.SetActive(true);
        botaoConfirmar.gameObject.SetActive(true);

        ResetarPaginas();
        resetar();
    }

    public void Voltar()
    {
        OnViewReturn.Invoke(this);
        primeiraMidia = true;

        primeiroIconeSelecionado.GetComponent<Button>().interactable = true;
    
        if (segundoIconeSelecionado != null)
        {
            segundoIconeSelecionado.GetComponent<Button>().interactable = false;
        }


        if (setaPrimeiraMidia.activeInHierarchy)
        {
            setaPrimeiraMidia.SetActive(true);
            setaSegundaMidia.SetActive(false);
        }
        else if (setaSegundaMidia.activeInHierarchy)
        {
            setaSegundaMidia.SetActive(false);
            if(setaTerceiraMidia)
            setaPrimeiraMidia.SetActive(true);
        }
        else if (setaTerceiraMidia.activeInHierarchy)
        {
            setaTerceiraMidia.SetActive(false);
            setaSegundaMidia.SetActive(true);
        }
        botaoPainelAnterior.SetActive(true);
        botaoProximaMidia.gameObject.SetActive(true);
        botaoMidiaAnterior.SetActive(false);
        botaoConfirmar.gameObject.SetActive(false);

        ResetarPaginas();
        resetar();
    }

    public void AvancarPagina()
    {
        paginas[paginaAtual].SetActive(false);
        paginaAtual++;
        anelDeSelecao.gameObject.transform.SetParent(paginas[paginaAtual].transform);
        paginas[paginaAtual].SetActive(true);

        DefinirEstadoDoAnelDeSelecao();
        AtualizarBotoes();
    }

    public void VoltarPagina()
    {
        paginas[paginaAtual].SetActive(false);
        paginaAtual--;
        anelDeSelecao.gameObject.transform.SetParent(paginas[paginaAtual].transform);
        paginas[paginaAtual].SetActive(true);

        DefinirEstadoDoAnelDeSelecao();
        AtualizarBotoes();
    }

    public void UpdateViewData(string defaultDescription, GameObject[] pages, Button nextButton, Button backButton)
    {
        descricaoPadrao = defaultDescription;
        paginas = pages;
        botaoProximaPagina = nextButton;
        botaoPaginaAnterior = backButton;

        AtualizarBotoes();
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

    private void AtualizarBotoes()
    {
        botaoProximaPagina.interactable = paginaAtual + 1 < paginas.Length;
        botaoPaginaAnterior.interactable = paginaAtual > 0;
    }
}
