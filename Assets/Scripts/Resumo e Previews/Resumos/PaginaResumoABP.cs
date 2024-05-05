using UnityEngine;
using UnityEngine.UI;

public class PaginaResumoABP : PaginaPlanejamento
{
    [SerializeField] private Text texto;
    [SerializeField] private Sprite primeiroIcone;
    [SerializeField] private Sprite segundoIcone;
    [SerializeField] private Image iconePrimeiraMidia;
    [SerializeField] private Image iconeSegundaMidia;

    protected override void OnEnable()
    {
        AtualizarTextos();
        fundo.sprite = spriteFundo;

        textoAjuda.text = ajuda;

        iconManager.ShowIcon(0);
        iconManager.ShowIcon(1);
        iconManager.HideIcon(2);
        iconManager.HideIcon(3);

        iconManager.SetIcon(0, primeiroIcone);
        iconManager.SetIcon(1, segundoIcone);

        iconePrimeiraMidia.sprite = EstadoDoJogo.Instance.Midias[0].sprite;
        iconeSegundaMidia.sprite = EstadoDoJogo.Instance.Midias[1].sprite;

        texto.text = ReceiveTrad();
            

        string ReceiveTrad()
        {
            switch (Textos.GetIdiomaSelecionado())
            {
                case Idiomas.INGLES:
                    return "Your class will be held in the <b>Laboratory using the Problem-Based Learning (PBL) methodology</b> with the media " +
                     $"<b>{EstadoDoJogo.Instance.Midias[0].nome}</b> and <b>{EstadoDoJogo.Instance.Midias[1].nome}</b>.";
                    break;
                case Idiomas.PORTUGUES:
                    return "Your class will be held in the <b>Laboratory using the Problem-Based Learning (PBL) methodology</b> with the media " +
                            $"<b>{EstadoDoJogo.Instance.Midias[0].nome}</b> and <b>{EstadoDoJogo.Instance.Midias[1].nome}</b>.";
                    break;
                case Idiomas.ESPANHOL:
                    return "Tu clase se realizará en el <b>Laboratorio utilizando la metodología de Aprendizaje Basado en Problemas (ABP)</b> con los medios " +
                     $"<b>{EstadoDoJogo.Instance.Midias[0].nome}</b> y <b>{EstadoDoJogo.Instance.Midias[1].nome}</b>.";
                    break;
                default:
                    return "Your class will be held in the <b>Laboratory using the Problem-Based Learning (PBL) methodology</b> with the media " +
                          $"<b>{EstadoDoJogo.Instance.Midias[0].nome}</b> and <b>{EstadoDoJogo.Instance.Midias[1].nome}</b>.";
                    break;
            }
        }
    }

    private void OnDisable()
    {
        iconManager.ResetIcon(0);
        iconManager.ResetIcon(1);
    }
}
