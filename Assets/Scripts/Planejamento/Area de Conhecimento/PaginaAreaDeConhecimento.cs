using UnityEngine;
using UnityEngine.UI;

public class PaginaAreaDeConhecimento : Pagina
{
    [SerializeField] private string nomePadrao;
    [SerializeField] private IconManager iconManager;
    [SerializeField] private Text nomeDoSelecionado;
    [SerializeField] private Text descricaoDoSelecionado;
    [SerializeField] private Button botaoConfirmar;
    [SerializeField] private Image anelDeSelecao;
    [SerializeField] private GameObject iconesInfantil;
    [SerializeField] private GameObject iconesFundamental;
    [SerializeField] private GameObject iconesMedio;
    [SerializeField] private GameObject iconesSuperior;
    [SerializeField] [TextArea] private string descricaoPadrao;

    private GameObject ultimoGrupoAtivo;
    private IconeAreaDeConhecimento ultimoSelecionado;

    private void Start()
    {
        // AVISO: Deixe os grupos de ícones desativados no editor do unity.
        // Esse script não desativa todos eles antes, então isso pode causar problemas

        anelDeSelecao.enabled = false;
        botaoConfirmar.interactable = false;

        nomeDoSelecionado.text = nomePadrao;
        descricaoDoSelecionado.text = descricaoPadrao;
    }

    private void OnEnable()
    {
        // Atualiza qual grupo deve ser exibido no momento

        if (ultimoGrupoAtivo)
        {
            ultimoGrupoAtivo.SetActive(false);
        }

        switch (EstadoDoJogo.Instance.NivelDeEnsinoSelecionado.valor)
        {
            case 0:
                iconesInfantil.SetActive(true);

                if (ultimoGrupoAtivo != iconesInfantil)
                {
                    ultimoSelecionado = null;
                    anelDeSelecao.enabled = false;

                    resetarTexto();
                    resetarEstadoDeJogo();
                }

                ultimoGrupoAtivo = iconesInfantil;
                break;
            case 1:
                iconesFundamental.SetActive(true);

                if (ultimoGrupoAtivo != iconesFundamental)
                {
                    ultimoSelecionado = null;
                    anelDeSelecao.enabled = false;

                    resetarTexto();
                    resetarEstadoDeJogo();
                }

                ultimoGrupoAtivo = iconesFundamental;
                break;
            case 2:
                iconesMedio.SetActive(true);

                if (ultimoGrupoAtivo != iconesMedio)
                {
                    ultimoSelecionado = null;
                    anelDeSelecao.enabled = false;

                    resetarTexto();
                    resetarEstadoDeJogo();
                }

                ultimoGrupoAtivo = iconesMedio;
                break;
            case 3:
                iconesSuperior.SetActive(true);

                if (ultimoGrupoAtivo != iconesSuperior)
                {
                    ultimoSelecionado = null;
                    anelDeSelecao.enabled = false;

                    resetarTexto();
                    resetarEstadoDeJogo();
                }

                ultimoGrupoAtivo = iconesSuperior;
                break;
            default:  // Por padrão exibe o grupo infantil
                iconesInfantil.SetActive(true);

                if (ultimoGrupoAtivo != iconesInfantil)
                {
                    ultimoSelecionado = null;
                    anelDeSelecao.enabled = false;

                    resetarTexto();
                    resetarEstadoDeJogo();
                }

                ultimoGrupoAtivo = iconesInfantil;
                break;
        }
    }

    public void Selecao(IconeAreaDeConhecimento icone)
    {
        AudioManager.instance.TocarSFX("clique");

        if (!icone.selecionado)  // O ícone foi selecionado
        {
            // Marca o último ícone selecionado como falso
            if (ultimoSelecionado)
            {
                ultimoSelecionado.selecionado = false;
            }

            ultimoSelecionado = icone;  // Agora esse ícone será o último selecionado

            // Posiciona o anel de seleção sobre o botão selecionado
            anelDeSelecao.enabled = true;
            var posicaoDoIcone = icone.GetComponent<RectTransform>().anchoredPosition;
            anelDeSelecao.rectTransform.anchoredPosition = posicaoDoIcone;

            atualizarTexto(icone);
            atualizarEstadoDeJogo(icone);
        }
        else  // Cancela a seleção do ícone caso o jogador clique nele de novo
        {
            // Redefine a seleção
            ultimoSelecionado = null;
            anelDeSelecao.enabled = false;

            resetarTexto();
            resetarEstadoDeJogo();
        }

        icone.selecionado = !icone.selecionado;  // Inverte o estado de seleção
    }

    public void HoverEnter(IconeAreaDeConhecimento icone)
    {
        if (!ultimoSelecionado)
        {
            atualizarTexto(icone);
        }
    }

    public void HoverExit()
    {
        if (!ultimoSelecionado)
        {
            resetarTexto();
        }
    }

    public void atualizarTexto(IconeAreaDeConhecimento icone)
    {
        nomeDoSelecionado.text = icone.areaDeConhecimento.nome;
        descricaoDoSelecionado.text = icone.areaDeConhecimento.Descricao;
    }

    public void resetarTexto()
    {
        nomeDoSelecionado.text = nomePadrao;
        descricaoDoSelecionado.text = descricaoPadrao;
    }

    public void atualizarEstadoDeJogo(IconeAreaDeConhecimento icone)
    {
        // Altera o sprite do pequeno guia da página para o sprite do selecionado
        iconManager.SetIcon(2, icone.GetComponent<Image>().sprite);

        // Grava a área de conhecimento escolhida
        EstadoDoJogo.Instance.AreaDeConhecimentoSelecionada = icone.areaDeConhecimento;
        EstadoDoJogo.Instance.AreaDeConhecimentoSelecionada.Sprite = icone.GetComponent<Image>().sprite;

        // Ativar o botão de confirmar agora que há uma seleção
        botaoConfirmar.interactable = true;
    }

    public void resetarEstadoDeJogo()
    {
        iconManager.ResetIcon(2);

        // Reseta a escolha
        EstadoDoJogo.Instance.AreaDeConhecimentoSelecionada = null;
        EstadoDoJogo.Instance.AreaDeConhecimentoSelecionada.Sprite = null;

        botaoConfirmar.interactable = false;
    }
}