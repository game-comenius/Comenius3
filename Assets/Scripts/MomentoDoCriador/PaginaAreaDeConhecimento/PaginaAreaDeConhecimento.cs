using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PaginaAreaDeConhecimento : Pagina
{
    [SerializeField] Text textoInformativo;

    [SerializeField] Text tituloDaPagina;

    [SerializeField] Image iconePequenoGuia;
    private Sprite spriteOriginalDoIconePequenoGuia;

    [SerializeField] Image iconeGrandeEmDestaque;
    [SerializeField] Text NomeDoSelecionado;
    [SerializeField] ScrollRect DescricaoDoSelecionado;

    [SerializeField] TextMeshProUGUI TextoExpandido;


    [Header("Grupo de ícones por nível de ensino")]
    [SerializeField] GrupoDeIconesAreaDeConhecimento iconesInfantil;
    [SerializeField] GrupoDeIconesAreaDeConhecimento iconesFundamental;
    [SerializeField] GrupoDeIconesAreaDeConhecimento iconesMedio;
    [SerializeField] GrupoDeIconesAreaDeConhecimento iconesSuperior;

    private Dictionary<NivelDeEnsino, GrupoDeIconesAreaDeConhecimento> iconesPorNivelDeEnsino;
    private Dictionary<NivelDeEnsino, GrupoDeIconesAreaDeConhecimento> IconesPorNivelDeEnsino
    {
        get
        {
            if (iconesPorNivelDeEnsino != null) return iconesPorNivelDeEnsino;

            // Criar mapeamento entre nível de ensino e os respectivos ícones
            var d = new Dictionary<NivelDeEnsino, GrupoDeIconesAreaDeConhecimento>();
            d[NivelDeEnsino.EducacaoInfantil] = iconesInfantil;
            d[NivelDeEnsino.EnsinoFundamental] = iconesFundamental;
            d[NivelDeEnsino.EnsinoMedio] = iconesMedio;
            d[NivelDeEnsino.EnsinoSuperior] = iconesSuperior;

            return iconesPorNivelDeEnsino = d;
        }
    }

    private GrupoDeIconesAreaDeConhecimento grupoDeIconesAtivo;
    private NivelDeEnsino nivelDeEnsinoSelecionadoAnteriormente;

    private void Start()
    {
        spriteOriginalDoIconePequenoGuia = iconePequenoGuia.sprite;

        //Setar a descrição expandida inicial
        var descricaoExpandidaInicial = TextoExpandido;
        descricaoExpandidaInicial.text = "Agora você deve escolher a ÁREA DO CONHECIMENTO (ou CAMPOS DE APRENDIZAGEM) de acordo com o Nível de Ensino.\n\n" +
            "Todo o resto do seu planejamento será definido por essa escolha. Se você selecionou anteriormente algum nível da Educação Básica, procure ler " +
            "atentamente cada uma delas para aprender mais sobre o assunto de acordo com a nova divisão da Base Nacional Comum Curricular(BNCC).Se selecionou o " +
            "Ensino Superior, é importante aprender sobre como estão definidas de acordo com o Conselho Nacional de Desenvolvimento Cientítico e Tecnoloógico(CNPq).";

        // Toda vez que o grupo de botões disser que um novo botão foi
        // selecionado, a página irá atualizar o ícone grande em destaque,
        // o nome do botão selecionado e o ícone pequeno na lateral esquerda
        foreach (var grupoDeIcones in IconesPorNivelDeEnsino.Values)
        {
            grupoDeIcones.QuandoUmElementoForSelecionadoEvent += (iconeSelecionado) =>
            {
                iconeGrandeEmDestaque.sprite = iconeSelecionado.SpriteGrande;
                iconeGrandeEmDestaque.enabled = true;

                NomeDoSelecionado.text = iconeSelecionado.Valor.nome;
                // Atualizar descrição para a área de conhecimento selecionada
                var textoDaDescricaoDoSelecionado = DescricaoDoSelecionado.GetComponentInChildren<TextMeshProUGUI>();
                textoDaDescricaoDoSelecionado.text = iconeSelecionado.Valor.Descricao;
                // Retornar/resetar scrollbar para o topo
                var scrollbar = DescricaoDoSelecionado.GetComponentInChildren<Scrollbar>();
                if (scrollbar) scrollbar.value = 1;

                //Atualizar descrição no popup expandido para a area de conhecimento selecionada
                var descricaoExpandida = TextoExpandido;
                descricaoExpandida.text = iconeSelecionado.Valor.Expansao;

                var spritePequeno = iconeSelecionado.ImageComponent.sprite;
                iconePequenoGuia.sprite = spritePequeno;
            };
        }
    }

    public override void Mostrar()
    {
        base.Mostrar();

        // Se não há mudanças recentes no nível de ensino, não atualizar página
        var nivelDeEnsinoSelecionado = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado;
        if (nivelDeEnsinoSelecionado == nivelDeEnsinoSelecionadoAnteriormente) return;

        // Porém, se o o jogador escolheu um novo nível de ensino, atualizar
        ApresentarGrupoDeIcones(nivelDeEnsinoSelecionado);
        // Lembrar do nível de ensino atual
        nivelDeEnsinoSelecionadoAnteriormente = nivelDeEnsinoSelecionado;
    }

    public override bool Validar()
    {
        return (grupoDeIconesAtivo && grupoDeIconesAtivo.iconeSelecionado != null);
    }

    public void DesfazerEscolha()
    {
        if (grupoDeIconesAtivo) grupoDeIconesAtivo.DesfazerSelecao();
        // Limpar campo com o nome do ícone escolhido e descrição
        NomeDoSelecionado.text = string.Empty;

        

        //DescricaoDoSelecionado.GetComponentInChildren<TextMeshProUGUI>().text = string.Empty;
        // Esconder destaque de item selecionado, como se não houvesse seleção
        //iconeGrandeEmDestaque.enabled = false;
        // Voltar ícone pequeno ao seu estado original
        if (spriteOriginalDoIconePequenoGuia) iconePequenoGuia.sprite = spriteOriginalDoIconePequenoGuia;
    }

    private void ApresentarGrupoDeIcones(NivelDeEnsino nivelDeEnsino)
    {
        LimparPagina();

        // Mostrar apenas o grupo de ícones do nível de ensino selecionado
        var grupoVisivel = IconesPorNivelDeEnsino[nivelDeEnsino];
        grupoVisivel.Mostrar();
        // Lembrar do grupo que está visível para o jogador
        grupoDeIconesAtivo = grupoVisivel;

        // Caso especial para o nível de ensino infantil
        if (nivelDeEnsino == NivelDeEnsino.EducacaoInfantil)
            tituloDaPagina.text = "Campos de Aprendizagem";
        else
            tituloDaPagina.text = "Área de Conhecimento";

        if (nivelDeEnsino == NivelDeEnsino.EducacaoInfantil)
        {
            textoInformativo.text = "De acordo com a escolha anterior, selecione qual campo de aprendizagem você deseja desenvolver com seus alunos.";
        }
        else
        {
            textoInformativo.text = "De acordo com a escolha anterior, selecione qual área do conhecimento você deseja desenvolver com seus alunos.";
        }
    }

    private void LimparPagina()
    {
        DesfazerEscolha();
        // Esconder os grupos de ícones
        foreach (var grupo in IconesPorNivelDeEnsino.Values) grupo.Esconder();
    }
}