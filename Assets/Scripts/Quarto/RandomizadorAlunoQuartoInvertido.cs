using UnityEngine;
using UnityEngine.UI;

public class RandomizadorAlunoQuartoInvertido : MonoBehaviour
{
    [SerializeField] private Sprite corpoAluno1;
    [SerializeField] private Sprite corpoAluno2;
    [SerializeField] private Sprite corpoAluno3;
    [SerializeField] private Sprite corpoAluno4;

    [SerializeField] private Sprite cabeloAluno1;
    [SerializeField] private Sprite cabeloAluno2;
    [SerializeField] private Sprite cabeloAluno3;
    [SerializeField] private Sprite cabeloAluno4;

    [Header("Rostos")]
    [SerializeField] private Sprite rostoFeliz1;
    [SerializeField] private Sprite rostoFeliz2;
    [SerializeField] private Sprite rostoFeliz3;
    [SerializeField] private Sprite rostoFeliz4;

    [SerializeField] private Sprite rostoTriste1;
    [SerializeField] private Sprite rostoTriste2;
    [SerializeField] private Sprite rostoTriste3;
    [SerializeField] private Sprite rostoTriste4;

    [Header("SpriteRenderer dos alunos")]
    [SerializeField] private SpriteRenderer corpoFundamental;
    [SerializeField] private SpriteRenderer corpoMedio;
    [SerializeField] private SpriteRenderer corpoSuperior;

    [SerializeField] private SpriteRenderer cabeloFundamental;
    [SerializeField] private SpriteRenderer cabeloMedio;
    [SerializeField] private SpriteRenderer cabeloSuperior;

    [Header("Retratos do aluno")]
    [SerializeField] private Image retratoIntroducao;
    [SerializeField] private Image retratoFeedbackFeliz;
    [SerializeField] private Image retratoFeedbackTriste;

    // Start is called before the first frame update
    void Start()
    {
        int alunoIndex = Random.Range(1, 5);
        var estadoDoJogo = EstadoDoJogo.Instance;

        if (estadoDoJogo.NivelDeEnsino.nome != "Educação Infantil")
        {
            switch (alunoIndex)
            {
                case 1:
                    corpoFundamental.sprite = corpoAluno1;
                    corpoMedio.sprite = corpoAluno1;
                    corpoSuperior.sprite = corpoAluno1;
                    cabeloFundamental.sprite = cabeloAluno1;
                    cabeloMedio.sprite = cabeloAluno1;
                    cabeloSuperior.sprite = cabeloAluno1;

                    retratoIntroducao.sprite = rostoFeliz1;
                    retratoFeedbackFeliz.sprite = rostoFeliz1;
                    retratoFeedbackTriste.sprite = rostoTriste1;
                    break;
                case 2:
                    corpoFundamental.sprite = corpoAluno2;
                    corpoMedio.sprite = corpoAluno2;
                    corpoSuperior.sprite = corpoAluno2;
                    cabeloFundamental.sprite = cabeloAluno2;
                    cabeloMedio.sprite = cabeloAluno2;
                    cabeloSuperior.sprite = cabeloAluno2;

                    retratoIntroducao.sprite = rostoFeliz2;
                    retratoFeedbackFeliz.sprite = rostoFeliz2;
                    retratoFeedbackTriste.sprite = rostoTriste2;
                    break;
                case 3:
                    corpoFundamental.sprite = corpoAluno3;
                    corpoMedio.sprite = corpoAluno3;
                    corpoSuperior.sprite = corpoAluno3;
                    cabeloFundamental.sprite = cabeloAluno3;
                    cabeloMedio.sprite = cabeloAluno3;
                    cabeloSuperior.sprite = cabeloAluno3;

                    retratoIntroducao.sprite = rostoFeliz3;
                    retratoFeedbackFeliz.sprite = rostoFeliz3;
                    retratoFeedbackTriste.sprite = rostoTriste3;
                    break;
                case 4:
                    corpoFundamental.sprite = corpoAluno4;
                    corpoMedio.sprite = corpoAluno4;
                    corpoSuperior.sprite = corpoAluno4;
                    cabeloFundamental.sprite = cabeloAluno4;
                    cabeloMedio.sprite = cabeloAluno4;
                    cabeloSuperior.sprite = cabeloAluno4;

                    retratoIntroducao.sprite = rostoFeliz4;
                    retratoFeedbackFeliz.sprite = rostoFeliz4;
                    retratoFeedbackTriste.sprite = rostoTriste4;
                    break;
            }
        }
    }
}
