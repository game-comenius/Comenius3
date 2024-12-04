using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class RoomManager : MonoBehaviour
{
    public GameObject[] toyObjects;
    public GameObject[] mediaObjects;

    [SerializeField] private GameObject toyIcon;
    [SerializeField] private GameObject media1Icon;
    [SerializeField] private GameObject media2Icon;
    [SerializeField] private GameObject intelligenceMiniIcon;
    [SerializeField] private GameObject media1MiniIcon;
    [SerializeField] private GameObject media2MiniIcon;
    [SerializeField] private GameObject toyIconOutline;
    [SerializeField] private GameObject media1IconOutline;
    [SerializeField] private GameObject media2IconOutline;
    [SerializeField] private Image previewMedia;
    [SerializeField] private TextMeshProUGUI objectName;
    [SerializeField] private Text helpText;
    [SerializeField] private GameObject currentMediaHover;
    [SerializeField] private GameObject selectedMediaPopup;
    [SerializeField] private TextMeshProUGUI currentMediaText;
    [SerializeField] private Image currentMediaIcon;
    [SerializeField] private Color correctColor;
    [SerializeField] private Color wrongColor;
    [SerializeField] private GameObject feedbackPopup;
    [SerializeField] private GameObject happyStudent;
    [SerializeField] private GameObject sadStudent;
    [SerializeField] private TextMeshProUGUI toyFeedbackText;
    [SerializeField] private TextMeshProUGUI mediaFeedbackText;

    [Header("Sprites das mídias e brinquedos")]
    [SerializeField] private Sprite consoleSprite;
    [SerializeField] private Sprite computerSprite;
    [SerializeField] private Sprite smartphoneSprite;
    [SerializeField] private Sprite tabletSprite;
    [SerializeField] private Sprite notebookAndCaseSprite;
    [SerializeField] private Sprite tvSprite;
    [SerializeField] private Sprite ballSprite;
    [SerializeField] private Sprite buildingBlocksSprite;
    [SerializeField] private Sprite puzzleSprite;
    [SerializeField] private Sprite comicsAndLiteratureSprite;
    [SerializeField] private Sprite musicBoardSprite;

    [Header("Textos dos briquedos")]
    [SerializeField] private string[] positiveToyFeedbacks;
    [SerializeField] private string[] positiveToyFeedbacksPtbr;
    [SerializeField] private string[] positiveToyFeedbacksEua;
    [SerializeField] private string[] positiveToyFeedbacksEsp;
    [SerializeField] private string[] negativeToyFeedbacks;
    [SerializeField] private string[] negativeToyFeedbacksPtbr;
    [SerializeField] private string[] negativeToyFeedbacksEua;
    [SerializeField] private string[] negativeToyFeedbacksEsp;
    [Header("Textos de ajuda")]
    [SerializeField] [TextArea] private string feedbackHelp;

    private int currentMedia;
    private string tempMedia;
    private string[] medias;
    private Sprite tempSprite;
    private bool mediaShouldBeSelected;

    void Start()
    {
        currentMedia = 0;
        mediaShouldBeSelected = false;
        medias = new string[3];

        toyIcon.SetActive(false);
        media1Icon.SetActive(false);
        media2Icon.SetActive(false);

        switch (Textos.GetIdiomaSelecionado())  
        {
            case Idiomas._chaveInicial:
                break;
            case Idiomas.INGLES:
                currentMediaText.text = $"Choose leisure activity according to multiple intelligence {EstadoDoJogo.Instance.Inteligencias.nome}.";
                break;
            case Idiomas.PORTUGUES:
                currentMediaText.text = $"Escolha a atividade de lazer de acordo com a inteligência múltipla {EstadoDoJogo.Instance.Inteligencias.nome}.";
                break;
            case Idiomas.ESPANHOL:
                currentMediaText.text = $"Elige una actividad de ocio según las inteligencias múltiples {EstadoDoJogo.Instance.Inteligencias.nome}.";
                break;
            case Idiomas._chaveFinal:
                break;
            default:
                currentMediaText.text = $"Escolha a atividade de lazer de acordo com a inteligência múltipla {EstadoDoJogo.Instance.Inteligencias.nome}.";
                break;
        }
        
        currentMediaIcon.sprite = EstadoDoJogo.Instance.Inteligencias.sprite;

        UpdateObjects();
    }

    public void SelectObject(string name)
    {
        switch (name)
        {
            case "Bola":
                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas._chaveInicial:
                        break;
                    case Idiomas.INGLES:tempMedia = "Ball";
                        objectName.text = "Ball";
                        break;
                    case Idiomas.PORTUGUES:
                        tempMedia = "Bola";
                        objectName.text = "Bola";
                        break;
                    case Idiomas.ESPANHOL:
                        tempMedia = "Pelota";
                        objectName.text = "Pelota";
                        break;
                }
                tempSprite = ballSprite;
                previewMedia.sprite = tempSprite;
                break;
            case "Blocos de Montar":
                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas._chaveInicial:
                        break;
                    case Idiomas.INGLES:
                        tempMedia = "Building Blocks";
                        objectName.text = "Building Blocks";
                        break;
                    case Idiomas.PORTUGUES:
                        tempMedia = "Blocos de Montar";
                        objectName.text = "Blocos de Montar";
                        break;
                    case Idiomas.ESPANHOL:
                        tempMedia = "Bloques de construcción";
                        objectName.text = "Bloques de construcción";
                        break;
                }
                tempSprite = buildingBlocksSprite;
                previewMedia.sprite = tempSprite;
                break;
            case "Quebra-Cabeças":
                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas._chaveInicial:
                        break;
                    case Idiomas.INGLES:
                        tempMedia = "Puzzles";
                        objectName.text = "Puzzles";
                        break;
                    case Idiomas.PORTUGUES:
                        tempMedia = "Quebra-Cabeças";
                        objectName.text = "Quebra-Cabeças";
                        break;
                    case Idiomas.ESPANHOL:
                        tempMedia = "Rompecabezas";
                        objectName.text = "Rompecabezas";
                        break;
                }
                tempSprite = puzzleSprite;
                previewMedia.sprite = tempSprite;
                break;
            case "Gibi e Literatura":
                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas._chaveInicial:
                        break;
                    case Idiomas.INGLES:
                        tempMedia = "Comics and Literature";
                        objectName.text = "Comics and Literature";
                        break;
                    case Idiomas.PORTUGUES:
                        tempMedia = "Gibi e Literatura";
                        objectName.text = "Gibi e Literatura";
                        break;
                    case Idiomas.ESPANHOL:
                        tempMedia = "Cómics y literatura";
                        objectName.text = "Cómics y literatura";
                        break;
                }
                tempSprite = comicsAndLiteratureSprite;
                previewMedia.sprite = tempSprite;
                break;
            case "Brinquedo Console":
                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas._chaveInicial:
                        break;
                    case Idiomas.INGLES:
                        tempMedia = "Console toy";
                        objectName.text = "Console toy";
                        break;
                    case Idiomas.PORTUGUES:
                        tempMedia = "Brinquedo Console";
                        objectName.text = "Brinquedo Console";
                        break;
                    case Idiomas.ESPANHOL:
                        tempMedia = "Juguete de consola";
                        objectName.text = "Juguete de consola";
                        break;
                }
                tempSprite = consoleSprite;
                previewMedia.sprite = tempSprite;
                break;
            case "Teclado":
                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas._chaveInicial:
                        break;
                    case Idiomas.INGLES:
                        tempMedia = "Keyboard";
                        objectName.text = "Teclado";
                        break;
                    case Idiomas.PORTUGUES:
                        tempMedia = "Teclado";
                        objectName.text = "Teclado";
                        break;
                    case Idiomas.ESPANHOL:
                        tempMedia = "Teclado";
                        objectName.text = "Teclado";
                        break;
                }
                tempSprite = musicBoardSprite;
                previewMedia.sprite = tempSprite;
                break;
            case "Mídia Console":
                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas._chaveInicial:
                        break;
                    case Idiomas.INGLES:
                        tempMedia = "Media Console";
                        objectName.text = "Media Console";
                        break;
                    case Idiomas.PORTUGUES:
                        tempMedia = "Mídia Console";
                        objectName.text = "Mídia Console";
                        break;
                    case Idiomas.ESPANHOL:
                        tempMedia = "Consola multimedia";
                        objectName.text = "Consola multimedia";
                        break;
                }
                tempSprite = consoleSprite;
                previewMedia.sprite = tempSprite;
                break;
            case "Computador":
                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas._chaveInicial:
                        break;
                    case Idiomas.INGLES:
                        tempMedia = "Computer";
                        objectName.text = "Computer";
                        break;
                    case Idiomas.PORTUGUES:
                        tempMedia = "Computador";
                        objectName.text = "Computador";
                        break;
                    case Idiomas.ESPANHOL:
                        tempMedia = "Computadora";
                        objectName.text = "Computadora";
                        break;
                }
                tempSprite = computerSprite;
                previewMedia.sprite = tempSprite;
                break;
            case "Celular":
                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas._chaveInicial:
                        break;
                    case Idiomas.INGLES:
                        tempMedia = "Cell phone";
                        objectName.text = "Cell phone";
                        break;
                    case Idiomas.PORTUGUES:
                        tempMedia = "Celular";
                        objectName.text = "Celular";
                        break;
                    case Idiomas.ESPANHOL:
                        tempMedia = "Celular";
                        objectName.text = "Celular";
                        break;
                }
                tempSprite = smartphoneSprite;
                previewMedia.sprite = tempSprite;
                break;
            case "Tablet":
                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas._chaveInicial:
                        break;
                    case Idiomas.INGLES:
                        tempMedia = "Tablet";
                        objectName.text = "Tablet";
                        break;
                    case Idiomas.PORTUGUES:
                        tempMedia = "Tablet";
                        objectName.text = "Tablet";
                        break;
                    case Idiomas.ESPANHOL:
                        tempMedia = "Tableta";
                        objectName.text = "Tableta";
                        break;
                }
                tempSprite = tabletSprite;
                previewMedia.sprite = tempSprite;
                break;
            case "Caderno e Estojo":
                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas._chaveInicial:
                        break;
                    case Idiomas.INGLES:
                        tempMedia = "Notebook and Pencil Case";
                        objectName.text = "TabNotebook and Pencil Caselet";
                        break;
                    case Idiomas.PORTUGUES:
                        tempMedia = "Caderno e Estojo";
                        objectName.text = "Caderno e Estojo";
                        break;
                    case Idiomas.ESPANHOL:
                        tempMedia = "Caderno e Estojo";
                        objectName.text = "Caderno e Estojo";
                        break;
                }
                tempSprite = notebookAndCaseSprite;
                previewMedia.sprite = tempSprite;
                break;
            case "Televisão":
                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas._chaveInicial:
                        break;
                    case Idiomas.INGLES:
                        tempMedia = "Television";
                        objectName.text = "Television";
                        break;
                    case Idiomas.PORTUGUES:
                        tempMedia = "Televisão";
                        objectName.text = "Televisão";
                        break;
                    case Idiomas.ESPANHOL:
                        tempMedia = "Televisión";
                        objectName.text = "Televisión";
                        break;
                }
                tempSprite = tvSprite;
                previewMedia.sprite = tempSprite;
                break;
            default:
                break;
        }

        selectedMediaPopup.SetActive(true);
    }

    public void ConfirmSelection()
    {
        switch (tempMedia)
        {
            case "Bola":
            case "Blocos de Montar":
            case "Quebra-Cabeças":
            case "Gibi e Literatura":
            case "Brinquedo Console":
            case "Teclado":
                mediaShouldBeSelected = true;
                break;
            default:
                break;
        }

        UpdateObjects();

        switch (currentMedia)
        {
            case 0:
                toyIcon.GetComponent<Image>().sprite = tempSprite;
                intelligenceMiniIcon.GetComponent<Image>().sprite = EstadoDoJogo.Instance.Inteligencias.sprite;
                toyIcon.SetActive(true);
                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas._chaveInicial:
                        break;
                    case Idiomas.INGLES:
                        currentMediaText.text = $"Choose the object with which the media will be used {EstadoDoJogo.Instance.Midias[0].nome}.";
                        break;
                    case Idiomas.PORTUGUES:
                        currentMediaText.text = $"Escolha o objeto com o qual será utilizado a mídia {EstadoDoJogo.Instance.Midias[0].nome}.";
                        break;
                    case Idiomas.ESPANHOL:
                        currentMediaText.text = $"Elija el objeto con el que se utilizará el soporte.{EstadoDoJogo.Instance.Midias[0].nome}.";
                        break;
                    case Idiomas._chaveFinal:
                        break;
                    default:
                        currentMediaText.text = $"Escolha o objeto com o qual será utilizado a mídia {EstadoDoJogo.Instance.Midias[0].nome}.";
                        break;
                }

                currentMediaIcon.sprite = EstadoDoJogo.Instance.Midias[0].sprite;
                break;
            case 1:
                media1Icon.GetComponent<Image>().sprite = tempSprite;
                media1MiniIcon.GetComponent<Image>().sprite = EstadoDoJogo.Instance.Midias[0].sprite;
                media1Icon.SetActive(true);
                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas._chaveInicial:
                        break;
                    case Idiomas.INGLES:
                        currentMediaText.text = $"Choose the object with which the media will be used {EstadoDoJogo.Instance.Midias[1].nome}.";
                        break;
                    case Idiomas.PORTUGUES:
                        currentMediaText.text = $"Escolha o objeto com o qual será utilizado a mídia {EstadoDoJogo.Instance.Midias[1].nome}.";
                        break;
                    case Idiomas.ESPANHOL:
                        currentMediaText.text = $"Elija el objeto con el que se utilizará el soporte.{EstadoDoJogo.Instance.Midias[1].nome}.";
                        break;
                    case Idiomas._chaveFinal:
                        break;
                    default:
                        currentMediaText.text = $"Escolha o objeto com o qual será utilizado a mídia {EstadoDoJogo.Instance.Midias[1].nome}.";
                        break;
                }
                currentMediaIcon.sprite = EstadoDoJogo.Instance.Midias[1].sprite;
                break;
            default:
                media2Icon.GetComponent<Image>().sprite = tempSprite;
                media2MiniIcon.GetComponent<Image>().sprite = EstadoDoJogo.Instance.Midias[1].sprite;
                media2Icon.SetActive(true);
                break;
        }

        if (currentMedia < 2)
        {
            medias[currentMedia] = tempMedia;
            currentMedia++;
        }
        else
        {
            medias[currentMedia] = tempMedia;

            // Se a maioria das escolhas foi certa, o estudante fica feliz
            float score = 0.0f;

            score += setToyFeedback();     // Retorna 0.0 ou 1.0 pontos
            score += setObjectFeedback();  // Retorna 0.0, 1.0 ou 2.0 pontos

            if (score > 1.5f)
            {
                happyStudent.SetActive(true);
                sadStudent.SetActive(false);
            }
            else
            {
                happyStudent.SetActive(false);
                sadStudent.SetActive(true);
            }

            helpText.text = feedbackHelp;
            feedbackPopup.SetActive(true);
            currentMediaHover.SetActive(false);
        }
    }

    public void reset()
    {
        currentMedia = 0;
        medias = new string[3];
        Start();
    }

    private float setToyFeedback()
    {
        var estadoDoJogo = EstadoDoJogo.Instance;
        string intelligenceName = estadoDoJogo.Inteligencias.nome;

        string positivePrefix = Textos.GetInstance().ObterTexto(ChaveTextos.POSITIVE_PRE_FIX);
        string negativePrefix = Textos.GetInstance().ObterTexto(ChaveTextos.NEGATIVE_PRE_FIX);



        int index;
        bool selectionIsPositive;

        toyIconOutline.SetActive(true);
        toyIconOutline.GetComponent<Image>().color = correctColor;
        toyIconOutline.transform.GetChild(0).GetComponent<Image>().color = correctColor;

        media1IconOutline.SetActive(true);
        media1IconOutline.GetComponent<Image>().color = wrongColor;
        media1IconOutline.transform.GetChild(0).GetComponent<Image>().color = wrongColor;

        media2IconOutline.SetActive(true);
        media2IconOutline.GetComponent<Image>().color = wrongColor;
        media2IconOutline.transform.GetChild(0).GetComponent<Image>().color = wrongColor;

        switch (intelligenceName)
        {
            case ("Corporal-cinestésica e Naturalista"):
                switch (medias[0])
                {
                    case "Bola":
                        index = 0;
                        selectionIsPositive = true;
                        break;
                    case "Blocos de Montar":
                        index = 1;
                        selectionIsPositive = true;
                        break;
                    case "Quebra-Cabeças":
                        index = 2;
                        selectionIsPositive = false;
                        break;
                    case "Gibi e Literatura":
                        index = 3;
                        selectionIsPositive = false;
                        break;
                    case "Brinquedo Console":
                        index = 4;
                        selectionIsPositive = false;
                        break;
                    case "Teclado":
                        index = 5;
                        selectionIsPositive = true;
                        break;
                    default:
                        index = 0;
                        selectionIsPositive = false;
                        break;
                }
                break;
            case ("Intrapessoal e Espacial-visual"):
                switch (medias[0])
                {
                    case "Bola":
                        index = 0;
                        selectionIsPositive = false;
                        break;
                    case "Blocos de Montar":
                        index = 1;
                        selectionIsPositive = true;
                        break;
                    case "Quebra-Cabeças":
                        index = 2;
                        selectionIsPositive = true;
                        break;
                    case "Gibi e Literatura":
                        index = 3;
                        selectionIsPositive = true;
                        break;
                    case "Brinquedo Console":
                        index = 4;
                        selectionIsPositive = true;
                        break;
                    case "Teclado":
                        index = 5;
                        selectionIsPositive = false;
                        break;
                    default:
                        index = 0;
                        selectionIsPositive = false;
                        break;
                }
                break;
            case ("Linguística e Lógico-matemática"):
                switch (medias[0])
                {
                    case "Bola":
                        index = 0;
                        selectionIsPositive = false;
                        break;
                    case "Blocos de Montar":
                        index = 1;
                        selectionIsPositive = true;
                        break;
                    case "Quebra-Cabeças":
                        index = 2;
                        selectionIsPositive = true;
                        break;
                    case "Gibi e Literatura":
                        index = 3;
                        selectionIsPositive = true;
                        break;
                    case "Brinquedo Console":
                        index = 4;
                        selectionIsPositive = false;
                        break;
                    case "Teclado":
                        index = 5;
                        selectionIsPositive = false;
                        break;
                    default:
                        index = 0;
                        selectionIsPositive = false;
                        break;
                }
                break;
            case ("Interpessoal e Musical"):
                switch (medias[0])
                {
                    case "Bola":
                        index = 0;
                        selectionIsPositive = true;
                        break;
                    case "Blocos de Montar":
                        index = 1;
                        selectionIsPositive = false;
                        break;
                    case "Quebra-Cabeças":
                        index = 2;
                        selectionIsPositive = false;
                        break;
                    case "Gibi e Literatura":
                        index = 3;
                        selectionIsPositive = false;
                        break;
                    case "Brinquedo Console":
                        index = 4;
                        selectionIsPositive = true;
                        break;
                    case "Teclado":
                        index = 5;
                        selectionIsPositive = true;
                        break;
                    default:
                        index = 0;
                        selectionIsPositive = false;
                        break;
                }
                break;
            default:
                index = 0;
                selectionIsPositive = false;
                break;
        }

        toyIconOutline.SetActive(true);

        if (selectionIsPositive)
        {
            switch (Textos.GetIdiomaSelecionado())
            {
                case Idiomas._chaveInicial:
                    break;
                case Idiomas.INGLES:
                    toyFeedbackText.text = $"{positivePrefix} {positiveToyFeedbacksEua[index]}";
                    break;
                case Idiomas.PORTUGUES:
                    toyFeedbackText.text = $"{positivePrefix} {positiveToyFeedbacksPtbr[index]}";
                    break;
                case Idiomas.ESPANHOL:
                    toyFeedbackText.text = $"{positivePrefix} {positiveToyFeedbacksEsp[index]}";
                    break;
                case Idiomas._chaveFinal:
                    break;
                default:
                    toyFeedbackText.text = $"{positivePrefix} {positiveToyFeedbacks[index]}";
                    break;  
            }
     
            toyIconOutline.GetComponent<Image>().color = correctColor;
            toyIconOutline.transform.GetChild(0).GetComponent<Image>().color = correctColor;
            return 1.0f;
        }
        else
        {
            switch (Textos.GetIdiomaSelecionado())
            {
                case Idiomas._chaveInicial:
                    break;
                case Idiomas.INGLES:
                    toyFeedbackText.text = $"<color=red>{negativePrefix} {negativeToyFeedbacksEua[index]}";
                    break;
                case Idiomas.PORTUGUES:
                    toyFeedbackText.text = $"<color=red>{negativePrefix} {negativeToyFeedbacksPtbr[index]}";
                    break;
                case Idiomas.ESPANHOL:
                    toyFeedbackText.text = $"<color=red>{negativePrefix} {negativeToyFeedbacksEsp[index]}";
                    break;
                case Idiomas._chaveFinal:
                    break;
                default:
                    toyFeedbackText.text = $"<color=red>{negativePrefix} {negativeToyFeedbacks[index]}";
                    break;
            }
      
            toyIconOutline.GetComponent<Image>().color = wrongColor;
            toyIconOutline.transform.GetChild(0).GetComponent<Image>().color = wrongColor;
            return 0.0f;
        }

    }
    private string TextoCorretoTansos(int value)
    {
        switch (value)
        {
            case 0:
                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas.INGLES:
                        return  "The console";
                    case Idiomas.PORTUGUES:
                        return  "O console";
                    case Idiomas.ESPANHOL:
                        return "La consola";
                }
                break;
            case 1:
                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas.INGLES:
                        return "The PC";
                    case Idiomas.PORTUGUES:
                        return "O Computador";
                    case Idiomas.ESPANHOL:
                        return "La computadora";
                }
                break;
            case 2:
                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas.INGLES:
                        return "Cell phone";
                    case Idiomas.PORTUGUES:
                        return "Celular";
                    case Idiomas.ESPANHOL:
                        return "Teléfono móvil";
                }
                break;
            case 3:
                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas.INGLES:
                        return "Tablet";
                    case Idiomas.PORTUGUES:
                        return "Tablet";
                    case Idiomas.ESPANHOL:
                        return "Tableta";
                }
                break;
            case 4:
                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas.INGLES:
                        return "Notebook and Case";
                    case Idiomas.PORTUGUES:
                        return "Caderno e Estojo";
                    case Idiomas.ESPANHOL:
                        return "Cuaderno y estuche";
                }
                break;
            case 5:
                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas.INGLES:
                        return "Television";
                    case Idiomas.PORTUGUES:
                        return "Televisão";
                    case Idiomas.ESPANHOL:
                        return "Televisión";
                }
                break;

            default:
                return "Null";
        }
        return "Null";
    }

    private float setObjectFeedback()
    {
        var estadoDoJogo = EstadoDoJogo.Instance;

        bool[] selectionIsPositive = new bool[2];
        string[] adjustedString = new string[2];

        for (int i = 0; i < 2; i++)
        {
            string mediaName = estadoDoJogo.Midias[i].nome;
          //  Midia.AtualizarTextosLinguas(NomeDeMidia., 2);
            switch (medias[i + 1])
            {
                case "Mídia Console":
                    adjustedString[i] = TextoCorretoTansos(0);
                    break;
                case "Computador":
                    adjustedString[i] = TextoCorretoTansos(1);
                    break;
                case "Celular":
                    adjustedString[i] = TextoCorretoTansos(2);
                    break;
                case "Tablet":
                    adjustedString[i] = TextoCorretoTansos(3);
                    break;
                case "Caderno e Estojo":
                    adjustedString[i] = TextoCorretoTansos(4);
                    break;
                case "Televisão":
                    adjustedString[i] = TextoCorretoTansos(5);
                    break;
            }

            switch (mediaName)
            {
                case "Jogos":

                    switch (medias[i + 1])
                    {
                        case "Mídia Console":
                            selectionIsPositive[i] = true;
                            break;
                        case "Computador":
                            selectionIsPositive[i] = true;
                            break;
                        case "Celular":
                            selectionIsPositive[i] = true;
                            break;
                        case "Tablet":
                            selectionIsPositive[i] = true;
                            break;
                        case "Caderno e Estojo":
                            selectionIsPositive[i] = false;
                            break;
                        case "Televisão":
                            selectionIsPositive[i] = false;
                            break;
                    }
                    break;
                case "Redes Sociais":

                    switch (medias[i + 1])
                    {
                        case "Mídia Console":
                            selectionIsPositive[i] = false;
                            break;
                        case "Computador":
                            selectionIsPositive[i] = true;
                            break;
                        case "Celular":
                            selectionIsPositive[i] = true;
                            break;
                        case "Tablet":
                            selectionIsPositive[i] = true;
                            break;
                        case "Caderno e Estojo":
                            selectionIsPositive[i] = false;
                            break;
                        case "Televisão":
                            selectionIsPositive[i] = false;
                            break;
                    }
                    break;
                case "Editores de Áudio e Vídeo":

                    switch (medias[i + 1])
                    {
                        case "Mídia Console":
                            selectionIsPositive[i] = false;
                            break;
                        case "Computador":
                            selectionIsPositive[i] = true;
                            break;
                        case "Celular":
                            selectionIsPositive[i] = true;
                            break;
                        case "Tablet":
                            selectionIsPositive[i] = true;
                            break;
                        case "Caderno e Estojo":
                            selectionIsPositive[i] = false;
                            break;
                        case "Televisão":
                            selectionIsPositive[i] = false;
                            break;
                    }
                    break;
                case "Plataformas":

                    switch (medias[i + 1])
                    {
                        case "Mídia Console":
                            selectionIsPositive[i] = false;
                            break;
                        case "Computador":
                            selectionIsPositive[i] = true;
                            break;
                        case "Celular":
                            selectionIsPositive[i] = true;
                            break;
                        case "Tablet":
                            selectionIsPositive[i] = true;
                            break;
                        case "Caderno e Estojo":
                            selectionIsPositive[i] = false;
                            break;
                        case "Televisão":
                            selectionIsPositive[i] = false;
                            break;
                    }
                    break;
                case "Aplicativos":

                    switch (medias[i + 1])
                    {
                        case "Mídia Console":
                            selectionIsPositive[i] = false;
                            break;
                        case "Computador":
                            selectionIsPositive[i] = true;
                            break;
                        case "Celular":
                            selectionIsPositive[i] = true;
                            break;
                        case "Tablet":
                            selectionIsPositive[i] = true;
                            break;
                        case "Caderno e Estojo":
                            selectionIsPositive[i] = false;
                            break;
                        case "Televisão":
                            selectionIsPositive[i] = false;
                            break;
                    }
                    break;
                case "Editores de Texto e Planilhas Eletrônicas":

                    switch (medias[i + 1])
                    {
                        case "Mídia Console":
                            selectionIsPositive[i] = false;
                            break;
                        case "Computador":
                            selectionIsPositive[i] = true;
                            break;
                        case "Celular":
                            selectionIsPositive[i] = false;
                            break;
                        case "Tablet":
                            selectionIsPositive[i] = true;
                            break;
                        case "Caderno e Estojo":
                            selectionIsPositive[i] = false;
                            break;
                        case "Televisão":
                            selectionIsPositive[i] = false;
                            break;
                    }
                    break;
                case "Cadernos e Cartazes":

                    switch (medias[i + 1])
                    {
                        case "Mídia Console":
                            selectionIsPositive[i] = false;
                            break;
                        case "Computador":
                            selectionIsPositive[i] = false;
                            break;
                        case "Celular":
                            selectionIsPositive[i] = false;
                            break;
                        case "Tablet":
                            selectionIsPositive[i] = false;
                            break;
                        case "Caderno e Estojo":
                            selectionIsPositive[i] = true;
                            break;
                        case "Televisão":
                            selectionIsPositive[i] = false;
                            break;
                    }
                    break;
                case "Televisão":

                    switch (medias[i + 1])
                    {
                        case "Mídia Console":
                            selectionIsPositive[i] = false;
                            break;
                        case "Computador":
                            selectionIsPositive[i] = false;
                            break;
                        case "Celular":
                            selectionIsPositive[i] = false;
                            break;
                        case "Tablet":
                            selectionIsPositive[i] = false;
                            break;
                        case "Caderno e Estojo":
                            selectionIsPositive[i] = false;
                            break;
                        case "Televisão":
                            selectionIsPositive[i] = true;
                            break;
                    }
                    break;
                default:
                    selectionIsPositive[i] = false;
                    break;
            }
        }

        media1IconOutline.SetActive(true);
        media2IconOutline.SetActive(true);

        if (selectionIsPositive[0] && selectionIsPositive[1])
        {
            mediaFeedbackText.text = Textos.GetInstance().ObterTexto(ChaveTextos.CONSEGUI_FAZER_AS_ATIVIDADES) + $" {adjustedString[0]}" + Textos.GetInstance().ObterTexto(ChaveTextos.E) + $"{adjustedString[1]}";

            media1IconOutline.GetComponent<Image>().color = correctColor;
            media1IconOutline.transform.GetChild(0).GetComponent<Image>().color = correctColor;

            media2IconOutline.GetComponent<Image>().color = correctColor;
            media2IconOutline.transform.GetChild(0).GetComponent<Image>().color = correctColor;

            return 2.0f;
        }
        else if (selectionIsPositive[0])
        {
            mediaFeedbackText.text = Textos.GetInstance().ObterTexto(ChaveTextos.CONSEGUI_FAZER_AS_ATIVIDADES) +
                $" {adjustedString[0]}" + Textos.GetInstance().ObterTexto(ChaveTextos.CONSEGUI_FAZER_AS_ATIVIDADES) + $" {adjustedString[1]}";

            media1IconOutline.GetComponent<Image>().color = correctColor;
            media1IconOutline.transform.GetChild(0).GetComponent<Image>().color = correctColor;

            media2IconOutline.GetComponent<Image>().color = wrongColor;
            media2IconOutline.transform.GetChild(0).GetComponent<Image>().color = wrongColor;

            return 1.0f;
        }
        else if (selectionIsPositive[1])
        {
            mediaFeedbackText.text = Textos.GetInstance().ObterTexto(ChaveTextos.CONSEGUI_FAZER_AS_ATIVIDADES) +
                $" {adjustedString[1]}" + Textos.GetInstance().ObterTexto(ChaveTextos.CONSEGUI_FAZER_AS_ATIVIDADES) +$" { adjustedString[0]}";

            media1IconOutline.GetComponent<Image>().color = wrongColor;
            media1IconOutline.transform.GetChild(0).GetComponent<Image>().color = wrongColor;

            media2IconOutline.GetComponent<Image>().color = correctColor;
            media2IconOutline.transform.GetChild(0).GetComponent<Image>().color = correctColor;

            return 1.0f;
            
        }
        else
        {
        
            mediaFeedbackText.text = Textos.GetInstance().ObterTexto(ChaveTextos.TIVE_DIFICULDADE_PARA_FAZER_AS_TAREFAS) +
                $"{adjustedString[0]}" +Textos.GetInstance().ObterTexto(ChaveTextos.E) + $" {adjustedString[1]}";

            media1IconOutline.GetComponent<Image>().color = wrongColor;
            media1IconOutline.transform.GetChild(0).GetComponent<Image>().color = wrongColor;

            media2IconOutline.GetComponent<Image>().color = wrongColor;
            media2IconOutline.transform.GetChild(0).GetComponent<Image>().color = wrongColor;

            return 0.0f;
        }
    }

    private void UpdateObjects()
    {
        if (mediaShouldBeSelected)
        {
            for (int i = 0; i < toyObjects.Length; i++)
            {
                toyObjects[i].GetComponent<PolygonCollider2D>().enabled = false;
            }

            for (int i = 0; i < mediaObjects.Length; i++)
            {
                mediaObjects[i].GetComponent<PolygonCollider2D>().enabled = true;
            }
        }
        else
        {
            for (int i = 0; i < toyObjects.Length; i++)
            {
                toyObjects[i].GetComponent<PolygonCollider2D>().enabled = true;
            }

            for (int i = 0; i < mediaObjects.Length; i++)
            {
                mediaObjects[i].GetComponent<PolygonCollider2D>().enabled = false;
            }
        }
    }
}
