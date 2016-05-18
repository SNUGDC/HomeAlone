using UnityEngine;
using System.Collections;
using System;

public class AdsTimer : MonoBehaviour
{
    DateTime NowTime;
    DateTime StartTime;
    TimeSpan DeltaTime;
    bool TimerStart = false;

    void Update()
    {
        if (PlayerPrefs.GetString("Ads") == "On")
            Debug.Log("On");
        else Debug.Log(PlayerPrefs.GetInt("AdsTimer"));

        if (PlayerPrefs.GetString("Ads") == "Off" && TimerStart == false)
        {
            StartTime = DateTime.Now;
            TimerStart = true;
        }
        else if (PlayerPrefs.GetString("Ads") == "Off" && TimerStart == true)
        {
            NowTime = DateTime.Now;
            DeltaTime = NowTime - StartTime;
            if(DeltaTime.Minutes > 0)
            {
                PlayerPrefs.SetInt("AdsTimer", PlayerPrefs.GetInt("AdsTimer") + DeltaTime.Minutes);
                StartTime = DateTime.Now;
            }
        }

        if (PlayerPrefs.GetInt("AdsTimer") > 2)
        {
            PlayerPrefs.SetString("Ads", "On");
            TimerStart = false;
        }
        else
        {
            PlayerPrefs.SetString("Ads", "Off");
        }
    }
}
