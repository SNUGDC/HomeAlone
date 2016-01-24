using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IntDataSaver : MonoBehaviour
{
    public string VariableName;

    private Slider slider;
    private int RemainCost;

    void Start()
    {
        slider = GetComponent<Slider>();
    }

    void Update()
    {
        slider.value = PlayerPrefs.GetInt(VariableName);
        Save();
    }

    void Save()
    {
        PlayerPrefs.SetInt(VariableName, RemainCost);
    }
}
