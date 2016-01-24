using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadSliderValue : MonoBehaviour
{
    public string VariableName;

    private int Variable;
    private Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = Variable;
    }
    
    void Update()
    {
        Load();
        slider.value = Variable;
    }

    void Load()
    {
        Variable = PlayerPrefs.GetInt(VariableName);
    }
}
