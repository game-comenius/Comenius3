using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelecaoMidia : MonoBehaviour
{
    public GameObject trocadorCena;

    private NomeMidias[] midiasSelecionadas;
    private int selecaoAtual = 0; //para usar de índice escolhendo a mídia
    private int quantidadeMidias = 2;
    private bool selecaoPronta;

    private Midia destaque;
    public GameObject iconeDestaqueMidia;
    public GameObject tituloDestaqueMidia;
    public GameObject descricaoDestaqueMidia;

    public GameObject[] selecionadasUI;

    private void Start()
    {
        //instanciando o tamanho do array de acordo com a metodologia
        //como por enquanto usamos uma metodologia só, estou deixando fixo
        midiasSelecionadas = new NomeMidias[quantidadeMidias];
        destaque = new Midia(NomeMidias.Nenhuma);
        selecaoPronta = false;
    }

    public void DestacarMidia(NomeMidias midia)
    {
        iconeDestaqueMidia.GetComponent<ImagemMaiorSelecionada>().MudarSelecao(midia);
        destaque = new Midia(midia);
        tituloDestaqueMidia.GetComponent<UnityEngine.UI.Text>().text = destaque.NomeApresentavel;
        descricaoDestaqueMidia.GetComponent<TMPro.TextMeshProUGUI>().text = destaque.Descricao;
    }

    public void SelecionarMidia()
    {
        if (!selecaoPronta && destaque.NomeMidia!=NomeMidias.Nenhuma)
        {
            midiasSelecionadas[selecaoAtual] = destaque.NomeMidia;
            selecionadasUI[selecaoAtual].GetComponent<MidiaEscolhida>().atualizarSelecao(midiasSelecionadas);
            Debug.Log("midias planejadas: " + midiasSelecionadas[0] + " " + midiasSelecionadas[1]);
            selecaoAtual++;
            if (selecaoAtual == quantidadeMidias)
            {
                selecaoPronta = true;
                //selecaoAtual--; //para garantir que não vamos apontar para fora do array
                Debug.Log("Ultima mídia selecionada");
            }
        }
        else if(selecaoPronta)
        {
            Debug.Log("Jogador já selecionou todas as mídias");
            AulaABP.PrimeiraMidia = midiasSelecionadas[0];
            AulaABP.SegundaMidia = midiasSelecionadas[1];
            trocadorCena.GetComponent<TrocadorDeCena>().TrocarCena();
        }
    }

    public void DeselecionarMidia()
    {
        selecaoPronta = false;        
        selecaoAtual--;
        if (selecaoAtual < 0)
        {
            selecaoAtual = 0;
        }
        midiasSelecionadas[selecaoAtual] = NomeMidias.Nenhuma;
        selecionadasUI[selecaoAtual].GetComponent<MidiaEscolhida>().atualizarSelecao(midiasSelecionadas);
    }

    public bool checarSelecaoPronta()
    {
        return selecaoPronta;
    }

    public NomeMidias[] obterMidiasSelecionadas()
    {
        return midiasSelecionadas;
    }

}
