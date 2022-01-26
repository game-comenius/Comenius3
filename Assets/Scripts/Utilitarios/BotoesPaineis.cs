using UnityEngine;

public class BotoesPaineis : MonoBehaviour
{
    public GameObject painel;

    [System.Obsolete("Este componente é obsoleto, é melhor usar o próprio Unity para controlar os painéis.")]
    public void AbrirPainel()
    {
        if (painel != null)
        {
            painel.SetActive(true);
        }
    }

    [System.Obsolete("Este componente é obsoleto, é melhor usar o próprio Unity para controlar os painéis.")]
    public void FecharPainel()
    {
        if (painel != null)
        {
            painel.SetActive(false);
        }
    }

}
