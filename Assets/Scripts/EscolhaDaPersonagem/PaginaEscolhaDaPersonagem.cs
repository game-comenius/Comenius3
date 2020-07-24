using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaginaEscolhaDaPersonagem : Pagina
{
    [SerializeField] Image iconePequenoGuia;
    [SerializeField] Text NomeDoSelecionado;

    [SerializeField] GrupoDeIconesPersonagem grupoDeIconesPersonagem;

    [SerializeField] Image corpoPersonagemSelecionada;
    [SerializeField] Image cabeloPersonagemSelecionada;
    [SerializeField] Image roupaPersonagemSelecionada;

    [SerializeField] Button botaoConfirmar;

    // Start is called before the first frame update
    void Start()
    {
        // Limpar nome do selecionado pois não há seleção ainda
        NomeDoSelecionado.text = string.Empty;

        // Esconder botão confirmar até que uma escolha seja feita
        botaoConfirmar.gameObject.SetActive(false);

        // Toda vez que o grupo de botões disser que um novo botão foi
        // selecionado, a página irá atualizar o ícone grande em destaque,
        // o nome do botão selecionado e o ícone pequeno na lateral esquerda
        grupoDeIconesPersonagem.QuandoUmElementoForSelecionadoEvent += (iconeSelecionado) =>
        {
            // Alterar o nome do selecionado
            // ...

            // Alterar sprite do pequeno guia da página para o sprite do selecionado
            var spritePequeno = iconeSelecionado.ImageComponent.sprite;
            iconePequenoGuia.sprite = spritePequeno;

            // Alterar o preview da personagem selecionada
            corpoPersonagemSelecionada.sprite = iconeSelecionado.SpriteCorpo;
            cabeloPersonagemSelecionada.sprite = iconeSelecionado.SpriteCabelo;
            roupaPersonagemSelecionada.sprite = iconeSelecionado.SpriteRoupa;

            // Ativar o botão de confirmar agora que há uma seleção
            botaoConfirmar.gameObject.SetActive(true);
        };
    }

    public override bool Validar()
    {
        return (grupoDeIconesPersonagem.IconeSelecionado != null);
    }
}
