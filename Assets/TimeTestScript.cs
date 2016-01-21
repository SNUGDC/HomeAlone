using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class TimeTestScript : MonoBehaviour
{
    public Slider slider;
    public int DeltaTime;

    DateTime SysTime;
    DateTime UpdatedTime;
    TimeSpan Delta;

    void Start()
    {
        Delta = new TimeSpan(0, 0, DeltaTime);
    }

    void Update()
    {
        SysTime = System.DateTime.Now;
        IncreaseValue();
        TimeOver();
    }

    void IncreaseValue()
    {
        if (slider.value != 10 && TimeOver())
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
