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
    }
}
