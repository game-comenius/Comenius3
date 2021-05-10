using System.Collections;
using System.Collections.Generic;
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
                
    }

    void Exibir()
    {

        feedbackAulaInvertida.SetActive(true);

    }

}
