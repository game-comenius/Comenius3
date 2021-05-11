using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ControladorFeedbackAulaInvertida : MonoBehaviour
{

    [Header("GameObjects das mídias")]
    [SerializeField] GameObject lousa;
    [SerializeField] GameObject livroDidatico;
    [SerializeField] GameObject livrosJornaisERevistas;
    [SerializeField] GameObject cadernosECartazes;
    [SerializeField] GameObject televisao;
    [SerializeField] GameObject aparelhoDeSom;
    [SerializeField] GameObject redesSociais;
    [SerializeField] GameObject jogos;
    [SerializeField] GameObject editoresDeAudioEVideo;
    [SerializeField] GameObject editoresDeTextoEPlanilhas;
    [SerializeField] GameObject aveas;
    [SerializeField] GameObject aplicativos;
    [SerializeField] GameObject projetorMultimidia;

    [SerializeField] GameObject feedbackAulaInvertida;
    [SerializeField] GameObject botaoConfirmarAnterior;

    [Header("Ícones das mídias")]
    [SerializeField] Sprite lousaSprite;
    [SerializeField] Sprite livroDidaticoSprite;
    [SerializeField] Sprite livrosJornaisERevistasSprite;
    [SerializeField] Sprite cadernosECartazesSprite;
    [SerializeField] Sprite televisaoSprite;
    [SerializeField] Sprite aparelhoDeSomSprite;
    [SerializeField] Sprite redesSociaisSprite;
    [SerializeField] Sprite jogosSprite;
    [SerializeField] Sprite editoresDeAudioEVideoSprite;
    [SerializeField] Sprite editoresDeTextoEPlanilhasSprite;
    [SerializeField] Sprite aveasSprite;
    [SerializeField] Sprite aplicativosSprite;
    [SerializeField] Sprite projetorMultimidiaSprite;

    // Start is called before the first frame update
    void Start()
    {
        var estadoDoJogo = EstadoDoJogo.Instance;

        for (int i = 2;  i <= 3; i++) {
            var midiaAtual = estadoDoJogo.MidiasSelecionadas[i].NomeApresentavel;
            switch (midiaAtual)
            {
                case "Lousa":
                    lousa.GetComponent<Image>().sprite = lousaSprite;
                    break;
                case "Livro Didático":
                    livroDidatico.GetComponent<Image>().sprite = livroDidaticoSprite;
                    break;
                case "Livros, Jornais e Revistas":
                    livrosJornaisERevistas.GetComponent<Image>().sprite = livrosJornaisERevistasSprite;
                    break;
                case "Cadernos e Cartazes":
                    cadernosECartazes.GetComponent<Image>().sprite = cadernosECartazesSprite;
                    break;
                case "Televisão":
                    televisao.GetComponent<Image>().sprite = televisaoSprite;
                    break;
                case "Aparelho de Som":
                    aparelhoDeSom.GetComponent<Image>().sprite = aparelhoDeSomSprite;
                    break;
                case "Redes Sociais":
                    redesSociais.GetComponent<Image>().sprite = redesSociaisSprite;
                    break;
                case "Jogos":
                    jogos.GetComponent<Image>().sprite = jogosSprite;
                    break;
                case "Editores de Áudio e Vídeo":
                    editoresDeAudioEVideo.GetComponent<Image>().sprite = editoresDeAudioEVideoSprite;
                    break;
                case "Editores de Texto e Planilhas Eletrônicas":
                    editoresDeTextoEPlanilhas.GetComponent<Image>().sprite = editoresDeTextoEPlanilhasSprite;
                    break;
                case "AVEAs":
                    aveas.GetComponent<Image>().sprite = aveasSprite;
                    break;
                case "Aplicativos":
                    aplicativos.GetComponent<Image>().sprite = aplicativosSprite;
                    break;
                case "Projetor Multimídia":
                    projetorMultimidia.GetComponent<Image>().sprite = projetorMultimidiaSprite;
                    break;

            }
            Debug.Log(estadoDoJogo.MidiasSelecionadas[i].NomeMidia);
        }

    }

    public void Exibir()
    {

        feedbackAulaInvertida.SetActive(true);

    }

    public void EsconderConfirmarAnterior()
    {

        botaoConfirmarAnterior.SetActive(false);

    }

}
