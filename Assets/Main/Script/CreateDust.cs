using UnityEngine;
using System.Collections;
using System;

public class CreateDust : MonoBehaviour
{
    public GameObject Dust;
    public int DeltaTime;

    DateTime SysTime;
    DateTime UpdatedTime;
    TimeSpan Delta;

    void Start()
    {
        SysTime = System.DateTime.Now;
        Delta = new TimeSpan(0, 0, DeltaTime);
        UpdatedTime = SysTime;
    }

    void Update()
    {
        SysTime = System.DateTime.Now;
        if (TimeOver())
        {
            Instantiate(Dust);
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
