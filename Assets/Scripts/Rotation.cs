using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    [SerializeField] private Slider rotationSlider;



    // Start is called before the first frame update
    void Start()
    {
        rotationSlider.minValue = 0;
        rotationSlider.maxValue = 360;

        rotationSlider.onValueChanged.AddListener(RotateSliderUpdate);
    }

    private void RotateSliderUpdate(float arg0)
    {
        transform.localEulerAngles = new Vector3(transform.rotation.x, arg0, transform.rotation.z);
    }
}
