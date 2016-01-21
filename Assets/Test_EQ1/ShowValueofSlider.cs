using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowValueofSlider : MonoBehaviour
{
    public Slider slider;

    [SerializeField]
    private Text value = null;

    void Update()
    {
        value.text = slider.value.ToString();
    }
}
