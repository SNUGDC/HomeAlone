using UnityEngine;
using System.Collections;

public class ClockManager : MonoBehaviour
{
    public Sprite Number0;
    public Sprite Number1;
    public Sprite Number2;
    public Sprite Number3;
    public Sprite Number4;
    public Sprite Number5;
    public Sprite Number6;
    public Sprite Number7;
    public Sprite Number8;
    public Sprite Number9;

    public GameObject Hour1;
    public GameObject Hour2;
    public GameObject Min1;
    public GameObject Min2;
    public GameObject Day1;
    public GameObject Day2;
    public GameObject Month1;
    public GameObject Month2;
    public GameObject Year1;
    public GameObject Year2;

    void Update()
    {
        ShowMinNumber();
        ShowHourNumber();
        ShowDayNumber();
        ShowMonthNumber();
        ShowYearNumber();
    }

    void ShowMinNumber()
    {
        int k = PlayerPrefs.GetInt("Min");
        int min2 = k % 10;
        int min1 = k / 10;

        switch(min1)
        {
            case 0:
                Min1.GetComponent<SpriteRenderer>().sprite = Number0;
                break;
            case 1:
                Min1.GetComponent<SpriteRenderer>().sprite = Number1;
                break;
            case 2:
                Min1.GetComponent<SpriteRenderer>().sprite = Number2;
                break;
            case 3:
                Min1.GetComponent<SpriteRenderer>().sprite = Number3;
                break;
            case 4:
                Min1.GetComponent<SpriteRenderer>().sprite = Number4;
                break;
            case 5:
                Min1.GetComponent<SpriteRenderer>().sprite = Number5;
                break;
        }

        switch(min2)
        {
            case 0:
                Min2.GetComponent<SpriteRenderer>().sprite = Number0;
                break;
            case 1:
                Min2.GetComponent<SpriteRenderer>().sprite = Number1;
                break;
            case 2:
                Min2.GetComponent<SpriteRenderer>().sprite = Number2;
                break;
            case 3:
                Min2.GetComponent<SpriteRenderer>().sprite = Number3;
                break;
            case 4:
                Min2.GetComponent<SpriteRenderer>().sprite = Number4;
                break;
            case 5:
                Min2.GetComponent<SpriteRenderer>().sprite = Number5;
                break;
            case 6:
                Min2.GetComponent<SpriteRenderer>().sprite = Number6;
                break;
            case 7:
                Min2.GetComponent<SpriteRenderer>().sprite = Number7;
                break;
            case 8:
                Min2.GetComponent<SpriteRenderer>().sprite = Number8;
                break;
            case 9:
                Min2.GetComponent<SpriteRenderer>().sprite = Number9;
                break;
        }

	}
    void ShowHourNumber()
    {
        int k = PlayerPrefs.GetInt("Hour");
        int hour2 = k % 10;
        int hour1 = k / 10;

        switch (hour1)
        {
            case 0:
                Hour1.GetComponent<SpriteRenderer>().sprite = Number0;
                break;
            case 1:
                Hour1.GetComponent<SpriteRenderer>().sprite = Number1;
                break;
            case 2:
                Hour1.GetComponent<SpriteRenderer>().sprite = Number2;
                break;
        }

        switch (hour2)
        {
            case 0:
                Hour2.GetComponent<SpriteRenderer>().sprite = Number0;
                break;
            case 1:
                Hour2.GetComponent<SpriteRenderer>().sprite = Number1;
                break;
            case 2:
                Hour2.GetComponent<SpriteRenderer>().sprite = Number2;
                break;
            case 3:
                Hour2.GetComponent<SpriteRenderer>().sprite = Number3;
                break;
            case 4:
                Hour2.GetComponent<SpriteRenderer>().sprite = Number4;
                break;
            case 5:
                Hour2.GetComponent<SpriteRenderer>().sprite = Number5;
                break;
            case 6:
                Hour2.GetComponent<SpriteRenderer>().sprite = Number6;
                break;
            case 7:
                Hour2.GetComponent<SpriteRenderer>().sprite = Number7;
                break;
            case 8:
                Hour2.GetComponent<SpriteRenderer>().sprite = Number8;
                break;
            case 9:
                Hour2.GetComponent<SpriteRenderer>().sprite = Number9;
                break;
        }

    }
    void ShowDayNumber()
    {
        int k = PlayerPrefs.GetInt("Day");
        int day2 = k % 10;
        int day1 = k / 10;

        switch (day1)
        {
            case 0:
                Day1.GetComponent<SpriteRenderer>().sprite = Number0;
                break;
            case 1:
                Day1.GetComponent<SpriteRenderer>().sprite = Number1;
                break;
            case 2:
                Day1.GetComponent<SpriteRenderer>().sprite = Number2;
                break;
            case 3:
                Day1.GetComponent<SpriteRenderer>().sprite = Number3;
                break;
        }

        switch (day2)
        {
            case 0:
                Day2.GetComponent<SpriteRenderer>().sprite = Number0;
                break;
            case 1:
                Day2.GetComponent<SpriteRenderer>().sprite = Number1;
                break;
            case 2:
                Day2.GetComponent<SpriteRenderer>().sprite = Number2;
                break;
            case 3:
                Day2.GetComponent<SpriteRenderer>().sprite = Number3;
                break;
            case 4:
                Day2.GetComponent<SpriteRenderer>().sprite = Number4;
                break;
            case 5:
                Day2.GetComponent<SpriteRenderer>().sprite = Number5;
                break;
            case 6:
                Day2.GetComponent<SpriteRenderer>().sprite = Number6;
                break;
            case 7:
                Day2.GetComponent<SpriteRenderer>().sprite = Number7;
                break;
            case 8:
                Day2.GetComponent<SpriteRenderer>().sprite = Number8;
                break;
            case 9:
                Day2.GetComponent<SpriteRenderer>().sprite = Number9;
                break;
        }
    }
    void ShowMonthNumber()
    {
        int k = PlayerPrefs.GetInt("Month");
        int month2 = k % 10;
        int month1 = k / 10;

        switch (month1)
        {
            case 0:
                Month1.GetComponent<SpriteRenderer>().sprite = Number0;
                break;
            case 1:
                Month1.GetComponent<SpriteRenderer>().sprite = Number1;
                break;
        }

        switch (month2)
        {
            case 0:
                Month2.GetComponent<SpriteRenderer>().sprite = Number0;
                break;
            case 1:
                Month2.GetComponent<SpriteRenderer>().sprite = Number1;
                break;
            case 2:
                Month2.GetComponent<SpriteRenderer>().sprite = Number2;
                break;
            case 3:
                Month2.GetComponent<SpriteRenderer>().sprite = Number3;
                break;
            case 4:
                Month2.GetComponent<SpriteRenderer>().sprite = Number4;
                break;
            case 5:
                Month2.GetComponent<SpriteRenderer>().sprite = Number5;
                break;
            case 6:
                Month2.GetComponent<SpriteRenderer>().sprite = Number6;
                break;
            case 7:
                Month2.GetComponent<SpriteRenderer>().sprite = Number7;
                break;
            case 8:
                Month2.GetComponent<SpriteRenderer>().sprite = Number8;
                break;
            case 9:
                Month2.GetComponent<SpriteRenderer>().sprite = Number9;
                break;
        }
    }
    void ShowYearNumber()
    {
        int k = PlayerPrefs.GetInt("Year");
        int year2 = k % 10;
        int year1 = k / 10;

        switch (year1)
        {
            case 1:
                Month1.GetComponent<SpriteRenderer>().sprite = Number1;
                break;
            case 2:
                Month1.GetComponent<SpriteRenderer>().sprite = Number2;
                break;
        }

        switch (year2)
        {
            case 0:
                Month2.GetComponent<SpriteRenderer>().sprite = Number0;
                break;
            case 1:
                Month2.GetComponent<SpriteRenderer>().sprite = Number1;
                break;
            case 2:
                Month2.GetComponent<SpriteRenderer>().sprite = Number2;
                break;
            case 3:
                Month2.GetComponent<SpriteRenderer>().sprite = Number3;
                break;
            case 4:
                Month2.GetComponent<SpriteRenderer>().sprite = Number4;
                break;
            case 5:
                Month2.GetComponent<SpriteRenderer>().sprite = Number5;
                break;
            case 6:
                Month2.GetComponent<SpriteRenderer>().sprite = Number6;
                break;
            case 7:
                Month2.GetComponent<SpriteRenderer>().sprite = Number7;
                break;
            case 8:
                Month2.GetComponent<SpriteRenderer>().sprite = Number8;
                break;
            case 9:
                Month2.GetComponent<SpriteRenderer>().sprite = Number9;
                break;
        }
    }
}
