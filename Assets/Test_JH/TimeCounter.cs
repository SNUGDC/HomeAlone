using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class TimeCounter : MonoBehaviour
{
    public Text TimerText;
    public float GameSec = 0;
    private string CurrentTime;
    Func<string> value;
    public int Month = 3, Day = 2, Hour = 0, Min = 0;
    public delegate void GetTime(int Time);
    public float TimeFasterValue;

    void Start ()
    {   
        //check the code is running well
        GameSec = Time.time;
        Month = PlayerPrefs.GetInt("Month");
        Day = PlayerPrefs.GetInt("Day");
        Hour = PlayerPrefs.GetInt("Hour");
        Min = PlayerPrefs.GetInt("Min");
    }

    void Update ()
    {
        GameSec += Time.deltaTime * TimeFasterValue;
        SetCurrentTime();
        ShowCurrentTime(() => CurrentTime);
        TimerText.text = value();
        Save();
    }
    
    public void ShowCurrentTime(Func<String> value)
    {
        this.value = value;
    }

    public void SetCurrentTime()
    {
        SetMonthandDay();
        SetHourandMin();
        CurrentTime = "Month : " + Month + "  Day : " + Day + "  Time :" + Hour + ":" + Min;
    }

    public void SetMonthandDay()
    {
        if (Month < 8 && Month % 2 != 0)
        {
            MonthWith31Days();
        }
        else if (Month < 8 && Month % 2 == 0)
        {
            MonthWith30Days();
        }
        else if (Month % 2 != 0)
        {
            MonthWith30Days();
        }
        else
        {
            MonthWith31Days();
        }
        if (Month > 12)
            Month = 1;
    }

    public void SetHourandMin()
    {
        float Sec = GameSec;

        if (Sec >= 60)
        {
            GameSec = 0;
            ++Min;
        }

        if (Min >= 60)
        {
            Min = 0;
            ++Hour;
        }

        if (Hour >= 24)
        {
            Hour = 0;
            ++Day;
        }
    }

    public void MonthWith30Days()
    {
        if (Day > 30)
        {
            Day = 1;
            ++Month;
        }
    }   

    public void MonthWith31Days()
    {
        if (Day > 31)
        {
            Day = 1;
            ++Month;
        }
    }

    public void GetGameTime()
    {

    }

    void Save()
    {
        PlayerPrefs.SetInt("Month", Month);
        PlayerPrefs.SetInt("Day", Day);
        PlayerPrefs.SetInt("Hour", Hour);
        PlayerPrefs.SetInt("Min", Min);
    }
}
