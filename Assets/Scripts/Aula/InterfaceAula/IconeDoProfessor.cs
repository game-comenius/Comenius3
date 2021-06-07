using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconeDoProfessor : MonoBehaviour
{
    Image imagemProfessor;

    private void Start()
    {
        if (imagemProfessor == null)
            imagemProfessor = transform.gameObject.GetComponent<Image>();

        imagemProfessor.sprite = EstadoDoJogo.Instance.SpriteIconePersonagem;
    }

}
