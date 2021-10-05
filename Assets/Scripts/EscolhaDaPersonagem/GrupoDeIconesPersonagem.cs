using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GrupoDeIconesPersonagem : MonoBehaviour
{
    public PaginaEscolhaDaPersonagem paginaEscolhaDaPersonagem;
    [SerializeField] Image AnelDeSelecao;
    [SerializeField] IconePersonagem[] iconesPersonagem;
    [SerializeField] OnHoverShowCharacter[] hoversPersonagens;

    private IconePersonagem ultimoSelecionado;

    private void Start()
    {
        // Cadastrar os botões passados pelo Inspector neste grupo
        foreach (var botao in iconesPersonagem) botao.grupo = this;
        foreach (var hover in hoversPersonagens) hover.group = this; 

        // Esconder anel de seleção pois não há botões selecionados
        AnelDeSelecao.enabled = false;
    }

    public void Selecao(IconePersonagem icone)
    {
        AudioManager.instance.TocarSFX("clique");

        if (!icone.Selecionado)
        {
            if (ultimoSelecionado)
            {
                ultimoSelecionado.Selecionado = false;
            }

            ultimoSelecionado = icone;

            // Posicionar anel de seleção sobre o botão selecionado
            AnelDeSelecao.enabled = true;
            var posicaoDoBotao = icone.GetComponent<RectTransform>().anchoredPosition;
            AnelDeSelecao.rectTransform.anchoredPosition = posicaoDoBotao;

            paginaEscolhaDaPersonagem.atualizarSprites(icone);
            paginaEscolhaDaPersonagem.atualizarEstadoDeJogo(icone);
        }
        else
        {
            ultimoSelecionado = null;

            AnelDeSelecao.enabled = false;

            paginaEscolhaDaPersonagem.resetarSprites();
            paginaEscolhaDaPersonagem.resetarEstadoDeJogo();
        }

        icone.Selecionado = !icone.Selecionado;
    }

    public void HoverEnter(IconePersonagem icone)
    {
        if (!ultimoSelecionado)
        {
            paginaEscolhaDaPersonagem.atualizarSprites(icone);
        }
    }

    public void HoverExit()
    {
        if (!ultimoSelecionado)
        {
            paginaEscolhaDaPersonagem.resetarSprites();
        }
    }
}
