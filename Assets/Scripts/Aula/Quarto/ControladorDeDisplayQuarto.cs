using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ControladorDeDisplayQuarto : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite medio;
    [SerializeField] private Sprite fundamental;
    [SerializeField] private Sprite infantil;
    [SerializeField] private Sprite superior;

    void Start()
    {
        if(spriteRenderer == null)
            spriteRenderer = GetComponent<SpriteRenderer>();
        
        int indiceNivelDeEnsino = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado.valor;//Verifica o nivel de ensino selecionado
        //Atribui ao renderer o sprite correspondente ao selecionado
        switch (indiceNivelDeEnsino)
        {
            case 0://Educacao infantil
                spriteRenderer.sprite = infantil;
                break;
            case 1://Ensino Fundamental
                spriteRenderer.sprite = fundamental;
                break;
            case 2://Ensino Medio
                spriteRenderer.sprite = medio;
                break;
            default://Ensino Superior
                spriteRenderer.sprite = superior;
                break;
        }
        
    }
}
