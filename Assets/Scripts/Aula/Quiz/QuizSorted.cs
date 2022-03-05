using System.Collections.Generic;
using UnityEngine;

public class QuizSorted : QuizBase
{
    public Canvas canvas;
    [SerializeField] private List<AffirmationSorted> affirmations;
    [SerializeField] private List<Draggable> draggables;
    [SerializeField] private List<string> sortedAnswers;

    [Header("Pontuação com mais de dois acertos")]
    [SerializeField] private int upperScore;

    [Header("Pontuação com dois acertos")]
    [SerializeField] private int middleScore;

    [Header("Pontuação com menos de dois acertos")]
    [SerializeField] private int lowerScore;

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
