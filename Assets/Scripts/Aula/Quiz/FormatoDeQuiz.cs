using UnityEngine;
using UnityEngine.UI;

public class FormatoDeQuiz : MonoBehaviour
{
    [SerializeField] Text enunciado;

    public string TextoDoEnunciado
    {
        get { return enunciado.text; }
        set { enunciado.text = value; }
    }

    public virtual float TaxaDeAcerto { get; protected set; }

    protected virtual void Start()
    {
        Esconder();
    }

    public virtual void Esconder()
    {
        gameObject.SetActive(false);
    }

    public virtual void Mostrar()
    {
        gameObject.SetActive(true);
    }
}