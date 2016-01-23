using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class DirtyTimer : MonoBehaviour
{
    public int DeltaTime;

    Slider slider;
    DateTime SysTime;
    DateTime UpdatedTime;
    TimeSpan Delta;

    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = 0;
        Delta = new TimeSpan(0, 0, DeltaTime);
    }

    void Update()
    {
        SysTime = System.DateTime.Now;
        IncreaseValue();
    }

    void IncreaseValue()
    {
        if (slider.value < slider.maxValue && TimeOver())
        {
            slider.value = slider.value + 1;
            UpdatedTime = SysTime;
        }
    }

    bool TimeOver()
    {
        if (SysTime - UpdatedTime >= Delta)
        {
            return true;
        }
        else return false;
    }
}
