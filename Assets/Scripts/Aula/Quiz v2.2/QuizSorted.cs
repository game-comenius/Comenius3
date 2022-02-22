using System.Collections.Generic;
using UnityEngine;

public class QuizSorted : QuizBase
{
    [SerializeReference] private List<AffirmationSorted> affirmations;
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
        RectTransform targetPositionAffirmationRect;

        if (affirmationRect.anchoredPosition.y > affirmation.lockedPosition.y && oldIndex > 0)
        {
            targetPositionAffirmationRect = affirmations[oldIndex - 1].GetComponent<RectTransform>();

            affirmationRect.anchoredPosition = targetPositionAffirmationRect.anchoredPosition;
            affirmation.lockedPosition = affirmationRect.anchoredPosition;
            targetPositionAffirmationRect.anchoredPosition = affirmationsPositions[oldIndex];
            affirmations[oldIndex - 1].lockedPosition = targetPositionAffirmationRect.anchoredPosition;

            affirmations.Remove(affirmation);
            affirmations.Insert(oldIndex - 1, affirmation);
        }
        else if (oldIndex < maxAffirmations - 1)
        {
            targetPositionAffirmationRect = affirmations[oldIndex + 1].GetComponent<RectTransform>();

            affirmationRect.anchoredPosition = targetPositionAffirmationRect.anchoredPosition;
            affirmation.lockedPosition = affirmationRect.anchoredPosition;
            targetPositionAffirmationRect.anchoredPosition = affirmationsPositions[oldIndex];
            affirmations[oldIndex + 1].lockedPosition = targetPositionAffirmationRect.anchoredPosition;

            affirmations.Remove(affirmation);
            affirmations.Insert(oldIndex + 1, affirmation);
        }
        else
        {
            affirmationRect.anchoredPosition = affirmation.lockedPosition;
        }
    }

    protected override void BuildQuiz()
    {
        affirmationsPositions = new List<Vector2>();
        List<string> answers = new List<string>(sortedAnswers);

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
    }
}
