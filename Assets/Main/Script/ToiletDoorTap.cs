using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;


public class ToiletDoorTap : MonoBehaviour
{
    public static bool IsSuccess;
    public GameObject button;

    bool Haskey;
    DateTime SysTime;
    DateTime UpdatedTime;

    void Start()
    {
        UpdatedTime = DateTime.Now;
    }

    void Update()
    {
        GetComponent<Slider>().value -= 1;
        SysTime = DateTime.Now;

        if(SysTime - UpdatedTime > new TimeSpan(0, 0, 10))
        {
            if (GetComponent<Slider>().value > 800)
            {
                IsSuccess = true;
            }
            else IsSuccess = false;

            PenguinEventText.ClickedTime_PenguinEvent = 12;
            button.SetActive(true);
        }
    }

    public void DoorTap()
    {
        GetComponent<Slider>().value += 20;
    }
}