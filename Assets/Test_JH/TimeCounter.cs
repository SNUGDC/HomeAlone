using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public float Gametime = 0;
    public GameObject Timer;
    public Text TimerText;
    public delegate void GetTime(int Time);
    int Day = 0, Hour = 0, Min = 0;

    void Start ()
    {   
        //check the code is running well
        Gametime = Time.time;
        Debug.Log(Gametime);
    }

    void Update ()
    {
        Gametime += Time.deltaTime * 3;
        SetTime();
    }
    
    //Test Method. whenever the code is complete, this method will be trashed
    public void PresentTime()
    {
        Debug.Log(Gametime);
    }

    public void GetTimeTextFromUI()
    {

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

        Debug.Log("Day : " + Day + "Time :" + Hour + ":" + Min +":"+ Sec);
    }
}
