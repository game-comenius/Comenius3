using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelChoicesIconManager : MonoBehaviour
{
    [SerializeField] private GameObject[] icons;
    [SerializeField] private Sprite defaultIcon;

    // Start is called before the first frame update
    void Start()
    {
        icons[0].GetComponent<Image>().sprite = EstadoDoJogo.Instance.SpriteIconePersonagem;
        icons[1].GetComponent<Image>().sprite = EstadoDoJogo.Instance.NivelDeEnsino.sprite;
        icons[2].GetComponent<Image>().sprite = EstadoDoJogo.Instance.AreaDeConhecimento.sprite;
        icons[3].GetComponent<Image>().sprite = EstadoDoJogo.Instance.Inteligencias.sprite;
    }

}
