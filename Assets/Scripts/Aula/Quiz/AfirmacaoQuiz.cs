using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public abstract class AfirmacaoQuiz : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] Sprite spriteErrada;
    [SerializeField] Sprite spriteCorreta;
    [SerializeField] Text marcacaoResposta;

    [SerializeField] Text textoAfirmacao;

    private Afirmacao afirmacao;
    public Afirmacao Afirmacao
    {
        get { return afirmacao; }
        set
        {
            afirmacao = value;
            Texto = afirmacao.Texto;
        }
    }

    public string Texto
    {
        get { return textoAfirmacao.text; }
        set { textoAfirmacao.text = value; }
    }


    public abstract void OnPointerClick(PointerEventData eventData);

    public virtual void DefinirComoAcertoDoJogador()
    {
        GetComponent<Image>().sprite = spriteCorreta;
        MostrarResposta();
    }

    public virtual void DefinirComoErroDoJogador()
    {
        GetComponent<Image>().sprite = spriteErrada;
        MostrarResposta();
    }
    protected virtual void MostrarResposta()
    {
        if(marcacaoResposta != null)
        {
            if(Afirmacao.Verdadeira)
            {
                marcacaoResposta.enabled = true;
                marcacaoResposta.color = new Color(0,1,0,0.5f);
                marcacaoResposta.text = "V";
            } else
            {
                marcacaoResposta.enabled = true;
                marcacaoResposta.color = new Color(1, 0, 0, 0.5f);
                marcacaoResposta.text = "X";
            }
        }
    }
}
