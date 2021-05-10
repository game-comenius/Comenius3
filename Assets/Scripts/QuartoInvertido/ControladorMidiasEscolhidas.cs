using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class ControladorMidiasEscolhidas : MonoBehaviour
{
    [SerializeField] GameObject midia0;
    [SerializeField] GameObject midia1;
    [SerializeField] GameObject midia2;
    [SerializeField] GameObject previewMidia;

    [SerializeField] GameObject popUpTipo;
    [SerializeField] GameObject popUpNome;

    [SerializeField] GameObject painelFeedback;

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

    private int midiaAtual = 0;
    private string midiaProvisoria;
    private string[] midiasDefinitivas = new string[3];
    private Sprite spriteProvisorio;

    // Start is called before the first frame update
    void Start()
    {
        //var midia = Midia.Instance;
        midia0.SetActive(false);
        midia1.SetActive(false);
        midia2.SetActive(false);

    }

    public void onClickProvisorio(string midia)
    {
        switch(midia)
        {
            case "estante":
                midiaProvisoria = midia;
                spriteProvisorio = estanteSprite;
                popUpTipo.GetComponent<TextMeshProUGUI>().text = "Tipo: Mídia";
                popUpNome.GetComponent<TextMeshProUGUI>().text = "Livro Didático";
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
            default:
                break;
        }
    }

    public void onClickDefinitivo() 
    {
        switch(midiaAtual)
        {
            case 0:
                midia0.GetComponent<SpriteRenderer>().sprite = spriteProvisorio;
                midia0.SetActive(true);
                break;
            case 1:
                midia1.GetComponent<SpriteRenderer>().sprite = spriteProvisorio;
                midia1.SetActive(true);
                break;
            default:
                midia2.GetComponent<SpriteRenderer>().sprite = spriteProvisorio;
                midia2.SetActive(true);
                break;
        }

        if (midiaAtual < 2)
        {
            midiasDefinitivas[midiaAtual] = midiaProvisoria;
            Debug.Log(midiaAtual);
            midiaAtual++;
            Debug.Log(midiaAtual);
        } else
        {
            midiasDefinitivas[midiaAtual] = midiaProvisoria;
            Debug.Log(midiaAtual);
            painelFeedback.SetActive(true);
            Debug.Log(midiasDefinitivas[0] + " " + midiasDefinitivas[1] + " " + midiasDefinitivas[2]);
        }
        

    }

}
