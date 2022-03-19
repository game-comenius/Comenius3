using UnityEngine;

public class Personagem : MonoBehaviour
{
    [SerializeField] private SpriteRenderer corpo;
    [SerializeField] private SpriteRenderer cabelo;
    [SerializeField] private SpriteRenderer roupa;
    [SerializeField] private SpriteRenderer corpoSentado;
    [SerializeField] private SpriteRenderer cabeloSentado;
    [SerializeField] private SpriteRenderer roupaSentado;
    [SerializeField] private GameObject personagemDePe;
    [SerializeField] private GameObject personagemSentado;

    void Start()
    {
        var estadoDoJogo = EstadoDoJogo.Instance;

        // Checando o Nível de Ensino para saber se o sprite deve ser sentado ou em pé.
        if (estadoDoJogo.NivelDeEnsinoSelecionado == NivelDeEnsino.EducacaoInfantil)
        {
            personagemDePe.SetActive(false);
            personagemSentado.SetActive(true);

            if (estadoDoJogo.spriteCabeloPersonagemSentado) cabeloSentado.sprite = estadoDoJogo.spriteCabeloPersonagemSentado;
            if (estadoDoJogo.spriteCorpoPersonagemSentado) corpoSentado.sprite = estadoDoJogo.spriteCorpoPersonagemSentado;
            if (estadoDoJogo.spriteRoupaPersonagemSentado) roupaSentado.sprite = estadoDoJogo.spriteRoupaPersonagemSentado;
        }
        else
        {
            personagemSentado.SetActive(false);
            personagemDePe.SetActive(true);

            if (estadoDoJogo.spriteCorpoPersonagem) corpo.sprite = estadoDoJogo.spriteCorpoPersonagem;
            if (estadoDoJogo.spriteCabeloPersonagem) cabelo.sprite = estadoDoJogo.spriteCabeloPersonagem;
            if (estadoDoJogo.spriteRoupaPersonagem) roupa.sprite = estadoDoJogo.spriteRoupaPersonagem;
        }

    }
}
