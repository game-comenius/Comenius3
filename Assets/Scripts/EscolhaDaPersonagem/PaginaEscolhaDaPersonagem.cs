using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaginaEscolhaDaPersonagem : Pagina
{
    [SerializeField] Image iconePequenoGuia;

    [SerializeField] GrupoDeIconesPersonagem grupoDeIconesPersonagem;

    [SerializeField] Image corpoPersonagemSelecionada;
    [SerializeField] Image cabeloPersonagemSelecionada;
    [SerializeField] Image roupaPersonagemSelecionada;

    [SerializeField] Button botaoConfirmar;

    private void Awake()
    {

        corpoPersonagemSelecionada.gameObject.SetActive(false);
        cabeloPersonagemSelecionada.gameObject.SetActive(false);
        roupaPersonagemSelecionada.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        // Esconder botão confirmar até que uma escolha seja feita
        botaoConfirmar.gameObject.SetActive(false);

        // Toda vez que o grupo de botões disser que um novo botão foi
        // selecionado, a página irá atualizar o ícone grande em destaque,
        // o nome do botão selecionado e o ícone pequeno na lateral esquerda
        grupoDeIconesPersonagem.QuandoUmElementoForSelecionadoEvent += (iconeSelecionado) =>
        {
            // Alterar sprite do pequeno guia da página para o sprite do selecionado
            var spritePequeno = iconeSelecionado.ImageComponent.sprite;
            iconePequenoGuia.sprite = spritePequeno;

            // Ativar sprites do preview
            corpoPersonagemSelecionada.gameObject.SetActive(true);
            cabeloPersonagemSelecionada.gameObject.SetActive(true);
            roupaPersonagemSelecionada.gameObject.SetActive(true);

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
