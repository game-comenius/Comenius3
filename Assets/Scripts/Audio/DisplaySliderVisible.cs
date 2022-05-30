using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplaySliderVisible : MonoBehaviour
{

    public DisplaySlider displaySliderButton;
    public DisplaySlider displaySliderSlider;
    public DisplaySlider displaySliderBackground;
    public DisplaySlider displaySliderFill;
    public DisplaySlider displaySliderHandle;
    public GameObject sliderObject;

    // Update is called once per frame
    void Update()
    {
        if (displaySliderButton.highLighted || displaySliderSlider.highLighted || displaySliderBackground.highLighted || displaySliderFill.highLighted || displaySliderHandle.highLighted) {
            sliderObject.SetActive(true);
        } else {
            sliderObject.SetActive(false);
        }
    }
}
