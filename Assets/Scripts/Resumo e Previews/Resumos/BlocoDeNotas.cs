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

    private void OnEnable()
    {
        pagina = 0;

        UpdateButtons();
        Atualizar();
    }

    public void AvancarPagina()
    {
        pagina++;

        UpdateButtons();
        Atualizar();
    }

    public void VoltarPagina()
    {
        pagina--;

        UpdateButtons();
        Atualizar();
    }

    private void Atualizar()
    {
        if (pagina == 0)
        {
            icone.sprite = EstadoDoJogo.Instance.Metodologia.sprite;
            Metodologia.AtualizarTextosLinguas();
            texto.text = EstadoDoJogo.Instance.Metodologia.descricaoLonga;
        }
        else
        {
            icone.sprite = EstadoDoJogo.Instance.Midias[pagina - 1].sprite;
            texto.text = EstadoDoJogo.Instance.Midias[pagina - 1].descricaoLonga;
        }
    }

    private void UpdateButtons()
    {
        botaoAnterior.interactable = pagina > 0;
        botaoProximo.interactable = pagina < (ABP ? 2 : 4);
    }
}
