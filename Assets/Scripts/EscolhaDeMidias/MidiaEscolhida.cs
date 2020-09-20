using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MidiaEscolhida : MonoBehaviour
{
    public int posicao;
    private NomeMidias selecionada;

    public Image atual;
    public Sprite padrao;

    public Sprite cadernosCartazes;
    public Sprite televisao;
    public Sprite livroDidatico;
    public Sprite lousa;

    private void Start()
    {
        atual.sprite = padrao;
    }

    public void atualizarSelecao(NomeMidias[] midia)
    {
        selecionada = midia[posicao];

        switch (selecionada)
        {
            case NomeMidias.Nenhuma:
                atual.sprite = padrao;
                break;
            case NomeMidias.CadernosECartazes:
                atual.sprite = cadernosCartazes;
                break;
            case NomeMidias.Televisao:
                atual.sprite = televisao;
                break;
            case NomeMidias.LivroDidatico:
                atual.sprite = livroDidatico;
                break;
            case NomeMidias.Lousa:
                atual.sprite = lousa;
                break;
            default:
                break;
        }
    }
}
