using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ControladorFeedbackAulaInvertida : MonoBehaviour
{

    [Header("GameObjects dos previews")]
    [SerializeField] GameObject midia1;
    [SerializeField] GameObject midia2;
    [SerializeField] GameObject metodologia;
    [SerializeField] GameObject inteligencia;
    [SerializeField] GameObject campoAprendizagem;

    [SerializeField] GameObject feedbackAulaInvertida;
    [SerializeField] GameObject botaoConfirmarAnterior;
    [SerializeField] GameObject feedbackAulaInvertidaLurdinhaTexto;
    [SerializeField] GameObject feedbackAulaInvertidaAlunoTexto;
    [SerializeField] GameObject feedbackAulaInvertidaAlunoNome;

    [Header("Ícones das mídias")]
    [SerializeField] Sprite lousaSprite;
    [SerializeField] Sprite livroDidaticoSprite;
    [SerializeField] Sprite livrosJornaisERevistasSprite;
    [SerializeField] Sprite cadernosECartazesSprite;
    [SerializeField] Sprite televisaoSprite;
    [SerializeField] Sprite aparelhoDeSomSprite;
    [SerializeField] Sprite redesSociaisSprite;
    [SerializeField] Sprite jogosSprite;
    [SerializeField] Sprite editoresDeAudioEVideoSprite;
    [SerializeField] Sprite editoresDeTextoEPlanilhasSprite;
    [SerializeField] Sprite aveasSprite;
    [SerializeField] Sprite aplicativosSprite;
    [SerializeField] Sprite projetorMultimidiaSprite;

    [Header("Ícones das inteligências")]
    [SerializeField] Sprite corporalSprite;
    [SerializeField] Sprite intrapessoalSprite;
    [SerializeField] Sprite interpessoalSprite;
    [SerializeField] Sprite linguisticaSprite;

    // Boa parte do código foi copiado do PaginaResultadoDaAula, vou ver se faço herança depois pra diminuir o código repetido.
    // Start is called before the first frame update
    void Start()
    {
        var estadoDoJogo = EstadoDoJogo.Instance;

        midia1.GetComponent<Image>().sprite = estadoDoJogo.MidiasSelecionadas[2].SpriteIcone;
        midia2.GetComponent<Image>().sprite = estadoDoJogo.MidiasSelecionadas[3].SpriteIcone;

        switch(estadoDoJogo.InteligenciasSelecionadas.Valor)
        {

            case 0:
                inteligencia.GetComponent<Image>().sprite = corporalSprite;
                break;

            case 1:
                inteligencia.GetComponent<Image>().sprite = intrapessoalSprite;
                break;

            case 2:
                inteligencia.GetComponent<Image>().sprite = interpessoalSprite;
                break;

            case 3:
                inteligencia.GetComponent<Image>().sprite = linguisticaSprite;
                break;

        }

        campoAprendizagem.GetComponent<Image>().sprite = estadoDoJogo.AreaDeConhecimentoSelecionada.Sprite;

        AtualizarFeedbackDaLurdinha();
        AtualizarFeedbackDosAlunos();

    }

    private void AtualizarFeedbackDaLurdinha()
    {
        var listaDeFeedback = FeedbackDaLurdinha.ObterFeedback(EstadoDoJogo.Instance);
        var feedbackCompleto = string.Join("\n\n", listaDeFeedback);
        feedbackAulaInvertidaLurdinhaTexto.GetComponent<Text>().text = feedbackCompleto;
    }


    private void AtualizarFeedbackDosAlunos()
    {

        var (feedbackDoAluno, assinatura) = FeedbackDosAlunos.ObterFeedback(EstadoDoJogo.Instance);

        // Colocar àspas ao redor do feedback do aluno
        feedbackDoAluno = $"\"{feedbackDoAluno}\"";
        feedbackAulaInvertidaAlunoTexto.GetComponent<Text>().text = feedbackDoAluno;

        if (assinatura != null)
        {
            feedbackAulaInvertidaAlunoNome.SetActive(true);
            feedbackAulaInvertidaAlunoNome.GetComponent<Text>().text = assinatura;
        }
        else
        {
            // Se ninguém assinou, esconder o GameObject da assinatura
            feedbackAulaInvertidaAlunoNome.SetActive(false);
        }

    }

    public void Exibir()
    {

        feedbackAulaInvertida.SetActive(true);

    }

    public void EsconderConfirmarAnterior()
    {

        botaoConfirmarAnterior.SetActive(false);

    }

}
