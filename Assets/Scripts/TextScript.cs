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

        // Slider'ýn deðer deðiþimini dinleyeceðiz ve deðer deðiþtiðinde OnSliderValueChanged metodunu çaðýracaðýz.
        rotationSlider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    private void OnSliderValueChanged(float arg0)
    {
        rotationText.text = arg0.ToString(".0");
    }
}
