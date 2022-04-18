using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResumoGlobal : MonoBehaviour
{
    [SerializeField] private Image iconePersonagem;
    [SerializeField] private Image iconeNivelDeEnsino;
    [SerializeField] private Image iconeAreaDeConhecimento;
    [SerializeField] private Image iconeInteligenciasMultiplas;
    [SerializeField] private TextMeshProUGUI tema;
    [SerializeField] private TextMeshProUGUI texto;

    private void OnEnable()
    {
        iconePersonagem.sprite = EstadoDoJogo.Instance.SpriteIconePersonagem;
        iconeNivelDeEnsino.sprite = EstadoDoJogo.Instance.NivelDeEnsino.sprite;
        iconeAreaDeConhecimento.sprite = EstadoDoJogo.Instance.AreaDeConhecimento.sprite;
        iconeInteligenciasMultiplas.sprite = EstadoDoJogo.Instance.Inteligencias.sprite;

        string fase;

        if (EstadoDoJogo.Instance.FaseAtual == 0)
            fase = "primeira";
        else if (EstadoDoJogo.Instance.FaseAtual == 1)
            fase = "segunda";
        else
            fase = "terceira";

        if (EstadoDoJogo.Instance.Tema != null && EstadoDoJogo.Instance.Tema != "")
            tema.text = $"Este é o tema da sua <b>{fase}</b> aula:\n<color=#b45f06><b>{EstadoDoJogo.Instance.Tema}</b>";
        else
            tema.text = "";

        string preposition = EstadoDoJogo.Instance.NivelDeEnsino == NivelDeEnsino.EducacaoInfantil ? "da" : "do";

        texto.text = $"Você irá jogar uma aula {preposition} {EstadoDoJogo.Instance.NivelDeEnsino.nome} " +
                     $"sobre {EstadoDoJogo.Instance.AreaDeConhecimento.nome} " +
                     $"com uma turma de perfil {EstadoDoJogo.Instance.Inteligencias.nome}.";
    }
}
