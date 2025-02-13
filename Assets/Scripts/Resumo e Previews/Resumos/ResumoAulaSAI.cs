using System;
using UnityEngine;
using UnityEngine.UI;

public class ResumoAulaSAI : MonoBehaviour
{
    [Header("Ícones")]
    [SerializeField] private Image iconeNivel;
    [SerializeField] private Image iconeArea;
    [SerializeField] private Image iconeInteligencia;
    [SerializeField] private Image iconeMetodologia;
    [SerializeField] private Image iconeSalaMidia1;
    [SerializeField] private Image iconeSalaMidia2;
    [SerializeField] private Image iconeQuartoMidia1;
    [SerializeField] private Image iconeQuartoMidia2;

    [Header("Textos")]
    [SerializeField] private Text textoNivel;
    [SerializeField] private Text textoArea;
    [SerializeField] private Text textoInteligencia;
    [SerializeField] private Text textoMetodologia;
    [SerializeField] private Text textoSalaMidia1;
    [SerializeField] private Text textoSalaMidia2;
    [SerializeField] private Text textoQuartoMidia1;
    [SerializeField] private Text textoQuartoMidia2;
    [SerializeField] private Text textoAgrupamento1;
    [SerializeField] private Text textoAgrupamento2;
    [SerializeField] private Text textoTema;
    private void Start()
    {
        // Sprites
        iconeNivel.sprite = EstadoDoJogo.Instance.NivelDeEnsino.sprite;
        iconeArea.sprite = EstadoDoJogo.Instance.AreaDeConhecimento.sprite;
        iconeInteligencia.sprite = EstadoDoJogo.Instance.Inteligencias.sprite;
        iconeMetodologia.sprite = EstadoDoJogo.Instance.Metodologia.sprite;
        iconeSalaMidia1.sprite = EstadoDoJogo.Instance.Midias[2].sprite;
        iconeSalaMidia2.sprite = EstadoDoJogo.Instance.Midias[3].sprite;
        iconeQuartoMidia1.sprite = EstadoDoJogo.Instance.Midias[0].sprite;
        iconeQuartoMidia2.sprite = EstadoDoJogo.Instance.Midias[1].sprite;

        // Textos
        textoNivel.text = EstadoDoJogo.Instance.NivelDeEnsino.nome;
        textoArea.text = EstadoDoJogo.Instance.AreaDeConhecimento.nome;
        textoInteligencia.text = EstadoDoJogo.Instance.Inteligencias.nome;
        textoMetodologia.text = EstadoDoJogo.Instance.Metodologia.nome;
        textoSalaMidia1.text = EstadoDoJogo.Instance.Midias[2].nome;
        textoSalaMidia2.text = EstadoDoJogo.Instance.Midias[3].nome;
        textoQuartoMidia1.text = EstadoDoJogo.Instance.Midias[0].nome;
        textoQuartoMidia2.text = EstadoDoJogo.Instance.Midias[1].nome;

        Debug.Log(EstadoDoJogo.Instance.Midias[2].agrupamento.ToString());
        switch (EstadoDoJogo.Instance.Midias[2].agrupamento.ToString())
        {
            case "FormatoU":
                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas.INGLES:
                        textoAgrupamento1.text = "U Shape";
                        break;
                    case Idiomas.PORTUGUES:
                        textoAgrupamento1.text = "Formato U";
                        break;
                    case Idiomas.ESPANHOL:
                        textoAgrupamento1.text = "Forma de U";
                        break;
                    default:
                        break;
                }
                break;

            case "Individual":
                textoAgrupamento1.text = Textos.GetIdiomaSelecionado() switch
                {
                    Idiomas.INGLES => "Individual",
                    Idiomas.PORTUGUES => "Individual",
                    Idiomas.ESPANHOL => "Individual",
                    _ => textoAgrupamento1.text
                };
                break;

            case "Duplas":
                textoAgrupamento1.text = Textos.GetIdiomaSelecionado() switch
                {
                    Idiomas.INGLES => "Doubles and Trios",
                    Idiomas.PORTUGUES => "Duplas e Trios",
                    Idiomas.ESPANHOL => "Dobles y Tríos",
                    _ => textoAgrupamento1.text
                };
                break;

            case "GrandesGrupos":
                textoAgrupamento1.text = Textos.GetIdiomaSelecionado() switch
                {
                    Idiomas.INGLES => "Large Groups",
                    Idiomas.PORTUGUES => "Grandes Grupos",
                    Idiomas.ESPANHOL => "Grupos grandes",
                    _ => textoAgrupamento1.text
                };
                break;

        }

        switch (EstadoDoJogo.Instance.Midias[3].agrupamento.ToString())
        {
            case "FormatoU":
                textoAgrupamento2.text = Textos.GetIdiomaSelecionado() switch
                {
                    Idiomas.INGLES => "U Shape",
                    Idiomas.PORTUGUES => "Formato U",
                    Idiomas.ESPANHOL => "Forma de U",
                    _ => textoAgrupamento2.text
                };
                break;

            case "Individual":
                textoAgrupamento2.text = Textos.GetIdiomaSelecionado() switch
                {
                    Idiomas.INGLES => "Individual",
                    Idiomas.PORTUGUES => "Individual",
                    Idiomas.ESPANHOL => "Individual",
                    _ => textoAgrupamento2.text
                };
                break;

            case "Duplas":
                textoAgrupamento2.text = Textos.GetIdiomaSelecionado() switch
                {
                    Idiomas.INGLES => "Doubles and Trios",
                    Idiomas.PORTUGUES => "Duplas e Trios",
                    Idiomas.ESPANHOL => "Dobles y Tríos",
                    _ => textoAgrupamento2.text
                };
                break;

            case "GrandesGrupos":
                textoAgrupamento2.text = Textos.GetIdiomaSelecionado() switch
                {
                    Idiomas.INGLES => "Large Groups",
                    Idiomas.PORTUGUES => "Grandes Grupos",
                    Idiomas.ESPANHOL => "Grupos grandes",
                    _ => textoAgrupamento2.text
                };
                break;

        }
        Debug.Log(textoAgrupamento2.text);
        Debug.Log(textoAgrupamento1.text);
        textoTema.text = EstadoDoJogo.Instance.Tema;
    }
}
