
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
    [SerializeField] [TextArea] private string descricaoPT;
    [SerializeField][TextArea] private string descricaoPadrao;
    [SerializeField][TextArea] private string descricaoEua;
    [SerializeField][TextArea] private string descricaoEspanhol;
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
    private IconeMidias iconeSelecionado;
    public Image icone2;
    public Image icone3;
    public Sprite fundoRoxo;

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

        switch (Textos.GetIdiomaSelecionado())
        {
            case Idiomas.INGLES:
                descriptionText.text = descricaoEua;
                break;
            case Idiomas.PORTUGUES:
                descriptionText.text = descricaoPT;
                break;
            case Idiomas.ESPANHOL:
                descriptionText.text = descricaoEspanhol;
                break;
            default:
                break;
        }

        if (tituloSala2)
        tituloSala2.text = "<b>Pegue dentro do armário mídias para utilizar </b>" + "<b>" +  locationName +"</b>";
    }

    protected override void OnEnable()
    {
        AtualizarTextos();

        if (textoAjuda)                           
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

        switch (Textos.GetIdiomaSelecionado())
        {
            case Idiomas.INGLES:
                descriptionText.text = descricaoEua;
                break;
            case Idiomas.PORTUGUES:
                descriptionText.text = descricaoPT;
                break;
            case Idiomas.ESPANHOL:
                descriptionText.text = descricaoEspanhol;
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

    public void Selecao(IconeMidias icone)
    {
        AudioManager.instance.TocarSFX("clique");
        if (SceneManager.GetActiveScene().name == "Mídias Pós Sala 1.1")
        {
            iconManager.ShowIcon(2);
            if (!icone.selecionado)  // O ícone foi selecionado
            {
                if (primeiraMidia)
                {
                    if (segundoIconeSelecionado != null)
                    {
                        segundoIconeSelecionado.selecionado = false;
                    }

                    segundoIconeSelecionado = icone;
                }
                else
                {
                    if (terceiroIconeSelecionado != null)
                    {
                        terceiroIconeSelecionado.selecionado = false;
                    }

                    terceiroIconeSelecionado = icone;
                }

                // Posiciona o anel de seleção sobre o botão selecionado
                anelDeSelecao.enabled = true;
                anelDeSelecao.transform.SetParent(icone.transform);
                anelDeSelecao.rectTransform.anchoredPosition = Vector2.zero;
                iconeSelecionado = icone;
                atualizar(icone);



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

            }
            else  // Cancela a seleção do ícone caso o jogador clique nele de novo
            {
                // Redefine a seleção
                if (primeiraMidia)
                {
                    segundoIconeSelecionado = null;
                }
                else
                {
                    terceiroIconeSelecionado = null;
                }

                anelDeSelecao.enabled = false;

                resetar();
                if (!primeiraMidia)
                {
                    botaoConfirmar.interactable = false;
                }
                else
                {
                    botaoProximaMidia.interactable = false;
                }
            }
        }
        else
        {

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
                iconeSelecionado = icone;
                atualizar(icone);



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
        }
        

        icone.selecionado = !icone.selecionado;  // Inverte o estado de seleção
    }

    public void HoverEnter(IconeMidias icone)
    {
        if (SceneManager.GetActiveScene().name == "Mídias Pós Sala 1.1")
        {
            if (primeiraMidia)
            {
                if (segundoIconeSelecionado == null)
                {
                    atualizar(icone);
                }
            }
            else
            {
                if (terceiroIconeSelecionado == null)
                {
                    atualizar(icone);
                }
            }
        }
        else
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

    
    }

    public void HoverExit()
    {
        if (SceneManager.GetActiveScene().name == "Mídias Pós Sala 1.1")
        {
            if (primeiraMidia)
            {
                if (segundoIconeSelecionado == null)
                {
                    resetar();
                }
            }
            else
            {
                if (terceiroIconeSelecionado == null)
                {
                    resetar();
                }
            }
        }
        else
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
   
    }

    private void atualizar(IconeMidias icone)
    {
        descriptionText.text = icone.midia.descricao;
    }

    private void resetar()
    {
        switch (Textos.GetIdiomaSelecionado())
        {
            case Idiomas.INGLES:
                descriptionText.text = descricaoEua;
                break;
            case Idiomas.PORTUGUES:
                descriptionText.text = descricaoPT;
                break;
            case Idiomas.ESPANHOL:
                descriptionText.text = descricaoEspanhol;
                break;
            default:
                break;
        }
    }

    private void atualizarEstadoDeJogo(IconeMidias icone)
    {
        int indice = segundaEtapa ? 2 : 0;
        int indiceIcone = 0;
        if (!primeiraMidia)
        {
            indice++;
        }

        if (SceneManager.GetActiveScene().name == "Mídias Pós Sala 1.1")
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

        Debug.Log(EstadoDoJogo.Instance.Midias[0].nomeMidia);
        Debug.Log(EstadoDoJogo.Instance.Midias[1].nomeMidia);
        Debug.Log(EstadoDoJogo.Instance.Midias[2].nomeMidia);

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
        atualizarEstadoDeJogo(iconeSelecionado);
        if (SceneManager.GetActiveScene().name == "Mídias Pós Sala 1.1")
        {
            subtitulo.text = "Escolha a mídia para o momento final da aula";
        }
        OnViewAdvance.Invoke(this);
        primeiraMidia = false;
        if (SceneManager.GetActiveScene().name == "Mídias Pós Sala 1.1")
        {

            segundoIconeSelecionado.GetComponent<Button>().interactable = false;

            if (terceiroIconeSelecionado != null)
            {
                terceiroIconeSelecionado.GetComponent<Button>().interactable = true;
            }
            if (setaPrimeiraMidia.activeInHierarchy)
            {
                setaPrimeiraMidia.SetActive(false);
                setaSegundaMidia.SetActive(true);
            }
            else if (setaSegundaMidia.activeInHierarchy)
            {
                setaSegundaMidia.SetActive(false);
                if (setaTerceiraMidia)
                    setaTerceiraMidia.SetActive(true);
            }
        }
        else
        {

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
            else if (setaSegundaMidia.activeInHierarchy)
            {
                setaSegundaMidia.SetActive(false);
                if (setaTerceiraMidia)
                    setaTerceiraMidia.SetActive(true);
            }
        }

        if(botaoPainelAnterior)
        botaoPainelAnterior.SetActive(false);

        botaoProximaMidia.gameObject.SetActive(false);
        // botaoMidiaAnterior.SetActive(true);
        botaoConfirmar.gameObject.SetActive(true);

        ResetarPaginas();
        resetar();
    }

    public void Voltar()
    {
        Debug.Log("cliquei voltar");
        OnViewReturn.Invoke(this);
        primeiraMidia = true;
  
        if(SceneManager.GetActiveScene().name == "Mídias Pós Sala 1.1")
        {

            setaTerceiraMidia.SetActive(false);
            setaSegundaMidia.SetActive(true);
            segundoIconeSelecionado.GetComponent<Button>().interactable = true;
            icone2.sprite = fundoRoxo;
            icone3.sprite = fundoRoxo;
            if (terceiroIconeSelecionado != null)
            {
                terceiroIconeSelecionado.selecionado = false;
            }

        }
        else
        {
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
                if (setaTerceiraMidia)
                    setaPrimeiraMidia.SetActive(true);
            }
            else if (setaTerceiraMidia)
            {
                if (setaTerceiraMidia.activeInHierarchy)
                {
                    setaTerceiraMidia.SetActive(false);
                    setaSegundaMidia.SetActive(true);
                }
            }
        
        }
   
        if(botaoPainelAnterior)
        botaoPainelAnterior.SetActive(true);

        botaoProximaMidia.gameObject.SetActive(true);
        botaoConfirmar.gameObject.SetActive(false);
        botaoMidiaAnterior.SetActive(false);
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
        if (SceneManager.GetActiveScene().name == "Mídias Pós Sala 1.1")
        {
            for (int i = 0; i < paginas.Length; i++)
            {
                paginas[i].SetActive(false);
            }
        }
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
        if(botaoPaginaAnterior)
        botaoPaginaAnterior.interactable = paginaAtual > 0;
    }
}
