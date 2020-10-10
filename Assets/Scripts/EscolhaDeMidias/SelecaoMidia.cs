using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelecaoMidia : MonoBehaviour
{
    public GameObject trocadorCena;

    private NomeDeMidia[] midiasSelecionadas;
    private int selecaoAtual = 0; //para usar de índice escolhendo a mídia
    private int paginaAtual = 0; //para usar de índice nas páginas de mídias
    public int ultimaPagina = 2; //*índice* da última página de opções de mídia, necessário pra evitar um IndexOutOfRange
    private int quantidadeMidias = 2; //total de mídias a serem selecionadas na metodologia
    private bool selecaoPronta;

    private Midia destaque;
    public GameObject iconeDestaqueMidia;
    public GameObject tituloDestaqueMidia;
    public GameObject descricaoDestaqueMidia;

    public GameObject[] selecionadasUI; //parte a UI que mostra as mídias que já foram selecionadas

    public GameObject[] paginasDeMidias; //páginas de opções de mídias

    public GameObject botaoConfirmar;

    private void Start()
    {
        //instanciando o tamanho do array de acordo com a metodologia
        //como por enquanto usamos uma metodologia só, estou deixando fixo
        midiasSelecionadas = new NomeDeMidia[quantidadeMidias];
        destaque = new Midia(NomeDeMidia.Nenhuma);
        selecaoPronta = false;
        botaoConfirmar.SetActive(selecaoPronta);
        foreach (GameObject pagina in paginasDeMidias)
        {
            pagina.SetActive(false);
        }
        paginasDeMidias[paginaAtual].SetActive(true);
        selecionadasUI[0].GetComponent<MidiaEscolhida>().exibirAnelSelecao(true);
    }

    public void ProximaPagina()
    {
        if (paginaAtual < ultimaPagina)
        {
            paginasDeMidias[paginaAtual].SetActive(false);
            paginaAtual++;
            paginasDeMidias[paginaAtual].SetActive(true);
        }
    }

    public void PaginaAnterior()
    {
        if (paginaAtual > 0)
        {
            paginasDeMidias[paginaAtual].SetActive(false);
            paginaAtual--;
            paginasDeMidias[paginaAtual].SetActive(true);
        }
    }

    public void DestacarMidia(NomeDeMidia midia)
    {
        iconeDestaqueMidia.GetComponent<ImagemMaiorSelecionada>().MudarSelecao(midia);
        destaque = new Midia(midia);
        tituloDestaqueMidia.GetComponent<UnityEngine.UI.Text>().text = destaque.NomeApresentavel;
        descricaoDestaqueMidia.GetComponent<TMPro.TextMeshProUGUI>().text = destaque.Descricao;
        midiasSelecionadas[selecaoAtual] = destaque.NomeMidia;
        selecionadasUI[selecaoAtual].GetComponent<MidiaEscolhida>().atualizarSelecao(midiasSelecionadas);
    }

    public void SelecionarMidia()
    {
        if (!selecaoPronta && destaque.NomeMidia != NomeDeMidia.Nenhuma)
        {
            midiasSelecionadas[selecaoAtual] = destaque.NomeMidia;
            selecionadasUI[selecaoAtual].GetComponent<MidiaEscolhida>().atualizarSelecao(midiasSelecionadas);
            Debug.Log("midias planejadas: " + midiasSelecionadas[0] + " " + midiasSelecionadas[1]);
            selecionadasUI[selecaoAtual].GetComponent<MidiaEscolhida>().exibirAnelSelecao(false);
            selecaoAtual++;
            if (selecaoAtual >= quantidadeMidias)
            {
                selecaoPronta = true;
                botaoConfirmar.SetActive(selecaoPronta);
                Debug.Log("Ultima mídia selecionada");
                selecaoAtual = quantidadeMidias - 1; //para não acabarmos fora do array
            }
            selecionadasUI[selecaoAtual].GetComponent<MidiaEscolhida>().exibirAnelSelecao(true);
        }
        else if (selecaoPronta)
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
        botaoConfirmar.SetActive(selecaoPronta);
        selecionadasUI[selecaoAtual].GetComponent<MidiaEscolhida>().exibirAnelSelecao(false);
        selecaoAtual--;
        if (selecaoAtual < 0)
        {
            selecaoAtual = 0;
        }
        selecionadasUI[selecaoAtual].GetComponent<MidiaEscolhida>().exibirAnelSelecao(true);
        midiasSelecionadas[selecaoAtual] = NomeDeMidia.Nenhuma;
        selecionadasUI[selecaoAtual].GetComponent<MidiaEscolhida>().atualizarSelecao(midiasSelecionadas);
    }

    public bool checarSelecaoPronta()
    {
        return selecaoPronta;
    }

    public NomeDeMidia[] obterMidiasSelecionadas()
    {
        return midiasSelecionadas;
    }

}
