using System.Collections;
using UnityEngine;

public abstract class SalaDeAula : MonoBehaviour
{
    private void Awake()
    {
        this.gameObject.SetActive(false);
    }

    public virtual IEnumerator Mostrar()
    {
        this.gameObject.SetActive(true);

        yield break;
    }
}
