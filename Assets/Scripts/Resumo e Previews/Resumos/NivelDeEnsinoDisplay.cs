using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NivelDeEnsinoDisplay : MonoBehaviour
{
    [SerializeField] bool atualizaOnStart;
    [SerializeField] GameObject icone;
    [SerializeField] Text texto;

    [Header("Ícones dos Níveis De Ensino")]
    [SerializeField] Sprite infantil;
    [SerializeField] Sprite fundamental;
    [SerializeField] Sprite medio;
    [SerializeField] Sprite superior;

    private void Start()
    {
        if(atualizaOnStart)
            Atualizar();
    }

    public void Atualizar()
    {
        var estadoDoJogo = EstadoDoJogo.Instance;

        Sprite sprite;
        texto.text = estadoDoJogo.NivelDeEnsinoSelecionado.nome;

        switch(estadoDoJogo.NivelDeEnsinoSelecionado.valor)
        {

            case 0:
                sprite = infantil;
                break;

            case 1:
                sprite = fundamental;
                break;

            case 2:
                sprite = medio;
                break;

            default:
                sprite = superior;
                break;

        }

        icone.GetComponent<Image>().sprite = sprite;
    }
}
