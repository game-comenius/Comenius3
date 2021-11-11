using UnityEngine;
using UnityEngine.UI;

public class PaginaAreaDeConhecimento : PaginaPlanejamento
{
    [SerializeField] private string nomePadrao;
    [SerializeField] private Text nomeDoSelecionado;
    [SerializeField] private Text descricaoDoSelecionado;
    [SerializeField] private Button botaoConfirmar;
    [SerializeField] private Image anelDeSelecao;
    [SerializeField] [TextArea] private string descricaoPadrao;
    [SerializeField] private GameObject iconesInfantil;
    [SerializeField] private GameObject iconesFundamental;
    [SerializeField] private GameObject iconesMedio;
    [SerializeField] private GameObject iconesSuperior;

    private GameObject ultimoGrupoAtivo;
    private IconeAreaDeConhecimento iconeSelecionado;

    private void Start()
    {
        // AVISO: Deixe os grupos de ícones desativados no editor do unity.
        // Esse script não desativa todos eles antes, então isso pode causar problemas

        anelDeSelecao.enabled = false;
        botaoConfirmar.interactable = false;

        nomeDoSelecionado.text = nomePadrao;
        descricaoDoSelecionado.text = descricaoPadrao;
    }

    protected override void OnEnable()
    {
        textoAjuda.text = ajuda;

        if (iconeSelecionado)
        {
            iconManager.SetIcon(2, iconeSelecionado.GetComponent<Image>().sprite);
        }

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
                    iconeSelecionado = null;
                    anelDeSelecao.enabled = false;

                    resetar();
                    resetarEstadoDeJogo();
                }

                ultimoGrupoAtivo = iconesInfantil;
                break;
            case 1:
                iconesFundamental.SetActive(true);

                if (ultimoGrupoAtivo != iconesFundamental)
                {
                    iconeSelecionado = null;
                    anelDeSelecao.enabled = false;

                    resetar();
                    resetarEstadoDeJogo();
                }

                ultimoGrupoAtivo = iconesFundamental;
                break;
            case 2:
                iconesMedio.SetActive(true);

                if (ultimoGrupoAtivo != iconesMedio)
                {
                    iconeSelecionado = null;
                    anelDeSelecao.enabled = false;

                    resetar();
                    resetarEstadoDeJogo();
                }

                ultimoGrupoAtivo = iconesMedio;
                break;
            case 3:
                iconesSuperior.SetActive(true);

                if (ultimoGrupoAtivo != iconesSuperior)
                {
                    iconeSelecionado = null;
                    anelDeSelecao.enabled = false;

                    resetar();
                    resetarEstadoDeJogo();
                }

                ultimoGrupoAtivo = iconesSuperior;
                break;
            default:  // Por padrão exibe o grupo infantil
                iconesInfantil.SetActive(true);

                if (ultimoGrupoAtivo != iconesInfantil)
                {
                    iconeSelecionado = null;
                    anelDeSelecao.enabled = false;

                    resetar();
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
            if (iconeSelecionado)
            {
                iconeSelecionado.selecionado = false;
            }

            iconeSelecionado = icone;  // Agora esse ícone será o último selecionado

            // Posiciona o anel de seleção sobre o botão selecionado
            anelDeSelecao.enabled = true;
            var posicaoDoIcone = icone.GetComponent<RectTransform>().anchoredPosition;
            anelDeSelecao.rectTransform.anchoredPosition = posicaoDoIcone;

            atualizar(icone);
            atualizarEstadoDeJogo(icone);
        }
        else  // Cancela a seleção do ícone caso o jogador clique nele de novo
        {
            // Redefine a seleção
            iconeSelecionado = null;
            anelDeSelecao.enabled = false;

            resetar();
            resetarEstadoDeJogo();
        }

        icone.selecionado = !icone.selecionado;  // Inverte o estado de seleção
    }

    public void HoverEnter(IconeAreaDeConhecimento icone)
    {
        if (!iconeSelecionado)
        {
            atualizar(icone);
        }
    }

    public void HoverExit()
    {
        if (!iconeSelecionado)
        {
            resetar();
        }
    }

    private void atualizar(IconeAreaDeConhecimento icone)
    {
        nomeDoSelecionado.text = icone.areaDeConhecimento.nome;
        descricaoDoSelecionado.text = icone.areaDeConhecimento.descricao;
    }

    private void resetar()
    {
        nomeDoSelecionado.text = nomePadrao;
        descricaoDoSelecionado.text = descricaoPadrao;
    }

    private void atualizarEstadoDeJogo(IconeAreaDeConhecimento icone)
    {
        // Altera o sprite do pequeno guia da página para o sprite do selecionado
        iconManager.SetIcon(2, icone.GetComponent<Image>().sprite);

        // Grava a área de conhecimento escolhida
        EstadoDoJogo.Instance.AreaDeConhecimentoSelecionada = icone.areaDeConhecimento;
        EstadoDoJogo.Instance.AreaDeConhecimentoSelecionada.sprite = icone.GetComponent<Image>().sprite;

        // Ativar o botão de confirmar agora que há uma seleção
        botaoConfirmar.interactable = true;
    }

    public void resetarEstadoDeJogo()
    {
        iconManager.ResetIcon(2);

        // Reseta a escolha
        EstadoDoJogo.Instance.AreaDeConhecimentoSelecionada.sprite = null;
        EstadoDoJogo.Instance.AreaDeConhecimentoSelecionada = null;

        botaoConfirmar.interactable = false;
    }
}