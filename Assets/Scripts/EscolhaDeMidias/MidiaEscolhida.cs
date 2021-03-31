using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//essa classe é super parecida com a ImagemMaior Selecionada, poisé
//mas essa é a dos itens escolhidos, com sprites menores e acesso ao array de mídias selecionadas

//concordo que dá pra fazer melhor, mas tô meio sem tempo
public class MidiaEscolhida : MonoBehaviour
{
    public int posicao;
    private NomeDeMidia selecionada;

    public GameObject anelSelecao;

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
    public Sprite projetorMultimidia;


    private void Start()
    {
        atual.sprite = padrao;
        anelSelecao.SetActive(false);
    }

    public void exibirAnelSelecao(bool x)
    {
        anelSelecao.SetActive(x);
    }

    public void atualizarSelecao(NomeDeMidia[] midia)
    {
        selecionada = midia[posicao];

        switch (selecionada)
        {
            case NomeDeMidia.Nenhuma:
                //atual.sprite = padrao;
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
            case NomeDeMidia.ProjetorMultimidia:
                atual.sprite = projetorMultimidia;
                break;
            default:
                break;
        }
    }
}
