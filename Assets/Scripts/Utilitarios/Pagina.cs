using UnityEngine;

public class Pagina : MonoBehaviour
{
    public virtual bool Validar() { return true; }

    public virtual void Mostrar()
    {
        gameObject.SetActive(true);
    }

    public virtual void Esconder()
    {
        gameObject.SetActive(false);
    }

    public virtual void Alternar()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
