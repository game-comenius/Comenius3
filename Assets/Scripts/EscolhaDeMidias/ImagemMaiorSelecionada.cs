using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImagemMaiorSelecionada : MonoBehaviour
{
    public Image atual;
    public Sprite padrao;

    public Sprite cadernosCartazes;
    public Sprite televisao;
    public Sprite livroDidatico;
    public Sprite lousa;
    public Sprite livrosJornaisRevistas;
    public Sprite aparelhoDeSom;
    public Sprite redesSociais;
    public Sprite jogos;
    public Sprite editoresAudioVideo;
    public Sprite editoresTextoPlanilhasEletronicas;
    public Sprite aveas;
    public Sprite aplicativos;

    private void Start()
    {
        atual.sprite = padrao;
    }

    public void MudarSelecao (NomeDeMidia midia)
    {

        switch (midia)
        {
            case NomeDeMidia.Nenhuma:
                atual.sprite = padrao;
                break;
            case NomeDeMidia.CadernosECartazes:
                atual.sprite = cadernosCartazes;
                break;
            case NomeDeMidia.Televisao:
                atual.sprite = televisao;
                break;            
            case NomeDeMidia.LivroDidatico:
                atual.sprite = livroDidatico;
                break;
            case NomeDeMidia.Lousa:
                atual.sprite = lousa;
                break;
            case NomeDeMidia.LivrosJornaisERevistas:
                atual.sprite = livrosJornaisRevistas;
                break;
            case NomeDeMidia.AparelhoDeSom:
                atual.sprite = aparelhoDeSom;
                break;
            case NomeDeMidia.RedesSociais:
                atual.sprite = redesSociais;
                break;
            case NomeDeMidia.Jogos:
                atual.sprite = jogos;
                break;
            case NomeDeMidia.EditoresDeAudioEVideo:
                atual.sprite = editoresAudioVideo;
                break;
            case NomeDeMidia.EditoresDeTextoEPlanilhasEletronicas:
                atual.sprite = editoresTextoPlanilhasEletronicas;
                break;
            case NomeDeMidia.AVEAs:
                atual.sprite = aveas;
                break;
            case NomeDeMidia.Aplicativos:
                atual.sprite = aplicativos;
                break;
            default:
                break;
        }
    }
}
