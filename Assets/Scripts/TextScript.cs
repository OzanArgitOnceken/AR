using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public Slider rotationSlider;
    public TMP_Text rotationText;

    private void Start()
    {
        rotationText.text = "0";

        // Slider'�n de�er de�i�imini dinleyece�iz ve de�er de�i�ti�inde OnSliderValueChanged metodunu �a��raca��z.
        rotationSlider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    private void OnSliderValueChanged(float arg0)
    {
        rotationText.text = arg0.ToString(".0");
    }
}
