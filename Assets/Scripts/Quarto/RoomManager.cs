using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RoomManager : MonoBehaviour
{
    public GameObject[] toyObjects;
    public GameObject[] mediaObjects;

    [SerializeField] private GameObject midia0;
    [SerializeField] private GameObject midia1;
    [SerializeField] private GameObject midia2;

    [SerializeField] private GameObject miniMidia0;
    [SerializeField] private GameObject miniMidia1;
    [SerializeField] private GameObject miniMidia2;

    [SerializeField] private GameObject previewMidia;

    [SerializeField] private GameObject popUpTipo;
    [SerializeField] private GameObject popUpNome;

    [SerializeField] private GameObject confirmacaoFeedback;

    [SerializeField] private GameObject quartoInfo;

    [SerializeField] private GameObject textoMidiaAtualObjeto;
    [SerializeField] private TextMeshProUGUI textoMidiaAtual;
    [SerializeField] private Image iconeMidiaAtual;

    [SerializeField] private TextMeshProUGUI textoFeedbackBrinquedo;
    [SerializeField] private TextMeshProUGUI textoFeedbackObjeto1;
    [SerializeField] private TextMeshProUGUI textoFeedbackObjeto2;

    [Header("Imagens das mídias e brinquedos")]
    [SerializeField] private Sprite estanteSprite;
    [SerializeField] private Sprite televisaoSprite;
    [SerializeField] private Sprite tabletSprite;
    [SerializeField] private Sprite consoleSprite;
    [SerializeField] private Sprite computadorSprite;
    [SerializeField] private Sprite celularSprite;
    [SerializeField] private Sprite legosSprite;
    [SerializeField] private Sprite quebraCabecaSprite;
    [SerializeField] private Sprite ioioSprite;
    [SerializeField] private Sprite blocosSprite;
    [SerializeField] private Sprite tecladoSprite;
    [SerializeField] private Sprite bolaSprite;
    [SerializeField] private Sprite livroDidaticoSprite;

    private int currentMedia;
    private string tempMedia;
    private string[] medias;
    private Sprite tempSprite;
    private TextMeshProUGUI[] feedbackTexts;
    private bool mediaCanBeSelected;

    void Start()
    {
        currentMedia = 0;
        mediaCanBeSelected = false;
        medias = new string[3];
        feedbackTexts = new TextMeshProUGUI[3];

        midia0.SetActive(false);
        midia1.SetActive(false);
        midia2.SetActive(false);

        feedbackTexts[0] = textoFeedbackBrinquedo;
        feedbackTexts[1] = textoFeedbackObjeto1;
        feedbackTexts[2] = textoFeedbackObjeto2;

        textoMidiaAtual.text = $"Escolha a atividade de lazer de acordo com a inteligência múltipla {EstadoDoJogo.Instance.Inteligencias.nome}.";
        iconeMidiaAtual.sprite = EstadoDoJogo.Instance.Inteligencias.sprite;

        UpdateObjects();
    }

    public void SelectObject(string name)
    {
        switch (name)
        {
            case "estante":
                tempMedia = name;
                tempSprite = estanteSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Mídia";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Livros";
                previewMidia.GetComponent<Image>().sprite = tempSprite;
                mediaCanBeSelected = false;
                break;
            case "televisao":
                tempMedia = name;
                tempSprite = televisaoSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Mídia";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Televisão";
                previewMidia.GetComponent<Image>().sprite = tempSprite;
                mediaCanBeSelected = false;
                break;
            case "tablet":
                tempMedia = name;
                tempSprite = tabletSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Mídia";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Tablet";
                previewMidia.GetComponent<Image>().sprite = tempSprite;
                mediaCanBeSelected = false;
                break;
            case "console":
                tempMedia = name;
                tempSprite = consoleSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Mídia";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Jogos";
                previewMidia.GetComponent<Image>().sprite = tempSprite;
                mediaCanBeSelected = false;
                break;
            case "computador":
                tempMedia = name;
                tempSprite = computadorSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Mídia";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Computador";
                previewMidia.GetComponent<Image>().sprite = tempSprite;
                mediaCanBeSelected = false;
                break;
            case "celular":
                tempMedia = name;
                tempSprite = celularSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Mídia";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Celular";
                previewMidia.GetComponent<Image>().sprite = tempSprite;
                mediaCanBeSelected = false;
                break;
            case "livro didático":
                tempMedia = name;
                tempSprite = livroDidaticoSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Mídia";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Livro Didático";
                previewMidia.GetComponent<Image>().sprite = tempSprite;
                mediaCanBeSelected = false;
                break;
            case "caderno e estojo":
                tempMedia = name;
                tempSprite = livroDidaticoSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Mídia";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Caderno e Estojo";
                previewMidia.GetComponent<Image>().sprite = tempSprite;
                mediaCanBeSelected = false;
                break;
            case "legos":
                tempMedia = name;
                tempSprite = legosSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Atividade de Lazer";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Legos";
                previewMidia.GetComponent<Image>().sprite = tempSprite;
                mediaCanBeSelected = true;
                break;
            case "quebra cabeca":
                tempMedia = name;
                tempSprite = quebraCabecaSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Atividade de Lazer";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Quebra-cabeça";
                previewMidia.GetComponent<Image>().sprite = tempSprite;
                mediaCanBeSelected = true;
                break;
            case "io io":
                tempMedia = name;
                tempSprite = ioioSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Atividade de Lazer";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Ioiô";
                previewMidia.GetComponent<Image>().sprite = tempSprite;
                mediaCanBeSelected = true;
                break;
            case "blocos":
                tempMedia = name;
                tempSprite = blocosSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Atividade de Lazer";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Blocos";
                previewMidia.GetComponent<Image>().sprite = tempSprite;
                mediaCanBeSelected = true;
                break;
            case "teclado":
                tempMedia = name;
                tempSprite = tecladoSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Atividade de Lazer";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Teclado";
                previewMidia.GetComponent<Image>().sprite = tempSprite;
                mediaCanBeSelected = true;
                break;
            case "bola":
                tempMedia = name;
                tempSprite = bolaSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Atividade de Lazer";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Bola";
                previewMidia.GetComponent<Image>().sprite = tempSprite;
                mediaCanBeSelected = true;
                break;
            default:
                break;
        }

        UpdateObjects();
    }

    [System.Obsolete("Este método não é usado.")]
    public void onClickDefinitivo()
    {
        switch (currentMedia)
        {
            case 0:
                midia0.GetComponent<SpriteRenderer>().sprite = tempSprite;
                miniMidia0.GetComponent<SpriteRenderer>().sprite = EstadoDoJogo.Instance.Inteligencias.sprite;
                midia0.SetActive(true);
                textoMidiaAtual.text = $"Escolha o objeto que com o qual será utilizado a mídia {EstadoDoJogo.Instance.Midias[0].nome}.";
                iconeMidiaAtual.sprite = EstadoDoJogo.Instance.Midias[0].sprite;
                break;
            case 1:
                midia1.GetComponent<SpriteRenderer>().sprite = tempSprite;
                miniMidia1.GetComponent<SpriteRenderer>().sprite = EstadoDoJogo.Instance.Midias[0].sprite;
                midia1.SetActive(true);
                textoMidiaAtual.text = $"Escolha o objeto que com o qual será utilizado a mídia {EstadoDoJogo.Instance.Midias[1].nome}.";
                iconeMidiaAtual.sprite = EstadoDoJogo.Instance.Midias[1].sprite;
                break;
            default:
                midia2.GetComponent<SpriteRenderer>().sprite = tempSprite;
                miniMidia2.GetComponent<SpriteRenderer>().sprite = EstadoDoJogo.Instance.Midias[1].sprite;
                midia2.SetActive(true);
                break;
        }

        if (currentMedia < 2)
        {
            medias[currentMedia] = tempMedia;
            Debug.Log(currentMedia);
            currentMedia++;
            Debug.Log(currentMedia);
        }
        else
        {
            medias[currentMedia] = tempMedia;
            Debug.Log(currentMedia);
            setToyFeedback();
            setObjectFeedback(0);
            setObjectFeedback(1);
            confirmacaoFeedback.SetActive(true);
            textoMidiaAtualObjeto.SetActive(false);
            quartoInfo.SetActive(false);
            Debug.Log(medias[0] + " " + medias[1] + " " + medias[2]);
        }
    }

    public void reset()
    {
        currentMedia = 0;
        medias = new string[3];
        Start();
    }

    public void setToyFeedback()
    {
        var estadoDoJogo = EstadoDoJogo.Instance;
        string nomeInteligencia = estadoDoJogo.Inteligencias.nome;

        switch (nomeInteligencia)
        {

            case ("Corporal-cinestésica e Naturalista"):
                switch (medias[0])
                {
                    case "console":
                        textoFeedbackBrinquedo.text = $"<color=red>Não me diverti muito, pra mim jogar videogame é meio chato";
                        break;
                    case "legos":
                        textoFeedbackBrinquedo.text = $"<color=red>Não me diverti muito, pra mim montar legos é meio chato";
                        break;
                    case "quebra cabeca":
                        textoFeedbackBrinquedo.text = $"<color=red>Não me diverti muito, pra mim resolver quebra-cabeças é meio chato";
                        break;
                    case "io io":
                        textoFeedbackBrinquedo.text = $"<color=red>Não me diverti muito, pra mim brincar com iô-iô não tem graça";
                        break;
                    case "blocos":
                        textoFeedbackBrinquedo.text = "Me diverti muito montando os blocos";
                        break;
                    case "teclado":
                        textoFeedbackBrinquedo.text = "Me diverti muito criando músicas novas";
                        break;
                    case "bola":
                        textoFeedbackBrinquedo.text = "Me diverti muito jogando com a bola";
                        break;
                    default:
                        break;
                }
                break;

            case ("Intrapessoal e Espacial-visual"):
                switch (medias[0])
                {
                    case "console":
                        textoFeedbackBrinquedo.text = "Me diverti muito jogando um game";
                        break;
                    case "legos":
                        textoFeedbackBrinquedo.text = $"<color=red>Não tenho certeza se me diverti com legos";
                        break;
                    case "quebra cabeca":
                        textoFeedbackBrinquedo.text = "Me diverti muito conseguindo montar o quebra-cabeças";
                        break;
                    case "io io":
                        textoFeedbackBrinquedo.text = $"<color=red>Não tenho certeza se me diverti com iô-iô";
                        break;
                    case "blocos":
                        textoFeedbackBrinquedo.text = "Me diverti muito montando os blocos";
                        break;
                    case "teclado":
                        textoFeedbackBrinquedo.text = $"<color=red>Não me diverti muito, pra mim tocar teclado é meio chato";
                        break;
                    case "bola":
                        textoFeedbackBrinquedo.text = $"<color=red>Não me diverti muito, pra mim jogar bola é meio chato";
                        break;
                    default:
                        break;
                }
                break;

            case ("Interpessoal e Musical"):
                switch (medias[0])
                {
                    case "console":
                        textoFeedbackBrinquedo.text = "Me diverti muito jogando um game";
                        break;
                    case "legos":
                        textoFeedbackBrinquedo.text = $"<color=red>Não me diverti muito, pra mim montar legos é meio chato";
                        break;
                    case "quebra cabeca":
                        textoFeedbackBrinquedo.text = $"<color=red>Não me diverti muito, pra mim resolver quebra-cabeças é meio chato";
                        break;
                    case "io io":
                        textoFeedbackBrinquedo.text = $"<color=red>Não me diverti muito, pra mim brincar com iô-iô não tem graça";
                        break;
                    case "blocos":
                        textoFeedbackBrinquedo.text = $"<color=red>Não me diverti muito, pra mim montar blocos é meio chato";
                        break;
                    case "teclado":
                        textoFeedbackBrinquedo.text = "Me diverti muito criando músicas novas";
                        break;
                    case "bola":
                        textoFeedbackBrinquedo.text = "Me diverti muito jogando com a bola";
                        break;
                    default:
                        break;
                }
                break;

            case ("Linguística e Lógico-matemática"):
                switch (medias[0])
                {
                    case "console":
                        textoFeedbackBrinquedo.text = $"<color=red>Não me diverti muito, pra mim jogar videogame é meio chato";
                        break;
                    case "legos":
                        textoFeedbackBrinquedo.text = $"<color=red>Não tenho certeza se me diverti com legos";
                        break;
                    case "quebra cabeca":
                        textoFeedbackBrinquedo.text = "Me diverti muito conseguindo montar o quebra-cabeças";
                        break;
                    case "io io":
                        textoFeedbackBrinquedo.text = $"<color=red>Não tenho certeza se me diverti com iô-iô";
                        break;
                    case "blocos":
                        textoFeedbackBrinquedo.text = "Me diverti muito montando os blocos";
                        break;
                    case "teclado":
                        textoFeedbackBrinquedo.text = $"<color=red>Não me diverti muito, pra mim tocar teclado é meio chato";
                        break;
                    case "bola":
                        textoFeedbackBrinquedo.text = $"<color=red>Não me diverti muito, pra mim jogar bola é meio chato";
                        break;
                    default:
                        break;
                }
                break;
            default:
                break;
        }
    }

    public void setObjectFeedback(int index)
    {
        var estadoDoJogo = EstadoDoJogo.Instance;
        string nomeMidia = estadoDoJogo.Midias[index].nome;

        switch (nomeMidia)
        {
            case ("Jogos"):
                switch (medias[index + 1])
                {
                    case ("console"):
                        feedbackTexts[index + 1].text = index == 0 ? "Consegui fazer as atividades com o console" : "e consegui fazer as atividades com o console";
                        break;
                    case ("computador"):
                        feedbackTexts[index + 1].text = index == 0 ? "Consegui fazer as atividades com o computador" : "e consegui fazer as atividades com o computador";
                        break;
                    case ("celular"):
                        feedbackTexts[index + 1].text = index == 0 ? "Consegui fazer as atividades com o celular" : "e consegui fazer as atividades com o celular";
                        break;
                    case ("tablet"):
                        feedbackTexts[index + 1].text = index == 0 ? "Consegui fazer as atividades com o tablet" : "e consegui fazer as atividades com o tablet";
                        break;
                    case ("estante"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o livro" : $"<color=red>e não consegui fazer as atividades com o livro";
                        break;
                    case ("televisao"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com a televisão" : $"<color=red>e não consegui fazer as atividades com a televisão";
                        break;
                    default:
                        break;
                }
                break;

            case ("Redes Sociais"):
                switch (medias[index + 1])
                {
                    case ("console"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o console" : $"<color=red>e não consegui fazer as atividades com o console";
                        break;
                    case ("computador"):
                        feedbackTexts[index + 1].text = index == 0 ? "Consegui fazer as atividades com o computador" : "e consegui fazer as atividades com o computador";
                        break;
                    case ("celular"):
                        feedbackTexts[index + 1].text = index == 0 ? "Consegui fazer as atividades com o celular" : "e consegui fazer as atividades com o celular";
                        break;
                    case ("tablet"):
                        feedbackTexts[index + 1].text = index == 0 ? "Consegui fazer as atividades com o tablet" : "e consegui fazer as atividades com o tablet";
                        break;
                    case ("estante"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o livro" : $"<color=red>e não consegui fazer as atividades com o livro";
                        break;
                    case ("televisao"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com a televisão" : $"<color=red>e não consegui fazer as atividades com a televisão";
                        break;
                    default:
                        break;
                }
                break;

            case ("Editores de Áudio e Vídeo"):
                switch (medias[index + 1])
                {
                    case ("console"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o console" : $"<color=red>e não consegui fazer as atividades com o console";
                        break;
                    case ("computador"):
                        feedbackTexts[index + 1].text = index == 0 ? "Consegui fazer as atividades com o computador" : "e consegui fazer as atividades com o computador";
                        break;
                    case ("celular"):
                        feedbackTexts[index + 1].text = index == 0 ? "Consegui fazer as atividades com o celular" : "e consegui fazer as atividades com o celular";
                        break;
                    case ("tablet"):
                        feedbackTexts[index + 1].text = index == 0 ? "Consegui fazer as atividades com o tablet" : "e consegui fazer as atividades com o tablet";
                        break;
                    case ("estante"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o livro" : $"<color=red>e não consegui fazer as atividades com o livro";
                        break;
                    case ("televisao"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com a televisão" : $"<color=red>e não consegui fazer as atividades com a televisão";
                        break;
                    default:
                        break;
                }
                break;

            case ("Plataformas"):
                switch (medias[index + 1])
                {
                    case ("console"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o console" : $"<color=red>e não consegui fazer as atividades com o console";
                        break;
                    case ("computador"):
                        feedbackTexts[index + 1].text = index == 0 ? "Consegui fazer as atividades com o computador" : "e consegui fazer as atividades com o computador";
                        break;
                    case ("celular"):
                        feedbackTexts[index + 1].text = index == 0 ? "Consegui fazer as atividades com o celular" : "e consegui fazer as atividades com o celular";
                        break;
                    case ("tablet"):
                        feedbackTexts[index + 1].text = index == 0 ? "Consegui fazer as atividades com o tablet" : "e consegui fazer as atividades com o tablet";
                        break;
                    case ("estante"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o livro" : $"<color=red>e não consegui fazer as atividades com o livro";
                        break;
                    case ("televisao"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com a televisão" : $"<color=red>e não consegui fazer as atividades com a televisão";
                        break;
                    default:
                        break;
                }
                break;

            case ("Aplicativos"):
                switch (medias[index + 1])
                {
                    case ("console"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o console" : $"<color=red>e não consegui fazer as atividades com o console";
                        break;
                    case ("computador"):
                        feedbackTexts[index + 1].text = index == 0 ? "Consegui fazer as atividades com o computador" : "e consegui fazer as atividades com o computador";
                        break;
                    case ("celular"):
                        feedbackTexts[index + 1].text = index == 0 ? "Consegui fazer as atividades com o celular" : "e consegui fazer as atividades com o celular";
                        break;
                    case ("tablet"):
                        feedbackTexts[index + 1].text = index == 0 ? "Consegui fazer as atividades com o tablet" : "e consegui fazer as atividades com o tablet";
                        break;
                    case ("estante"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o livro" : $"<color=red>e não consegui fazer as atividades com o livro";
                        break;
                    case ("televisao"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com a televisão" : $"<color=red>e não consegui fazer as atividades com a televisão";
                        break;
                    default:
                        break;
                }
                break;

            case ("Editores de Texto e Planilhas Eletrônicas"):
                switch (medias[index + 1])
                {
                    case ("console"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o console" : $"<color=red>e não consegui fazer as atividades com o console";
                        break;
                    case ("computador"):
                        feedbackTexts[index + 1].text = index == 0 ? "Consegui fazer as atividades com o computador" : "e consegui fazer as atividades com o computador";
                        break;
                    case ("celular"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o celular" : $"<color=red>e não consegui fazer as atividades com o celular";
                        break;
                    case ("tablet"):
                        feedbackTexts[index + 1].text = index == 0 ? "Consegui fazer as atividades com o tablet" : "e consegui fazer as atividades com o tablet";
                        break;
                    case ("estante"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o livro" : $"<color=red>e não consegui fazer as atividades com o livro";
                        break;
                    case ("televisao"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com a televisão" : $"<color=red>e não consegui fazer as atividades com a televisão";
                        break;
                    default:
                        break;
                }
                break;

            case ("Cadernos e Cartazes"):
                switch (medias[index + 1])
                {
                    case ("console"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o console" : $"<color=red>e não consegui fazer as atividades com o console";
                        break;
                    case ("computador"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o computador" : $"<color=red>e não consegui fazer as atividades com o computador";
                        break;
                    case ("celular"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o celular" : $"<color=red>e não consegui fazer as atividades com o celular";
                        break;
                    case ("tablet"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o tablet" : $"<color=red>e não consegui fazer as atividades com o tablet";
                        break;
                    case ("estante"):
                        feedbackTexts[index + 1].text = index == 0 ? "Consegui fazer as atividades com o livro" : "e consegui fazer as atividades com o livro";
                        break;
                    case ("televisao"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com a televisão" : $"<color=red>e não consegui fazer as atividades com a televisão";
                        break;
                    default:
                        break;
                }
                break;

            case ("Televisão"):
                switch (medias[index + 1])
                {
                    case ("console"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o console" : $"<color=red>e não consegui fazer as atividades com o console";
                        break;
                    case ("computador"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o computador" : $"<color=red>e não consegui fazer as atividades com o computador";
                        break;
                    case ("celular"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o celular" : $"<color=red>e não consegui fazer as atividades com o celular";
                        break;
                    case ("tablet"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o tablet" : $"<color=red>e não consegui fazer as atividades com o tablet";
                        break;
                    case ("estante"):
                        feedbackTexts[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o livro" : $"<color=red>e não consegui fazer as atividades com o livro";
                        break;
                    case ("televisao"):
                        feedbackTexts[index + 1].text = index == 0 ? "Consegui fazer as atividades com a televisão" : "e consegui fazer as atividades com a televisão";
                        break;
                    default:
                        break;
                }
                break;

            default:
                break;
        }
    }

    private void UpdateObjects()
    {
        if (mediaCanBeSelected)
        {
            for (int i = 0; i < toyObjects.Length; i++)
            {
                toyObjects[i].GetComponent<EventTrigger>().enabled = false;
                toyObjects[i].GetComponent<OutlineOnHover>().enabled = false;
            }

            for (int i = 0; i < mediaObjects.Length; i++)
            {
                mediaObjects[i].GetComponent<EventTrigger>().enabled = false;
                mediaObjects[i].GetComponent<OutlineOnHover>().enabled = false;
            }
        }
        else
        {
            for (int i = 0; i < toyObjects.Length; i++)
            {
                toyObjects[i].GetComponent<EventTrigger>().enabled = true;
                toyObjects[i].GetComponent<OutlineOnHover>().enabled = true;
            }

            for (int i = 0; i < mediaObjects.Length; i++)
            {
                mediaObjects[i].GetComponent<EventTrigger>().enabled = true;
                mediaObjects[i].GetComponent<OutlineOnHover>().enabled = true;
            }
        }
    }
}
