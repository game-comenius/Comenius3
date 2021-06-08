using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ControladorDeCorDeBarra : MonoBehaviour
{
    public AnimationCurve redCurve;
    public AnimationCurve greenCurve;

    public Image image;

    public void UpdateColor(float value)
    {
        image.color = new Color(redCurve.Evaluate(value), greenCurve.Evaluate(value), 0);
    }
}
