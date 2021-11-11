using UnityEngine;
using UnityEngine.UI;

public class PaginaPlanejamento : MonoBehaviour
{
    [SerializeReference] protected IconManager iconManager;
    [SerializeReference] [TextArea] protected string ajuda;
    [SerializeReference] protected Text textoAjuda;

    protected virtual void OnEnable()
    {
        textoAjuda.text = ajuda;
    }
}
