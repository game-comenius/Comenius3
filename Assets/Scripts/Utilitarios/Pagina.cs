using UnityEngine;

public class Pagina : MonoBehaviour
{
    public virtual bool Validar() { return true; }

    public virtual void Mostrar()
    {
        this.gameObject.SetActive(true);
    }

    public virtual void Esconder()
    {
        this.gameObject.SetActive(false);
    }
}
