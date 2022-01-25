using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResumoGlobal : MonoBehaviour
{
    [SerializeField] private Image iconePersonagem;
    [SerializeField] private Image iconeNivelDeEnsino;
    [SerializeField] private Image iconeAreaDeConhecimento;
    [SerializeField] private Image iconeInteligenciasMultiplas;
    [SerializeField] private TextMeshProUGUI texto;

    private void OnEnable()
    {
        iconePersonagem.sprite = EstadoDoJogo.Instance.SpriteIconePersonagem;
        iconeNivelDeEnsino.sprite = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado.sprite;
        iconeAreaDeConhecimento.sprite = EstadoDoJogo.Instance.AreaDeConhecimentoSelecionada.sprite;
        iconeInteligenciasMultiplas.sprite = EstadoDoJogo.Instance.InteligenciasSelecionadas.sprite;
        
        string preposition = EstadoDoJogo.Instance.NivelDeEnsinoSelecionado == NivelDeEnsino.EducacaoInfantil ? "da" : "do";

        texto.text = $"Você irá jogar uma aula {preposition} {EstadoDoJogo.Instance.NivelDeEnsinoSelecionado.nome} " +
                     $"sobre {EstadoDoJogo.Instance.AreaDeConhecimentoSelecionada.nome} " +
                     $"com uma turma de perfil {EstadoDoJogo.Instance.InteligenciasSelecionadas.nome}.";
    }
}
