using UnityEngine;
using UnityEngine.UI;

public class PaginaPlanejamento : MonoBehaviour
{
    [SerializeReference] protected IconManager iconManager;
    [SerializeReference] [TextArea] protected string ajuda;
    [SerializeReference] protected Text textoAjuda;
    [SerializeReference] protected Image fundo;
    [SerializeReference] protected Sprite spriteFundo;

    protected virtual void OnEnable()
    {
        textoAjuda.text = ajuda;
        fundo.sprite = spriteFundo;
    }
}
