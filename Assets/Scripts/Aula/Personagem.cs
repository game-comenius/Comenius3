using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    [SerializeField] SpriteRenderer corpo;
    [SerializeField] SpriteRenderer cabelo;
    [SerializeField] SpriteRenderer roupa;

    // Start is called before the first frame update
    void Start()
    {
        var estadoDoJogo = EstadoDoJogo.Instance;
        if (estadoDoJogo.SpriteCorpoPersonagem) corpo.sprite = estadoDoJogo.SpriteCorpoPersonagem;
        if (estadoDoJogo.SpriteCabeloPersonagem) cabelo.sprite = estadoDoJogo.SpriteCabeloPersonagem;
        if (estadoDoJogo.SpriteRoupaPersonagem) roupa.sprite = estadoDoJogo.SpriteRoupaPersonagem;
    }
}
