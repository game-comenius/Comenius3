using UnityEngine;
using UnityEngine.UI;

public class PreviewSala : MonoBehaviour
{
    [SerializeField] private Sprite salaInfantil;
    [SerializeField] private Sprite salaRegular;

    private Image sala;

    private void Start()
    {
        sala = GetComponent<Image>();

        if (EstadoDoJogo.Instance.NivelDeEnsinoSelecionado == NivelDeEnsino.EducacaoInfantil)
        {
            sala.sprite = salaInfantil;
        }
        else
        {
            if (EstadoDoJogo.Instance.MetodologiaSelecionada == Metodologia.ABP)
            {
                sala.sprite = salaRegular;
            }
        }
    }
}
