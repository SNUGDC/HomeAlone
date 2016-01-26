using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class TimeCounter : MonoBehaviour
{
    private float Gametime = 0;
    private string CurrentTime;
    Func<string> value;
    public int Month = 3, Day = 2, Hour = 0, Min = 0;
    public Text TimerText;
    public delegate void GetTime(int Time);
    public float TimeFasterValue;

    void Start ()
    {   
        //check the code is running well
        Gametime = Time.time;
    }

    void Update ()
    {
        Gametime += Time.deltaTime * TimeFasterValue;
        SetTime();
        ShowCurrentTime(() => CurrentTime);
        TimerText.text = value();
    }
    
    public void ShowCurrentTime(Func<String> value)
    {
        this.value = value;
    }

    public void SetTime()
    {
        float Sec = Gametime;

        if (Sec >= 60)
        {
            Gametime = 0;
            Min = Min+1;
        }

        if (Min >= 60)
        {
            Min = 0;
            Hour = Hour +1;
        }

        if (Hour >= 24)
        {
            Hour = 0;
            Day = Day +1 ;
        }

        GetMonthandDay();

        CurrentTime = "Month : " + Month + "  Day : " + Day + "  Time :" + Hour + ":" + Min;

        Debug.Log(CurrentTime + ":" + Sec);
    }

    public void GetMonthandDay()
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
}
