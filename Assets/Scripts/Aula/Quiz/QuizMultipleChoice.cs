using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class QuizMultipleChoice : QuizBase
{
    [SerializeField] private List<AffirmationMultipleChoice> affirmations;
    [SerializeField] private List<string> correctAnswers;
    [SerializeField] private List<string> wrongAnswers;
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

        switch (EstadoDoJogo.Instance.Metodologia.nome)
        {
            case "Aprendizagem Baseada em Problemas":
                scoreOnRightAnswer = abpScore;
                break;
            case "Sala de Aula Invertida":
                scoreOnRightAnswer = saiScore;
                break;
            case "Aprendizagem Baseada em Projetos":
                scoreOnRightAnswer = abprojScore;
                break;
            default:
                UnityEngine.Debug.LogError("Metodologia não selecionada");
                break;
        }

        for (int i = 0; i < maxAffirmations; i++)
        {
            if (i == correctAnswerIndex)
            {
                affirmations[i].text.text = inverted ? wrongAnswers[Random.Range(0, wrongAnswers.Count)] :
                                                       correctAnswers[Random.Range(0, correctAnswers.Count)];
                affirmations[i].correct = !inverted;
            }
            else
            {
                affirmations[i].text.text = inverted ? correctAnswers[Random.Range(0, correctAnswers.Count)] :
                                                       wrongAnswers[Random.Range(0, wrongAnswers.Count)];
                affirmations[i].correct = inverted;

                if (inverted)
                {
                    
                    correctAnswers.Remove(affirmations[i].text.text);
                }
                
                else
                    wrongAnswers.Remove(affirmations[i].text.text);
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
