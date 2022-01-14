using System.Collections.Generic;
using UnityEngine;

public class AnimacaoRolagem : MonoBehaviour
{
    [SerializeField] private GameObject[] items;
    [SerializeField] private float speedCoeff;

    private float speed;
    private Vector2[] initialPositions;
    private List<int> activeIndexes;
    private RectTransform rect;
    private Vector3[] itemCorners;
    private Vector3[] corners;

    private void Start()
    {
        speed = Screen.height * speedCoeff;
        initialPositions = new Vector2[items.Length];
        activeIndexes = new List<int>();
        rect = GetComponent<RectTransform>();
        itemCorners = new Vector3[4];
        corners = new Vector3[4];

        for (int i = 0; i < items.Length; ++i)
        {
            initialPositions[i] = items[i].GetComponent<RectTransform>().anchoredPosition;
        }

        activeIndexes.Add(0);
    }

    void Update()
    {
        for (int i = 0; i < activeIndexes.Count; ++i)
        {
            RectTransform itemRect;

            items[activeIndexes[i]].transform.Translate(Vector3.up * Time.deltaTime * speed);

            itemRect = items[activeIndexes[activeIndexes.Count - 1]].GetComponent<RectTransform>();

            itemRect.GetWorldCorners(itemCorners);
            rect.GetWorldCorners(corners);

            if (itemCorners[0].y > corners[0].y)
            {
                int nextIndex = activeIndexes[activeIndexes.Count - 1] + 1;

                if (nextIndex == items.Length)
                {
                    nextIndex = 0;
                }

                activeIndexes.Add(nextIndex);
            }

            itemRect = items[activeIndexes[0]].GetComponent<RectTransform>();
            itemRect.GetWorldCorners(itemCorners);

            if (itemCorners[0].y > corners[1].y)
            {
                itemRect.anchoredPosition = initialPositions[activeIndexes[i]];
                activeIndexes.RemoveAt(0);
            }
        }
    }
}
