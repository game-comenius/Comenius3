using UnityEngine;
using UnityEngine.UI;

public abstract class PaginaPlanejamento : MonoBehaviour
{
    [SerializeReference] protected IconManager iconManager;
    [SerializeReference] [TextArea] protected string ajudaPT;
    [SerializeReference] [TextArea] protected string ajudaSP;
    [SerializeReference] [TextArea] protected string ajudaEUA;
    [SerializeReference] protected string ajuda;
    [SerializeReference] protected Text textoAjuda;
    [SerializeReference] protected Image fundo;
    [SerializeReference] protected Sprite spriteFundo;

    protected virtual void OnEnable()
    {  
        fundo.sprite = spriteFundo;
    }

    protected void AtualizarTextos()
    {
        switch (Textos.GetIdiomaSelecionado())
        {
            case Idiomas.INGLES:
                textoAjuda.text = ajudaEUA;
                ajuda = ajudaEUA;
                break;
            case Idiomas.PORTUGUES:
                textoAjuda.text = ajudaPT;
                ajuda = ajudaPT;
                break;
            case Idiomas.ESPANHOL:
                textoAjuda.text = ajudaSP;
                ajuda = ajudaSP;
                break;
            default:
                break;
        }
    }
}
