using UnityEngine;
using System.Collections;
using System;

public class DirtyTimer : MonoBehaviour
{
    public int DeltaTime;
    public int DirtyGauge = 0;
    public int DirtyGaugeMax = 10;
    public string VariableName;

    DateTime SysTime;
    DateTime UpdatedTime;
    TimeSpan Delta;

    void Start()
    {
        Delta = new TimeSpan(0, 0, DeltaTime);
        UpdatedTime = SysTime;
        Load();
    }

    void Update()
    {
        SysTime = System.DateTime.Now;
        IncreaseValue();
        Load();
    }

    void IncreaseValue()
    {
        if (DirtyGauge < DirtyGaugeMax && TimeOver())
        {
            DirtyGauge = DirtyGauge + 1;
            UpdatedTime = SysTime;
            Save();
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

    void Save()
    {
        PlayerPrefs.SetInt(VariableName, DirtyGauge);
    }

    void Load()
    {
        DirtyGauge = PlayerPrefs.GetInt(VariableName);
    }
}
