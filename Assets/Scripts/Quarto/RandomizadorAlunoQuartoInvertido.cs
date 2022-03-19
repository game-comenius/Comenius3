using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomizadorAlunoQuartoInvertido : MonoBehaviour
{
    [SerializeField] Sprite corpoAluno1;
    [SerializeField] Sprite corpoAluno2;
    [SerializeField] Sprite corpoAluno3;
    [SerializeField] Sprite corpoAluno4;

    [SerializeField] Sprite cabeloAluno1;
    [SerializeField] Sprite cabeloAluno2;
    [SerializeField] Sprite cabeloAluno3;
    [SerializeField] Sprite cabeloAluno4;

    [Header("Rostos")]
    [SerializeField] Sprite rostoFeliz1;
    [SerializeField] Sprite rostoFeliz2;
    [SerializeField] Sprite rostoFeliz3;
    [SerializeField] Sprite rostoFeliz4;

    [SerializeField] Sprite rostoTriste1;
    [SerializeField] Sprite rostoTriste2;
    [SerializeField] Sprite rostoTriste3;
    [SerializeField] Sprite rostoTriste4;

    [Header("SpriteRenderer dos alunos")]
    [SerializeField] SpriteRenderer corpoInfantil;
    [SerializeField] SpriteRenderer corpoFundamental;
    [SerializeField] SpriteRenderer corpoMedio;
    [SerializeField] SpriteRenderer corpoSuperior;

    [SerializeField] SpriteRenderer cabeloInfantil;
    [SerializeField] SpriteRenderer cabeloFundamental;
    [SerializeField] SpriteRenderer cabeloMedio;
    [SerializeField] SpriteRenderer cabeloSuperior;

    [Header("Image do aluno no feedback")]
    [SerializeField] Image retratoFeedbackFeliz;
    [SerializeField] Image retratoFeedbackTriste;

    // Start is called before the first frame update
    void Start()
    {
        int alunoIndex = Random.Range(1, 5);
        var estadoDoJogo = EstadoDoJogo.Instance;

        if (estadoDoJogo.NivelDeEnsinoSelecionado.nome != "Educação Infantil") {

            switch(alunoIndex)
            {

                case 1:
                    corpoFundamental.sprite = corpoAluno1;
                    corpoMedio.sprite = corpoAluno1;
                    corpoSuperior.sprite = corpoAluno1;
                    cabeloFundamental.sprite = cabeloAluno1;
                    cabeloMedio.sprite = cabeloAluno1;
                    cabeloSuperior.sprite = cabeloAluno1;

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

                    retratoFeedbackFeliz.sprite = rostoFeliz4;
                    retratoFeedbackTriste.sprite = rostoTriste4;
                    break;

            }

        }


    }

}
