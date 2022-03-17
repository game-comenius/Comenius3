using System.Collections.Generic;
using UnityEngine;

public class QuizSorted : QuizBase
{
    public Canvas canvas;
    [SerializeField] private List<AffirmationSorted> affirmations;
    [SerializeField] private List<Draggable> draggables;
    [SerializeField] private List<string> sortedAnswers;
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
        questionText.text = question;
        affirmationsPositions = new List<Vector2>();
        List<string> answers = new List<string>(sortedAnswers);

        switch (EstadoDoJogo.Instance.MetodologiaSelecionada.nome)
        {
            case "Aprendizagem Baseada em Problemas":
                upperScore = abpUpperScore;
                middleScore = abpMiddleScore;
                lowerScore = abpLowerScore;
                break;
            case "Sala de Aula Invertida":
                upperScore = saiUpperScore;
                middleScore = saiMiddleScore;
                lowerScore = saiLowerScore;
                break;
            case "Aprendizagem Baseada em Projetos":
                upperScore = abprojUpperScore;
                middleScore = abprojMiddleScore;
                lowerScore = abprojLowerScore;
                break;
            default:
                Debug.LogError("Metodologia não selecionada");
                break;
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
