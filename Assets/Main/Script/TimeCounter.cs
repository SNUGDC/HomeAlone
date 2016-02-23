using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class TimeCounter : MonoBehaviour
{
    public Text TimerText;
    public float GameSec = 0;
    public int Year, Month, Day, Hour, Min;
    public delegate void GetTime(int Time);
    public float TimeFasterValue;

    void Start ()
    {
        if (PlayerPrefs.HasKey("Min"))
            Load();
        else
        {
            PlayerPrefs.SetInt("Year", 16);
            PlayerPrefs.SetInt("Month", 3);
            PlayerPrefs.SetInt("Day", 2);
            PlayerPrefs.SetInt("Hour", 9);
            PlayerPrefs.SetInt("Min", 0);
        }
        GameSec = Time.time;
    }

    void Update ()
    {
        Load();
        GameSec += Time.deltaTime * TimeFasterValue;
        SetCurrentTime();
        Save();
    }

    public void SetCurrentTime()
    {
        SetMonthandDay();
        SetHourandMin();
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
        {
            Month = 1;
            ++Year;
        }
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

    void Save()
    {
        PlayerPrefs.SetInt("Year", Year);
        PlayerPrefs.SetInt("Month", Month);
        PlayerPrefs.SetInt("Day", Day);
        PlayerPrefs.SetInt("Hour", Hour);
        PlayerPrefs.SetInt("Min", Min);
    }

    void Load()
    {
        Year = PlayerPrefs.GetInt("Year");
        Month = PlayerPrefs.GetInt("Month");
        Day = PlayerPrefs.GetInt("Day");
        Hour = PlayerPrefs.GetInt("Hour");
        Min = PlayerPrefs.GetInt("Min");
    }
}
