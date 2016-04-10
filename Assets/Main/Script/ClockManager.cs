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
    public Sprite A;
    public Sprite B;
    public Sprite C;
    public Sprite D;
    public Sprite E;
    public Sprite F;
    public Sprite G;
    public Sprite J;
    public Sprite L;
    public Sprite M;
    public Sprite N;
    public Sprite O;
    public Sprite P;
    public Sprite R;
    public Sprite S;
    public Sprite T;
    public Sprite U;
    public Sprite V;
    public Sprite Y;

    public GameObject Hour1;
    public GameObject Hour2;
    public GameObject Min1;
    public GameObject Min2;
    public GameObject Day1;
    public GameObject Day2;
    public GameObject Month1;
    public GameObject Month2;
    public GameObject Month3;
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

        switch (k)
        {
            case 1:
                Month1.GetComponent<SpriteRenderer>().sprite = J;
                Month2.GetComponent<SpriteRenderer>().sprite = A;
                Month3.GetComponent<SpriteRenderer>().sprite = N;
                break;
            case 2:
                Month1.GetComponent<SpriteRenderer>().sprite = F;
                Month2.GetComponent<SpriteRenderer>().sprite = E;
                Month3.GetComponent<SpriteRenderer>().sprite = B;
                break;
            case 3:
                Month1.GetComponent<SpriteRenderer>().sprite = M;
                Month2.GetComponent<SpriteRenderer>().sprite = A;
                Month3.GetComponent<SpriteRenderer>().sprite = R;
                break;
            case 4:
                Month1.GetComponent<SpriteRenderer>().sprite = A;
                Month2.GetComponent<SpriteRenderer>().sprite = P;
                Month3.GetComponent<SpriteRenderer>().sprite = R;
                break;
            case 5:
                Month1.GetComponent<SpriteRenderer>().sprite = M;
                Month2.GetComponent<SpriteRenderer>().sprite = A;
                Month3.GetComponent<SpriteRenderer>().sprite = Y;
                break;
            case 6:
                Month1.GetComponent<SpriteRenderer>().sprite = J;
                Month2.GetComponent<SpriteRenderer>().sprite = U;
                Month3.GetComponent<SpriteRenderer>().sprite = N;
                break;
            case 7:
                Month1.GetComponent<SpriteRenderer>().sprite = J;
                Month2.GetComponent<SpriteRenderer>().sprite = U;
                Month3.GetComponent<SpriteRenderer>().sprite = L;
                break;
            case 8:
                Month1.GetComponent<SpriteRenderer>().sprite = A;
                Month2.GetComponent<SpriteRenderer>().sprite = U;
                Month3.GetComponent<SpriteRenderer>().sprite = G;
                break;
            case 9:
                Month1.GetComponent<SpriteRenderer>().sprite = S;
                Month2.GetComponent<SpriteRenderer>().sprite = E;
                Month3.GetComponent<SpriteRenderer>().sprite = P;
                break;
            case 10:
                Month1.GetComponent<SpriteRenderer>().sprite = O;
                Month2.GetComponent<SpriteRenderer>().sprite = C;
                Month3.GetComponent<SpriteRenderer>().sprite = T;
                break;
            case 11:
                Month1.GetComponent<SpriteRenderer>().sprite = N;
                Month2.GetComponent<SpriteRenderer>().sprite = O;
                Month3.GetComponent<SpriteRenderer>().sprite = V;
                break;
            case 12:
                Month1.GetComponent<SpriteRenderer>().sprite = D;
                Month2.GetComponent<SpriteRenderer>().sprite = E;
                Month3.GetComponent<SpriteRenderer>().sprite = C;
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
                Year1.GetComponent<SpriteRenderer>().sprite = Number1;
                break;
            case 2:
                Year1.GetComponent<SpriteRenderer>().sprite = Number2;
                break;
        }

        switch (year2)
        {
            case 0:
                Year2.GetComponent<SpriteRenderer>().sprite = Number0;
                break;
            case 1:
                Year2.GetComponent<SpriteRenderer>().sprite = Number1;
                break;
            case 2:
                Year2.GetComponent<SpriteRenderer>().sprite = Number2;
                break;
            case 3:
                Year2.GetComponent<SpriteRenderer>().sprite = Number3;
                break;
            case 4:
                Year2.GetComponent<SpriteRenderer>().sprite = Number4;
                break;
            case 5:
                Year2.GetComponent<SpriteRenderer>().sprite = Number5;
                break;
            case 6:
                Year2.GetComponent<SpriteRenderer>().sprite = Number6;
                break;
            case 7:
                Year2.GetComponent<SpriteRenderer>().sprite = Number7;
                break;
            case 8:
                Year2.GetComponent<SpriteRenderer>().sprite = Number8;
                break;
            case 9:
                Year2.GetComponent<SpriteRenderer>().sprite = Number9;
                break;
        }
    }

	public void NextMonth(){
		int month = PlayerPrefs.GetInt("Month");
		PlayerPrefs.SetInt("Month", month+1);
	}

	public void NextDay(){
		int day = PlayerPrefs.GetInt("Day");
		PlayerPrefs.SetInt("Day", day+1);
	}
}
