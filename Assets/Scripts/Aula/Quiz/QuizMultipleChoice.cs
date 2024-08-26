using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class QuizMultipleChoice : QuizBase
{
    [SerializeField] private List<AffirmationMultipleChoice> affirmations;
    [SerializeField] private List<string> correctAnswers;
    [SerializeField] private List<string> correctPtbr;
    [SerializeField] private List<string> correctEua;
    [SerializeField] private List<string> correctEsp;
    [SerializeField] private List<string> wrongAnswers;
    [SerializeField] private List<string> wrongAnswersPtbr;
    [SerializeField] private List<string> wrongAnswersEua;
    [SerializeField] private List<string> wrongAnswersEsp;
    [SerializeField] private int abpScore;
    [SerializeField] private int saiScore;
    [SerializeField] private int abprojScore;
    [SerializeField] private bool inverted;
    public AudioSource audioSourceVitoria;
    public AudioSource audioSourceDerrota;
    public ParticleSystem particulaWin;
    private bool acertei;
    private int scoreOnRightAnswer;
    private int selectedAffirmationIndex;

    private void OnEnable()
    {
        audioSourceVitoria = GameObject.Find("AudiosourceAcerto").GetComponent<AudioSource>();
        audioSourceDerrota = GameObject.Find("AudiosourceDerrota").GetComponent<AudioSource>();
        particulaWin = GameObject.Find("ParticulaConfete").GetComponent<ParticleSystem>();
    }
    public void NotifySelection(AffirmationMultipleChoice affirmation)
    {
        if (selectedAffirmationIndex >= 0 && affirmations.IndexOf(affirmation) != selectedAffirmationIndex)
            affirmations[selectedAffirmationIndex].Selection();

        if (affirmations.IndexOf(affirmation) != selectedAffirmationIndex)
            selectedAffirmationIndex = affirmations.IndexOf(affirmation);
        else
            selectedAffirmationIndex = -1;
    }

    protected override void BuildQuiz()
    {
        base.BuildQuiz();

        selectedAffirmationIndex = -1;
        int correctAnswerIndex = Random.Range(0, maxAffirmations);

        var ABP = Metodologia.ABP.nome;
        var ABPJ = Metodologia.ABProj.nome;
        var SAI = Metodologia.SAI.nome;

        if (EstadoDoJogo.Instance.Metodologia.nome == ABP)
        {
            scoreOnRightAnswer = abpScore;
        }
        else if (EstadoDoJogo.Instance.Metodologia.nome == ABPJ)
        {
            scoreOnRightAnswer = abprojScore;
        }
        else if (EstadoDoJogo.Instance.Metodologia.nome == SAI)
        {
            scoreOnRightAnswer = saiScore;
        }



        for (int i = 0; i < maxAffirmations; i++)
        {
            if (i == correctAnswerIndex)
            {

                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas.INGLES:
                        affirmations[i].text.text = inverted ? wrongAnswersEua[Random.Range(0, wrongAnswersEua.Count)] :
                             correctEua[Random.Range(0, correctEua.Count)];
                        affirmations[i].correct = !inverted;
                        break;
                    case Idiomas.PORTUGUES:
                        affirmations[i].text.text = inverted ? wrongAnswersPtbr[Random.Range(0, wrongAnswersPtbr.Count)] :
                                            correctPtbr[Random.Range(0, correctPtbr.Count)];
                        affirmations[i].correct = !inverted;
                        break;
                    case Idiomas.ESPANHOL:
                        affirmations[i].text.text = inverted ? wrongAnswersEsp[Random.Range(0, wrongAnswersEsp.Count)] :
                        correctEsp[Random.Range(0, correctEua.Count)];
                        affirmations[i].correct = !inverted;
                        break;
                    default:
                        break;
                }


            }
            else
            {

                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas.INGLES:
                        affirmations[i].text.text = inverted ? correctEua[Random.Range(0, correctEua.Count)] :
                                                          wrongAnswersEua[Random.Range(0, wrongAnswersEua.Count)];
                        affirmations[i].correct = inverted;
                        break;
                    case Idiomas.PORTUGUES:
                        affirmations[i].text.text = inverted ? correctPtbr[Random.Range(0, correctPtbr.Count)] :
                                                          wrongAnswersPtbr[Random.Range(0, wrongAnswersPtbr.Count)];
                        affirmations[i].correct = inverted;
                        break;
                    case Idiomas.ESPANHOL:
                        affirmations[i].text.text = inverted ? correctEsp[Random.Range(0, correctEsp.Count)] :
                                                  wrongAnswersEsp[Random.Range(0, wrongAnswersEsp.Count)];
                        affirmations[i].correct = inverted;
                        break;
                    default:
                        break;
                }
       

                if (inverted)
                {

                    switch (Textos.GetIdiomaSelecionado())
                    {
                        case Idiomas.INGLES:
                            correctEua.Remove(affirmations[i].text.text);
                            break;
                        case Idiomas.PORTUGUES:
                            correctPtbr.Remove(affirmations[i].text.text);
                            break;
                        case Idiomas.ESPANHOL:
                            correctEsp.Remove(affirmations[i].text.text);
                            break;
                        default:
                            break;
                    }
               
                }

                else
                {
                    switch (Textos.GetIdiomaSelecionado())
                    {
                        case Idiomas.INGLES:
                            wrongAnswersEua.Remove(affirmations[i].text.text);
                            break;
                        case Idiomas.PORTUGUES:
                            wrongAnswersPtbr.Remove(affirmations[i].text.text);
                            break;
                        case Idiomas.ESPANHOL:
                            wrongAnswersEsp.Remove(affirmations[i].text.text);
                            break;
                        default:
                            break;
                    }
                }
   
            }
        }
    }

    protected override void Evaluate()
    {
        score = 0;

        for (int i = 0; i < maxAffirmations; i++)
        {
            affirmations[i].GetComponent<Button>().interactable = false;

            if (affirmations[i].correct)
                affirmations[i].UpdateResultColor(true);
            else
                affirmations[i].UpdateResultColor(false);

            if (affirmations[i].selected && affirmations[i].correct == !inverted) {
                score = scoreOnRightAnswer;
               UnityEngine.Debug.Log("correto");
                acertei = true;
                audioSourceVitoria.Play();
                particulaWin.Play();
            }
        }
        if(!acertei)
        audioSourceDerrota.Play();

        acertei = false;
           quizEvaluated = true;
    }
}
