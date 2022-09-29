using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldImage : MonoBehaviour
{
    public Sprite[] personagensSprite = new Sprite[3];
    public int valor = 0;
    private void Awake()
    {
        valor = 0;

    }
    private void Start()
    {
   
    }

    public void AtualizarSprite()
    {
        valor++;
        Debug.Log(EstadoDoJogo.Instance.Midias[0].nomeMidia);
        Debug.Log(EstadoDoJogo.Instance.Midias[1].nomeMidia);
        Debug.Log(EstadoDoJogo.Instance.Midias[2].nomeMidia);
        Debug.Log(EstadoDoJogo.Instance.Midias[3].nomeMidia);
        Debug.Log(EstadoDoJogo.Instance.Midias[4].nomeMidia);
    }
}
