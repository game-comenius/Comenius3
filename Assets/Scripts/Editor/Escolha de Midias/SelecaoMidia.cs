using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelecaoMidia : MonoBehaviour
{
    private NomeMidias[] midiasSelecionadas;
    private int selecaoAtual = 0; //para usar de índice escolhendo a mídia
    private int quantidadeMidias = 3;
    private bool selecaoPronta;

    private void Start()
    {
        //instanciando o tamanho do array de acordo com a metodologia
        //como por enquanto usamos uma metodologia só, estou deixando fixo
        midiasSelecionadas = new NomeMidias[quantidadeMidias];
        selecaoPronta = false;
    }

    public void SelecionarMidia(NomeMidias midia)
    {
        midiasSelecionadas[selecaoAtual] = midia;
        selecaoAtual++;
        if (selecaoAtual == quantidadeMidias)
            selecaoPronta = true;
    }

    public void DeselecionarMidia()
    {
        selecaoPronta = false;
        selecaoAtual--;
        if (selecaoAtual < 0)
            selecaoAtual = 0;
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
