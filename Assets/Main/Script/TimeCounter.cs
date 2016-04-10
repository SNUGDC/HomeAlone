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
    public string StringMonth;

    private TimeSpan OffTime;

    void Start ()
    {
        if (PlayerPrefs.HasKey("Min"))
        {
            Load();
            OffTime = TimeCheck.OFFtime();
            OffTime = OffTime + OffTime + OffTime;
            PlayerPrefs.SetInt("Day", Day + OffTime.Days);
            PlayerPrefs.SetInt("Hour", Hour + OffTime.Hours);
            PlayerPrefs.SetInt("Min", Min + OffTime.Minutes);
        }
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
        MonthIntToString();
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
            Month = Month - 12;
            ++Year;
        }
    }

    public void SetHourandMin()
    {
        float Sec = GameSec;

        if (Sec >= 60)
        {
            GameSec = GameSec - 60;
            ++Min;
        }

        if (Min >= 60)
        {
            Min = Min - 60;
            ++Hour;
        }

        if (Hour >= 24)
        {
            Hour = Hour - 24;
            ++Day;
        }
    }

    public void MonthWith30Days()
    {
        if (Day > 30)
        {
            Day = Day - 30;
            ++Month;
        }
    }   

    public void MonthWith31Days()
    {
        if (Day > 31)
        {
            Day = Day - 31;
            ++Month;
        }
    }

    public void MonthIntToString()
    {
        switch(Month)
        {
            case 1:
                StringMonth = "Feb";
                break;
            case 2:
                StringMonth = "Jan";
                break;
            case 3:
                StringMonth = "Mar";
                break;
            case 4:
                StringMonth = "Apr";
                break;
            case 5:
                StringMonth = "May";
                break;
            case 6:
                StringMonth = "June";
                break;
            case 7:
                StringMonth = "July";
                break;
            case 8:
                StringMonth = "Aug";
                break;
            case 9:
                StringMonth = "Sep";
                break;
            case 10:
                StringMonth = "Oct";
                break;
            case 11:
                StringMonth = "Nov";
                break;
            case 12:
                StringMonth = "Dec";
                break;
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
