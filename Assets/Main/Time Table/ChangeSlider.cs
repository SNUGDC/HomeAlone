using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeSlider : MonoBehaviour
{
    public int front;
    public int back;

    private Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
    }

    void Update()
    {
        front = (int)slider.value;
        back = (int)(slider.maxValue - slider.value);

        if (back == 0)
        {

        }
    }
}
