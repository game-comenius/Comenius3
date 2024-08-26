using System.Collections.Generic;
using UnityEngine;

public class QuizSorted : QuizBase
{
    public Canvas canvas;
    [SerializeField] private List<AffirmationSorted> affirmations;
    [SerializeField] private List<Draggable> draggables;
    [SerializeField] private List<string> sortedAnswers;
    [SerializeField] private List<string> sortedAnswersPtbr;
    [SerializeField] private List<string> sortedAnswersEua;
    [SerializeField] private List<string> sortedAnswersEsp;

    [SerializeField] private int abpUpperScore;
    [SerializeField] private int abpMiddleScore;
    [SerializeField] private int abpLowerScore;
    [SerializeField] private int saiUpperScore;
    [SerializeField] private int saiMiddleScore;
    [SerializeField] private int saiLowerScore;
    [SerializeField] private int abprojUpperScore;
    [SerializeField] private int abprojMiddleScore;
    [SerializeField] private int abprojLowerScore;

    private int upperScore;
    private int middleScore;
    private int lowerScore;
    private List<Vector2> affirmationsPositions;
    List<string> answers;
    public void NotifyDrag(AffirmationSorted affirmation)
    {
        int oldIndex = affirmations.IndexOf(affirmation);

        RectTransform affirmationRect = affirmation.GetComponent<RectTransform>();

        for (int i = 0; i < affirmations.Count; ++i)
        {
            if (affirmationRect.anchoredPosition.y > affirmationsPositions[i].y)
            {
                if (oldIndex != i)
                {
                    affirmations.Remove(affirmation);
                    affirmations.Insert(i, affirmation);

                    int startIndex = i < oldIndex ? i : oldIndex;

                    for (int j = startIndex; j < affirmations.Count; j++)
                    {
                        RectTransform modifiedAffirmationRect = affirmations[j].GetComponent<RectTransform>();

                        modifiedAffirmationRect.anchoredPosition = affirmationsPositions[j];
                        affirmations[j].lockedPosition = modifiedAffirmationRect.anchoredPosition;
                    }
                }
                else
                {
                    affirmationRect.anchoredPosition = affirmation.lockedPosition;
                }

                return;
            }
        }

        affirmationRect.anchoredPosition = affirmation.lockedPosition;
    }

    protected override void BuildQuiz()
    {
        base.BuildQuiz();

        affirmationsPositions = new List<Vector2>();

 
        switch (Textos.GetIdiomaSelecionado())
        {
            case Idiomas.INGLES:
                answers = new List<string>(sortedAnswersEua);
                break;
            case Idiomas.PORTUGUES:
                answers = new List<string>(sortedAnswersPtbr);
                break;
            case Idiomas.ESPANHOL:
                answers = new List<string>(sortedAnswersEsp);
                break;
            default:
                break;
        }

        var ABP = Metodologia.ABP.nome;
        var ABPJ = Metodologia.ABProj.nome;
        var SAI = Metodologia.SAI.nome;

        if(EstadoDoJogo.Instance.Metodologia.nome == ABP)
        {
            upperScore = abpUpperScore;
            middleScore = abpMiddleScore;
            lowerScore = abpLowerScore;
        }
        else if (EstadoDoJogo.Instance.Metodologia.nome == ABPJ)
        {
            upperScore = abprojUpperScore;
            middleScore = abprojMiddleScore;
            lowerScore = abprojLowerScore;
        }
        else if (EstadoDoJogo.Instance.Metodologia.nome == SAI)
        {
            upperScore = saiUpperScore;
            middleScore = saiMiddleScore;
            lowerScore = saiLowerScore;
        }
        for (int i = 0; i < draggables.Count; i++)
        {
            draggables[i].canvas = canvas;
        }

        for (int i = 0; i < affirmations.Count; i++)
        {
            if (i < maxAffirmations)
            {
                affirmations[i].text.text = answers[Random.Range(0, answers.Count)];
                affirmations[i].correctPosition = sortedAnswers.IndexOf(affirmations[i].text.text);
                answers.Remove(affirmations[i].text.text);
                affirmationsPositions.Add(affirmations[i].GetComponent<RectTransform>().anchoredPosition);


                switch (Textos.GetIdiomaSelecionado())
                {
                    case Idiomas.INGLES:
                        affirmations[i].text.text = answers[Random.Range(0, answers.Count)];
                        affirmations[i].correctPosition = sortedAnswersEua.IndexOf(affirmations[i].text.text);
                        sortedAnswersEua.Remove(affirmations[i].text.text);
                        affirmationsPositions.Add(affirmations[i].GetComponent<RectTransform>().anchoredPosition);
                        break;
                    case Idiomas.PORTUGUES:
                        affirmations[i].text.text = answers[Random.Range(0, answers.Count)];
                        affirmations[i].correctPosition = sortedAnswersPtbr.IndexOf(affirmations[i].text.text);
                        sortedAnswersPtbr.Remove(affirmations[i].text.text);
                        affirmationsPositions.Add(affirmations[i].GetComponent<RectTransform>().anchoredPosition);
                        break;
                    case Idiomas.ESPANHOL:
                        affirmations[i].text.text = answers[Random.Range(0, answers.Count)];
                        affirmations[i].correctPosition = sortedAnswersEua.IndexOf(affirmations[i].text.text);
                        sortedAnswersEsp.Remove(affirmations[i].text.text);
                        affirmationsPositions.Add(affirmations[i].GetComponent<RectTransform>().anchoredPosition);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                AffirmationSorted affirmation = affirmations[i];

                affirmations.Remove(affirmation);
                Destroy(affirmation.gameObject);
            }
        }
    }

    protected override void Evaluate()
    {
        score = 0;
        int correctAnswers = 0;

        for (int i = 0; i < maxAffirmations; i++)
        {
            affirmations[i].GetComponent<Draggable>().enabled = false;

            if (i == affirmations[i].correctPosition)
            {
                correctAnswers++;

                affirmations[i].UpdateResultColor(true);
            }
            else
            {
                affirmations[i].UpdateResultColor(false);
            }

            affirmations[i].ShowCorrectPosition();
        }

        if (correctAnswers > 2)
            score = upperScore;
        else if (correctAnswers == 2)
            score = middleScore;
        else
            score = lowerScore;

        quizEvaluated = true;
    }
}
