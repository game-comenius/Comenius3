using UnityEngine;
using UnityEngine.UI;

public class PreviewQuarto : MonoBehaviour
{
    [SerializeField] private Sprite quartoInfantil;
    [SerializeField] private Sprite quartoFundamental;
    [SerializeField] private Sprite quartoMedio;
    [SerializeField] private Sprite quartoSuperior;

    private Image quarto;

    private void Start()
    {
        quarto = GetComponent<Image>();

        switch (EstadoDoJogo.Instance.NivelDeEnsinoSelecionado.nome)
        {
            case "Educação Infantil":
                quarto.sprite = quartoInfantil;
                break;
            case "Ensino Fundamental":
                quarto.sprite = quartoFundamental;
                break;
            case "Ensino Médio":
                quarto.sprite = quartoMedio;
                break;
            case "Ensino Superior":
                quarto.sprite = quartoSuperior;
                break;
            default:
                break;
        }
    }
}
