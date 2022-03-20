using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

[System.Obsolete("Vai ser refeito")]
public class ControladorMidiasEscolhidas : MonoBehaviour
{
    [SerializeField] GameObject midia0;
    [SerializeField] GameObject midia1;
    [SerializeField] GameObject midia2;

    [SerializeField] GameObject miniMidia0;
    [SerializeField] GameObject miniMidia1;
    [SerializeField] GameObject miniMidia2;

    [SerializeField] GameObject previewMidia;

    [SerializeField] GameObject popUpTipo;
    [SerializeField] GameObject popUpNome;

    [SerializeField] GameObject painelFeedback;

    [SerializeField] GameObject quartoInfo;

    [SerializeField] GameObject textoMidiaAtualObjeto;
    [SerializeField] TextMeshProUGUI textoMidiaAtual;

    [SerializeField] TextMeshProUGUI textoFeedbackBrinquedo;
    [SerializeField] TextMeshProUGUI textoFeedbackObjeto1;
    [SerializeField] TextMeshProUGUI textoFeedbackObjeto2;

    [Header("Imagens das mídias e brinquedos")]
    [SerializeField] Sprite estanteSprite;
    [SerializeField] Sprite televisaoSprite;
    [SerializeField] Sprite tabletSprite;
    [SerializeField] Sprite consoleSprite;
    [SerializeField] Sprite computadorSprite;
    [SerializeField] Sprite celularSprite;
    [SerializeField] Sprite legosSprite;
    [SerializeField] Sprite quebraCabecaSprite;
    [SerializeField] Sprite ioioSprite;
    [SerializeField] Sprite blocosSprite;
    [SerializeField] Sprite tecladoSprite;
    [SerializeField] Sprite bolaSprite;

    private int midiaAtual = 0;
    private string midiaProvisoria;
    private string[] midiasDefinitivas = new string[3];
    private Sprite spriteProvisorio;
    private TextMeshProUGUI[] textosFeedback = new TextMeshProUGUI[3];

    // Start is called before the first frame update
    void Start()
    {
        //var midia = Midia.Instance;
        midia0.SetActive(false);
        midia1.SetActive(false);
        midia2.SetActive(false);

        textosFeedback[0] = textoFeedbackBrinquedo;
        textosFeedback[1] = textoFeedbackObjeto1;
        textosFeedback[2] = textoFeedbackObjeto2;

        textoMidiaAtual.text = $"Escolha a atividade de lazer de acordo com a inteligência múltipla {EstadoDoJogo.Instance.Inteligencias.nome}.";

    }

    public void onClickProvisorio(string midia)
    {
        switch (midia)
        {
            case "estante":
                midiaProvisoria = midia;
                spriteProvisorio = estanteSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Mídia";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Livros";
                previewMidia.GetComponent<Image>().sprite = spriteProvisorio;
                Debug.Log(midia);
                break;
            case "televisao":
                midiaProvisoria = midia;
                spriteProvisorio = televisaoSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Mídia";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Televisão";
                previewMidia.GetComponent<Image>().sprite = spriteProvisorio;
                Debug.Log(midia);
                break;
            case "tablet":
                midiaProvisoria = midia;
                spriteProvisorio = tabletSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Mídia";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Tablet";
                previewMidia.GetComponent<Image>().sprite = spriteProvisorio;
                Debug.Log(midia);
                break;
            case "console":
                midiaProvisoria = midia;
                spriteProvisorio = consoleSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Mídia";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Jogos";
                previewMidia.GetComponent<Image>().sprite = spriteProvisorio;
                Debug.Log(midia);
                break;
            case "computador":
                midiaProvisoria = midia;
                spriteProvisorio = computadorSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Mídia";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Computador";
                previewMidia.GetComponent<Image>().sprite = spriteProvisorio;
                previewMidia.GetComponent<Image>().sprite = spriteProvisorio;
                Debug.Log(midia);
                break;
            case "celular":
                midiaProvisoria = midia;
                spriteProvisorio = celularSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Mídia";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Celular";
                previewMidia.GetComponent<Image>().sprite = spriteProvisorio;
                Debug.Log(midia);
                break;
            case "legos":
                midiaProvisoria = midia;
                spriteProvisorio = legosSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Atividade de Lazer";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Legos";
                previewMidia.GetComponent<Image>().sprite = spriteProvisorio;
                Debug.Log(midia);
                break;
            case "quebra cabeca":
                midiaProvisoria = midia;
                spriteProvisorio = quebraCabecaSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Atividade de Lazer";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Quebra-cabeça";
                previewMidia.GetComponent<Image>().sprite = spriteProvisorio;
                Debug.Log(midia);
                break;
            case "io io":
                midiaProvisoria = midia;
                spriteProvisorio = ioioSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Atividade de Lazer";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Ioiô";
                previewMidia.GetComponent<Image>().sprite = spriteProvisorio;
                Debug.Log(midia);
                break;
            case "blocos":
                midiaProvisoria = midia;
                spriteProvisorio = blocosSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Atividade de Lazer";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Blocos";
                previewMidia.GetComponent<Image>().sprite = spriteProvisorio;
                Debug.Log(midia);
                break;
            case "teclado":
                midiaProvisoria = midia;
                spriteProvisorio = tecladoSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Atividade de Lazer";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Teclado";
                previewMidia.GetComponent<Image>().sprite = spriteProvisorio;
                Debug.Log(midia);
                break;
            case "bola":
                midiaProvisoria = midia;
                spriteProvisorio = bolaSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Atividade de Lazer";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Bola";
                previewMidia.GetComponent<Image>().sprite = spriteProvisorio;
                Debug.Log(midia);
                break;
            default:
                break;
        }
    }

    public void onClickDefinitivo()
    {
        switch (midiaAtual)
        {
            case 0:
                midia0.GetComponent<SpriteRenderer>().sprite = spriteProvisorio;
                miniMidia0.GetComponent<SpriteRenderer>().sprite = EstadoDoJogo.Instance.Inteligencias.sprite;
                midia0.SetActive(true);
                textoMidiaAtual.text = $"Escolha o objeto que com o qual será utilizado a mídia {EstadoDoJogo.Instance.Midias[0].nome}.";
                break;
            case 1:
                midia1.GetComponent<SpriteRenderer>().sprite = spriteProvisorio;
                miniMidia1.GetComponent<SpriteRenderer>().sprite = EstadoDoJogo.Instance.Midias[0].sprite;
                midia1.SetActive(true);
                textoMidiaAtual.text = $"Escolha o objeto que com o qual será utilizado a mídia {EstadoDoJogo.Instance.Midias[1].nome}.";
                break;
            default:
                midia2.GetComponent<SpriteRenderer>().sprite = spriteProvisorio;
                miniMidia2.GetComponent<SpriteRenderer>().sprite = EstadoDoJogo.Instance.Midias[1].sprite;
                midia2.SetActive(true);
                break;
        }

        if (midiaAtual < 2)
        {
            midiasDefinitivas[midiaAtual] = midiaProvisoria;
            Debug.Log(midiaAtual);
            midiaAtual++;
            Debug.Log(midiaAtual);
        }
        else
        {
            midiasDefinitivas[midiaAtual] = midiaProvisoria;
            Debug.Log(midiaAtual);
            setToyFeedback();
            setObjectFeedback(0);
            setObjectFeedback(1);
            painelFeedback.SetActive(true);
            textoMidiaAtualObjeto.SetActive(false);
            quartoInfo.SetActive(false);
            Debug.Log(midiasDefinitivas[0] + " " + midiasDefinitivas[1] + " " + midiasDefinitivas[2]);
        }


    }

    public void setToyFeedback()
    {
        var estadoDoJogo = EstadoDoJogo.Instance;
        string nomeInteligencia = estadoDoJogo.Inteligencias.nome;

        switch (nomeInteligencia)
        {

            case ("Corporal-cinestésica e Naturalista"):
                switch (midiasDefinitivas[0])
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
                switch (midiasDefinitivas[0])
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
                switch (midiasDefinitivas[0])
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
                switch (midiasDefinitivas[0])
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
        
        switch(nomeMidia)
        {
            case ("Jogos"):
                switch(midiasDefinitivas[index + 1])
                {
                    case ("console"):
                        textosFeedback[index + 1].text = index == 0 ? "Consegui fazer as atividades com o console" : "e consegui fazer as atividades com o console";
                        break;
                    case ("computador"):
                        textosFeedback[index + 1].text = index == 0 ? "Consegui fazer as atividades com o computador" : "e consegui fazer as atividades com o computador";
                        break;
                    case ("celular"):
                        textosFeedback[index + 1].text = index == 0 ? "Consegui fazer as atividades com o celular" : "e consegui fazer as atividades com o celular";
                        break;
                    case ("tablet"):
                        textosFeedback[index + 1].text = index == 0 ? "Consegui fazer as atividades com o tablet" : "e consegui fazer as atividades com o tablet";
                        break;
                    case ("estante"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o livro" : $"<color=red>e não consegui fazer as atividades com o livro";
                        break;
                    case ("televisao"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com a televisão" : $"<color=red>e não consegui fazer as atividades com a televisão";
                        break;
                    default:
                        break;
                }
                break;

            case ("Redes Sociais"):
                switch (midiasDefinitivas[index + 1])
                {
                    case ("console"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o console" : $"<color=red>e não consegui fazer as atividades com o console";
                        break;
                    case ("computador"):
                        textosFeedback[index + 1].text = index == 0 ? "Consegui fazer as atividades com o computador" : "e consegui fazer as atividades com o computador";
                        break;
                    case ("celular"):
                        textosFeedback[index + 1].text = index == 0 ? "Consegui fazer as atividades com o celular" : "e consegui fazer as atividades com o celular";
                        break;
                    case ("tablet"):
                        textosFeedback[index + 1].text = index == 0 ? "Consegui fazer as atividades com o tablet" : "e consegui fazer as atividades com o tablet";
                        break;
                    case ("estante"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o livro" : $"<color=red>e não consegui fazer as atividades com o livro";
                        break;
                    case ("televisao"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com a televisão" : $"<color=red>e não consegui fazer as atividades com a televisão";
                        break;
                    default:
                        break;
                }
                break;

            case ("Editores de Áudio e Vídeo"):
                switch (midiasDefinitivas[index + 1])
                {
                    case ("console"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o console" : $"<color=red>e não consegui fazer as atividades com o console";
                        break;
                    case ("computador"):
                        textosFeedback[index + 1].text = index == 0 ? "Consegui fazer as atividades com o computador" : "e consegui fazer as atividades com o computador";
                        break;
                    case ("celular"):
                        textosFeedback[index + 1].text = index == 0 ? "Consegui fazer as atividades com o celular" : "e consegui fazer as atividades com o celular";
                        break;
                    case ("tablet"):
                        textosFeedback[index + 1].text = index == 0 ? "Consegui fazer as atividades com o tablet" : "e consegui fazer as atividades com o tablet";
                        break;
                    case ("estante"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o livro" : $"<color=red>e não consegui fazer as atividades com o livro";
                        break;
                    case ("televisao"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com a televisão" : $"<color=red>e não consegui fazer as atividades com a televisão";
                        break;
                    default:
                        break;
                }
                break;

            case ("Plataformas"):
                switch (midiasDefinitivas[index + 1])
                {
                    case ("console"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o console" : $"<color=red>e não consegui fazer as atividades com o console";
                        break;
                    case ("computador"):
                        textosFeedback[index + 1].text = index == 0 ? "Consegui fazer as atividades com o computador" : "e consegui fazer as atividades com o computador";
                        break;
                    case ("celular"):
                        textosFeedback[index + 1].text = index == 0 ? "Consegui fazer as atividades com o celular" : "e consegui fazer as atividades com o celular";
                        break;
                    case ("tablet"):
                        textosFeedback[index + 1].text = index == 0 ? "Consegui fazer as atividades com o tablet" : "e consegui fazer as atividades com o tablet";
                        break;
                    case ("estante"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o livro" : $"<color=red>e não consegui fazer as atividades com o livro";
                        break;
                    case ("televisao"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com a televisão" : $"<color=red>e não consegui fazer as atividades com a televisão";
                        break;
                    default:
                        break;
                }
                break;

            case ("Aplicativos"):
                switch (midiasDefinitivas[index + 1])
                {
                    case ("console"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o console" : $"<color=red>e não consegui fazer as atividades com o console";
                        break;
                    case ("computador"):
                        textosFeedback[index + 1].text = index == 0 ? "Consegui fazer as atividades com o computador" : "e consegui fazer as atividades com o computador";
                        break;
                    case ("celular"):
                        textosFeedback[index + 1].text = index == 0 ? "Consegui fazer as atividades com o celular" : "e consegui fazer as atividades com o celular";
                        break;
                    case ("tablet"):
                        textosFeedback[index + 1].text = index == 0 ? "Consegui fazer as atividades com o tablet" : "e consegui fazer as atividades com o tablet";
                        break;
                    case ("estante"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o livro" : $"<color=red>e não consegui fazer as atividades com o livro";
                        break;
                    case ("televisao"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com a televisão" : $"<color=red>e não consegui fazer as atividades com a televisão";
                        break;
                    default:
                        break;
                }
                break;

            case ("Editores de Texto e Planilhas Eletrônicas"):
                switch (midiasDefinitivas[index + 1])
                {
                    case ("console"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o console" : $"<color=red>e não consegui fazer as atividades com o console";
                        break;
                    case ("computador"):
                        textosFeedback[index + 1].text = index == 0 ? "Consegui fazer as atividades com o computador" : "e consegui fazer as atividades com o computador";
                        break;
                    case ("celular"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o celular" : $"<color=red>e não consegui fazer as atividades com o celular";
                        break;
                    case ("tablet"):
                        textosFeedback[index + 1].text = index == 0 ? "Consegui fazer as atividades com o tablet" : "e consegui fazer as atividades com o tablet";
                        break;
                    case ("estante"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o livro" : $"<color=red>e não consegui fazer as atividades com o livro";
                        break;
                    case ("televisao"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com a televisão" : $"<color=red>e não consegui fazer as atividades com a televisão";
                        break;
                    default:
                        break;
                }
                break;

            case ("Cadernos e Cartazes"):
                switch (midiasDefinitivas[index + 1])
                {
                    case ("console"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o console" : $"<color=red>e não consegui fazer as atividades com o console";
                        break;
                    case ("computador"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o computador" : $"<color=red>e não consegui fazer as atividades com o computador";
                        break;
                    case ("celular"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o celular" : $"<color=red>e não consegui fazer as atividades com o celular";
                        break;
                    case ("tablet"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o tablet" : $"<color=red>e não consegui fazer as atividades com o tablet";
                        break;
                    case ("estante"):
                        textosFeedback[index + 1].text = index == 0 ? "Consegui fazer as atividades com o livro" : "e consegui fazer as atividades com o livro";
                        break;
                    case ("televisao"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com a televisão" : $"<color=red>e não consegui fazer as atividades com a televisão";
                        break;
                    default:
                        break;
                }
                break;

            case ("Televisão"):
                switch (midiasDefinitivas[index + 1])
                {
                    case ("console"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o console" : $"<color=red>e não consegui fazer as atividades com o console";
                        break;
                    case ("computador"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o computador" : $"<color=red>e não consegui fazer as atividades com o computador";
                        break;
                    case ("celular"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o celular" : $"<color=red>e não consegui fazer as atividades com o celular";
                        break;
                    case ("tablet"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o tablet" : $"<color=red>e não consegui fazer as atividades com o tablet";
                        break;
                    case ("estante"):
                        textosFeedback[index + 1].text = index == 0 ? $"<color=red>Não consegui fazer as atividades com o livro" : $"<color=red>e não consegui fazer as atividades com o livro";
                        break;
                    case ("televisao"):
                        textosFeedback[index + 1].text = index == 0 ? "Consegui fazer as atividades com a televisão" : "e consegui fazer as atividades com a televisão";
                        break;
                    default:
                        break;
                }
                break;

            default:
                break;
        }
    }

}
