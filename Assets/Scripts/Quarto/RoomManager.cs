using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

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
    [SerializeField] private string[] negativeToyFeedbacks;
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

        currentMediaText.text = $"Escolha a atividade de lazer de acordo com a inteligência múltipla {EstadoDoJogo.Instance.Inteligencias.nome}.";
        currentMediaIcon.sprite = EstadoDoJogo.Instance.Inteligencias.sprite;

        UpdateObjects();
    }

    public void SelectObject(string name)
    {
        switch (name)
        {
            case "Bola":
                tempMedia = name;
                tempSprite = ballSprite;
                objectName.text = name;
                previewMedia.sprite = tempSprite;
                break;
            case "Blocos de Montar":
                tempMedia = name;
                tempSprite = buildingBlocksSprite;
                objectName.text = name;
                previewMedia.sprite = tempSprite;
                break;
            case "Quebra-Cabeças":
                tempMedia = name;
                tempSprite = puzzleSprite;
                objectName.text = name;
                previewMedia.sprite = tempSprite;
                break;
            case "Gibi e Literatura":
                tempMedia = name;
                tempSprite = comicsAndLiteratureSprite;
                objectName.text = name;
                previewMedia.sprite = tempSprite;
                break;
            case "Brinquedo Console":
                tempMedia = name;
                tempSprite = consoleSprite;
                objectName.text = "Console";
                previewMedia.sprite = tempSprite;
                break;
            case "Teclado":
                tempMedia = name;
                tempSprite = musicBoardSprite;
                objectName.text = name;
                previewMedia.sprite = tempSprite;
                break;
            case "Mídia Console":
                tempMedia = name;
                tempSprite = consoleSprite;
                objectName.text = "Console";
                previewMedia.sprite = tempSprite;
                break;
            case "Computador":
                tempMedia = name;
                tempSprite = computerSprite;
                objectName.text = name;
                previewMedia.sprite = tempSprite;
                break;
            case "Celular":
                tempMedia = name;
                tempSprite = smartphoneSprite;
                objectName.text = name;
                previewMedia.sprite = tempSprite;
                break;
            case "Tablet":
                tempMedia = name;
                tempSprite = tabletSprite;
                objectName.text = name;
                previewMedia.sprite = tempSprite;
                break;
            case "Caderno e Estojo":
                tempMedia = name;
                tempSprite = notebookAndCaseSprite;
                objectName.text = name;
                previewMedia.sprite = tempSprite;
                break;
            case "Televisão":
                tempMedia = name;
                tempSprite = tvSprite;
                objectName.text = name;
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
                currentMediaText.text = $"Escolha o objeto com o qual será utilizado a mídia {EstadoDoJogo.Instance.Midias[0].nome}.";
                currentMediaIcon.sprite = EstadoDoJogo.Instance.Midias[0].sprite;
                break;
            case 1:
                media1Icon.GetComponent<Image>().sprite = tempSprite;
                media1MiniIcon.GetComponent<Image>().sprite = EstadoDoJogo.Instance.Midias[0].sprite;
                media1Icon.SetActive(true);
                currentMediaText.text = $"Escolha o objeto com o qual será utilizado a mídia {EstadoDoJogo.Instance.Midias[1].nome}.";
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

        string positivePrefix = "Me diverti muito";
        string negativePrefix = "Não me diverti muito, pra mim";

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
            toyFeedbackText.text = $"{positivePrefix} {positiveToyFeedbacks[index]}";
            toyIconOutline.GetComponent<Image>().color = correctColor;
            toyIconOutline.transform.GetChild(0).GetComponent<Image>().color = correctColor;
            return 1.0f;
        }
        else
        {
            toyFeedbackText.text = $"<color=red>{negativePrefix} {negativeToyFeedbacks[index]}";
            toyIconOutline.GetComponent<Image>().color = wrongColor;
            toyIconOutline.transform.GetChild(0).GetComponent<Image>().color = wrongColor;
            return 0.0f;
        }

    }

    private float setObjectFeedback()
    {
        var estadoDoJogo = EstadoDoJogo.Instance;

        bool[] selectionIsPositive = new bool[2];
        string[] adjustedString = new string[2];

        for (int i = 0; i < 2; i++)
        {
            string mediaName = estadoDoJogo.Midias[i].nome;

            switch (medias[i + 1])
            {
                case "Mídia Console":
                    adjustedString[i] = "o console";
                    break;
                case "Computador":
                    adjustedString[i] = "o computador";
                    break;
                case "Celular":
                    adjustedString[i] = "o celular";
                    break;
                case "Tablet":
                    adjustedString[i] = "o tablet";
                    break;
                case "Caderno e Estojo":
                    adjustedString[i] = "o caderno e estojo";
                    break;
                case "Televisão":
                    adjustedString[i] = "a televisão";
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
            mediaFeedbackText.text = $"Consegui fazer todas as tarefas com {adjustedString[0]} e {adjustedString[1]}";

            media1IconOutline.GetComponent<Image>().color = correctColor;
            media1IconOutline.transform.GetChild(0).GetComponent<Image>().color = correctColor;

            media2IconOutline.GetComponent<Image>().color = correctColor;
            media2IconOutline.transform.GetChild(0).GetComponent<Image>().color = correctColor;

            return 2.0f;
        }
        else if (selectionIsPositive[0])
        {
            mediaFeedbackText.text = $" Consegui fazer as atividades com {adjustedString[0]} <color=red>mas tive dificuldades para fazer outras tarefas com {adjustedString[1]}";

            media1IconOutline.GetComponent<Image>().color = correctColor;
            media1IconOutline.transform.GetChild(0).GetComponent<Image>().color = correctColor;

            media2IconOutline.GetComponent<Image>().color = wrongColor;
            media2IconOutline.transform.GetChild(0).GetComponent<Image>().color = wrongColor;

            return 1.0f;
        }
        else if (selectionIsPositive[1])
        {
            mediaFeedbackText.text = $" Consegui fazer as atividades com {adjustedString[1]} <color=red>mas tive dificuldades para fazer outras tarefas com {adjustedString[0]}";

            media1IconOutline.GetComponent<Image>().color = wrongColor;
            media1IconOutline.transform.GetChild(0).GetComponent<Image>().color = wrongColor;

            media2IconOutline.GetComponent<Image>().color = correctColor;
            media2IconOutline.transform.GetChild(0).GetComponent<Image>().color = correctColor;

            return 1.0f;
        }
        else
        {
            mediaFeedbackText.text = $"<color=red>Tive dificuldades para fazer as tarefas com {adjustedString[0]} e {adjustedString[1]}";

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
