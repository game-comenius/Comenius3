using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SelecaoMidia : MonoBehaviour
{
    public GameObject trocadorCena;

    private NomeDeMidia[] midiasSelecionadas;
    private int selecaoAtual = 0; //para usar de índice escolhendo a mídia
    private int paginaAtual = 0; //para usar de índice nas páginas de mídias
    public int ultimaPagina = 2; //*índice* da última página de opções de mídia, necessário pra evitar um IndexOutOfRange
    [SerializeField]private int quantidadeMidias = 2; //total de mídias a serem selecionadas na metodologia
    private bool selecaoPronta;

    private Midia destaque;
    public GameObject iconeDestaqueMidia;
    public GameObject tituloDestaqueMidia;
    public GameObject descricaoDestaqueMidia;
    public GameObject botaoProximaPaginaDeMidias;
    public GameObject botaoPaginaDeMidiasAnterior;
    public Button botaoProximaMidia;
    public Button botaoMidiaAnterior;

    [SerializeField] TextMeshProUGUI TextoExpandido;

    [SerializeField] Text titulo;
 
    [Header("Textos da seleção: ")]
    [SerializeField] string descriçãoInicial;
    [SerializeField] string[] titulosDasSelecoes;
    
    [Space(10)]

    public GameObject[] selecionadasUI; //parte a UI que mostra as mídias que já foram selecionadas

    public GameObject[] paginasDeMidias; //páginas de opções de mídias

    public GameObject botaoConfirmar;

    private void Start()
    {
        botaoMidiaAnterior.interactable = false;
        titulo.text = titulosDasSelecoes[0];
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

        var descricaoExpandidaInicial = TextoExpandido;


        descricaoExpandidaInicial.text = descriçãoInicial;

       //Iniciar com o botão de voltar página desativado.
        botaoPaginaDeMidiasAnterior.SetActive(false);
    }

    public void ProximaPagina()
    {
        if (paginaAtual < ultimaPagina)
        {

            if (paginaAtual == 1)
            {
                botaoProximaPaginaDeMidias.SetActive(false);

            }

            paginasDeMidias[paginaAtual].SetActive(false);
            paginaAtual++;
            paginasDeMidias[paginaAtual].SetActive(true);

            botaoPaginaDeMidiasAnterior.SetActive(true);
        }
    }

    public void PaginaAnterior()
    {
        if (paginaAtual > 0)
        {

            if (paginaAtual == 1)
            {
                botaoPaginaDeMidiasAnterior.SetActive(false);

            }

            paginasDeMidias[paginaAtual].SetActive(false);
            paginaAtual--;
            paginasDeMidias[paginaAtual].SetActive(true);

            botaoProximaPaginaDeMidias.SetActive(true);

        }

    }

    public void DestacarMidia(NomeDeMidia midia)
    {
        iconeDestaqueMidia.GetComponent<ImagemMaiorSelecionada>().MudarSelecao(midia);
        destaque = new Midia(midia);
        tituloDestaqueMidia.GetComponent<UnityEngine.UI.Text>().text = destaque.NomeApresentavel;
        descricaoDestaqueMidia.GetComponent<TMPro.TextMeshProUGUI>().text = destaque.Descricao;

        var descricaoExpandida = TextoExpandido;
        descricaoExpandida.text = destaque.Expansao;

        midiasSelecionadas[selecaoAtual] = destaque.NomeMidia;
        selecionadasUI[selecaoAtual].GetComponent<MidiaEscolhida>().atualizarSelecao(midiasSelecionadas);
    }

    public void SelecionarMidia()
    {
        if (selecaoAtual == quantidadeMidias - 1)
        {
            botaoProximaMidia.interactable = false;
        }

        if (!selecaoPronta && destaque.NomeMidia != NomeDeMidia.Nenhuma)
        {
            botaoMidiaAnterior.interactable = true;
            titulo.text = titulosDasSelecoes[Mathf.Clamp(selecaoAtual+1, 0,quantidadeMidias-1)];
            midiasSelecionadas[selecaoAtual] = destaque.NomeMidia;
            selecionadasUI[selecaoAtual].GetComponent<MidiaEscolhida>().atualizarSelecao(midiasSelecionadas);

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
            var jogo = EstadoDoJogo.Instance;
            jogo.MidiasSelecionadas = new Midia[quantidadeMidias];
            for (var i = 0; i < quantidadeMidias; i++)
            {
                Midia midia = new Midia(midiasSelecionadas[i]);
                midia.SpriteIcone = selecionadasUI[i].GetComponent<MidiaEscolhida>().atual.sprite;
                jogo.MidiasSelecionadas[i] = midia;
            }
        }
       
        
    }

    public void DeselecionarMidia()
    {

        if (selecaoAtual == 1)
        {
            botaoMidiaAnterior.interactable = false;
        }

        botaoProximaMidia.interactable = true;
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
