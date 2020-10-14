using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmacaoSaida : MonoBehaviour
{
    public GameObject PainelDeConfirmacao;

    public void AbrirPainel()
    {
        if(PainelDeConfirmacao != null)
        {
            PainelDeConfirmacao.SetActive(true);
        }
    }

    public void FecharPainel()
    {
        if(PainelDeConfirmacao != null)
        {
            PainelDeConfirmacao.SetActive(false);
        }
    }

}
