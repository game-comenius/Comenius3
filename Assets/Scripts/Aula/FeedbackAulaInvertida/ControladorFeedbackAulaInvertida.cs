using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ControladorFeedbackAulaInvertida : MonoBehaviour
{

    [Header("GameObjects dos previews")]
    [SerializeField] GameObject midia1;
    [SerializeField] GameObject midia2;
    [SerializeField] GameObject metodologia;
    [SerializeField] GameObject inteligencia;
    [SerializeField] GameObject campoAprendizagem;

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

        midia1.GetComponent<Image>().sprite = estadoDoJogo.MidiasSelecionadas[2].SpriteIcone;
        midia2.GetComponent<Image>().sprite = estadoDoJogo.MidiasSelecionadas[3].SpriteIcone;

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
