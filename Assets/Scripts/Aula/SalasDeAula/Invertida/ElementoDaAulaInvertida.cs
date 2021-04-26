using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementoDaAulaInvertida : MonoBehaviour
{
    [SerializeField]EstadoDeAula estadoNoQualAparece;
    [SerializeField]EstadoDeAulaInvertida controladorDaAula;
    void Awake()
    {
        controladorDaAula.OnStateChange.AddListener(OnStateChange);
    }

    void OnDestroy()
    {
        controladorDaAula.OnStateChange.RemoveListener(OnStateChange);
    }

    void OnStateChange() 
    {
        if((controladorDaAula.estadoAtual & estadoNoQualAparece) > 0)//Se o estado corresponder a um dos estados que aparece
            this.gameObject.SetActive(true);
        else
            this.gameObject.SetActive(false);   
    }
}