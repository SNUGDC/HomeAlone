using UnityEngine;
using System.Collections;
using System;

public class TimeTestScript : MonoBehaviour
{
    DateTime StartSysTime;
    DateTime SysTime;

    void Start()
    {
        StartSysTime = System.DateTime.Now;
    }

    void Update()
    {
        SysTime = System.DateTime.Now;
        Debug.Log(SysTime);
        Debug.Log(SysTime - StartSysTime);
    }
    
}
