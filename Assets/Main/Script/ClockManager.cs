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

    void Update()
    {
        ShowMinNumber();
        ShowHourNumber();
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
}
