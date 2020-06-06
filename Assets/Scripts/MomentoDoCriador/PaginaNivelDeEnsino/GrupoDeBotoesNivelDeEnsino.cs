using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GrupoDeBotoesNivelDeEnsino : MonoBehaviour
{
    [SerializeField] BotaoNivelDeEnsino[] botoesNivelDeEnsino;

    public BotaoNivelDeEnsino BotaoSelecionado
    {
        get { return botoesNivelDeEnsino.Where((b) => b.Selecionado).FirstOrDefault(); }
    }

    private void Start()
    {
        // Cadastrar os botões passados pelo Inspector neste grupo
        foreach (var botao in botoesNivelDeEnsino) botao.grupo = this;
    }

    public bool Selecionar(BotaoNivelDeEnsino botao)
    {
        // Se botão não faz parte do grupo, ignorar
        if (!botoesNivelDeEnsino.Contains(botao)) return false;

        var botaoQueEstavaSelecionado = BotaoSelecionado;
        if (botaoQueEstavaSelecionado)
        {
            // Se o botão já estiver selecionado, ignorar, se for outro botão,
            // retirar a seleção do botão atualmente selecionado
            if (botao == botaoQueEstavaSelecionado)
                return true;
            else
                botaoQueEstavaSelecionado.Selecionado = false;
        }

        botao.Selecionado = true;

        EstadoDoJogo.Instance.NivelDeEnsinoSelecionado = botao.Valor;

        return true;
    }
}
