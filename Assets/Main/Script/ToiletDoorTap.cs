using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;


public class ToiletDoorTap : MonoBehaviour
{
    bool Haskey;
    DateTime SysTime;
    DateTime UpdatedTime;

    void Update()
    {
        GetComponent<Slider>().value -= 1;
        SysTime = DateTime.Now;

        if (GetComponent<Slider>().value > 800)
        {
            if (Haskey) return;
            else
            {
                UpdatedTime = DateTime.Now;
                Haskey = true;
            }
        }
        else if (GetComponent<Slider>().value <= 800)
        {
            Haskey = false;
        }

        if (SysTime - UpdatedTime > new TimeSpan(0, 0, 5) && Haskey)
        {
            Debug.Log("Success!!");
        }
    }

    public void DoorTap()
    {
        GetComponent<Slider>().value += 20;
    }
}
