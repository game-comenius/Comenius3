using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public abstract class FormatoDeQuiz : MonoBehaviour
{
    [SerializeField] Text enunciado;

    public string TextoDoEnunciado
    {
        get { return enunciado.text; }
        set { enunciado.text = value; }
    }

    // Número float no intervalo [0, 1] (inclusive)
    public virtual float TaxaDeAcerto { get; protected set; }

    public Button BotaoConfirmar;

    public bool RespostaConfirmada { get; set; }

    public bool JogadorPediuParaFechar { get; set; }

    private void Awake() { Esconder(); }

    protected virtual void Start()
    {
        // Definir funcionalidade do botão confirmar
        BotaoConfirmar.onClick.AddListener(() =>
        {
            ConfirmarResposta();
            // Impedir que o jogador confirme mais de uma vez a resposta dele
            // A próxima vez que ele clicar no botão confirmar, será para encerrar o quiz
            BotaoConfirmar.onClick.RemoveAllListeners();
            BotaoConfirmar.onClick.AddListener(() => JogadorPediuParaFechar = true);
        });
    }

    public abstract void DefinirAfirmacoes(Afirmacao[] afirmacoes);

    protected abstract void ConfirmarResposta();

    public virtual void Esconder()
    {
        gameObject.SetActive(false);
    }

    public virtual void Mostrar()
    {
        gameObject.SetActive(true);
    }
}