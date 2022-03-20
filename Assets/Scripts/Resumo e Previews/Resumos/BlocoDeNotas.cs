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

        Atualizar();
    }

    public void AvancarPagina()
    {
        int limite = ABP ? 2 : 4;

        if (pagina < limite)
        {
            pagina++;

            if (pagina == limite)
            {
                botaoAnterior.interactable = true;
                botaoProximo.interactable = false;
            }
        }

        Atualizar();
    }

    public void VoltarPagina()
    {
        if (pagina > 0)
        {
            pagina--;

            if (pagina == 0)
            {
                botaoAnterior.interactable = false;
                botaoProximo.interactable = true;
            }
        }

        Atualizar();
    }

    private void Atualizar()
    {
        if (pagina == 0)
        {
            icone.sprite = EstadoDoJogo.Instance.Metodologia.sprite;
            texto.text = EstadoDoJogo.Instance.Metodologia.descricaoLonga;
        }
        else
        {
            icone.sprite = EstadoDoJogo.Instance.Midias[pagina - 1].sprite;
            texto.text = EstadoDoJogo.Instance.Midias[pagina - 1].descricaoLonga;
        }
    }
}
