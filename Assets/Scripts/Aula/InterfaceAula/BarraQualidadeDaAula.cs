using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class BarraQualidadeDaAula : MonoBehaviour
{
    private Slider slider;
    private Image preenchimentoImage;

    // Valor da barra é de 0 a 1
    private float valor;
    public float Valor
    {
        get => valor;
        set
        {
            valor = value;
            slider.value = value;
        }
    }

    private void Awake()
    {
        slider = GetComponent<Slider>();
        preenchimentoImage = slider.fillRect.GetComponent<Image>();
    }

    // Barra começa vazia
    void Start() { this.Valor = 0; }
}
