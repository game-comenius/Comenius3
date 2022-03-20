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
        if (estadoDoJogo.NivelDeEnsino == NivelDeEnsino.EducacaoInfantil)
        {
            personagemDePe.SetActive(false);
            personagemSentado.SetActive(true);

            if (estadoDoJogo.SpriteCabeloPersonagemSentado) cabeloSentado.sprite = estadoDoJogo.SpriteCabeloPersonagemSentado;
            if (estadoDoJogo.SpriteCorpoPersonagemSentado) corpoSentado.sprite = estadoDoJogo.SpriteCorpoPersonagemSentado;
            if (estadoDoJogo.SpriteRoupaPersonagemSentado) roupaSentado.sprite = estadoDoJogo.SpriteRoupaPersonagemSentado;
        }
        else
        {
            personagemSentado.SetActive(false);
            personagemDePe.SetActive(true);

            if (estadoDoJogo.SpriteCorpoPersonagem) corpo.sprite = estadoDoJogo.SpriteCorpoPersonagem;
            if (estadoDoJogo.SpriteCabeloPersonagem) cabelo.sprite = estadoDoJogo.SpriteCabeloPersonagem;
            if (estadoDoJogo.SpriteRoupaPersonagem) roupa.sprite = estadoDoJogo.SpriteRoupaPersonagem;
        }

    }
}
