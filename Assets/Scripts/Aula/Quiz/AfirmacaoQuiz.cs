using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public abstract class AfirmacaoQuiz : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] Sprite spriteErrada;
    [SerializeField] Sprite spriteCorreta;

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

    public virtual void DefinirComoAcertoDoJogador() { GetComponent<Image>().sprite = spriteCorreta; }

    public virtual void DefinirComoErroDoJogador() { GetComponent<Image>().sprite = spriteErrada; }
}
