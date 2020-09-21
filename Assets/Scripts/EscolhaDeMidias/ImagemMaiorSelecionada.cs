﻿using System.Collections;
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

    public void MudarSelecao (NomeMidias midia)
    {

        switch (midia)
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
            case NomeMidias.LivrosJornaisERevistas:
                atual.sprite = livrosJornaisRevistas;
                break;
            case NomeMidias.AparelhoDeSom:
                atual.sprite = aparelhoDeSom;
                break;
            case NomeMidias.RedesSociais:
                atual.sprite = redesSociais;
                break;
            case NomeMidias.Jogos:
                atual.sprite = jogos;
                break;
            case NomeMidias.EditoresDeAudioEVideo:
                atual.sprite = editoresAudioVideo;
                break;
            case NomeMidias.EditoresDeTextoEPlanilhasEletronicas:
                atual.sprite = editoresTextoPlanilhasEletronicas;
                break;
            case NomeMidias.AVEAs:
                atual.sprite = aveas;
                break;
            case NomeMidias.Aplicativos:
                atual.sprite = aplicativos;
                break;
            default:
                break;
        }
    }
}