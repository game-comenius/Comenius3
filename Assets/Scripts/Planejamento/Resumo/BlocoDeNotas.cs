using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BlocoDeNotas : MonoBehaviour
{
    [SerializeField] private Image icone;
    [SerializeField] private TextMeshProUGUI texto;
    [SerializeField] private Button botaoAnterior;
    [SerializeField] private Button botaoProximo;
    [SerializeField] private bool ABP;

    private int pagina;
}
