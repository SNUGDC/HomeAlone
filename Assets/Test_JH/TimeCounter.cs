using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public float Gametime = 0;
    public GameObject Timer;
    public Text TimerText;
    public delegate void GetTime(int Time);
	
	void Start ()
    {   
        //check the code is running well
        Gametime = Time.time;
        Debug.Log(Gametime);
    }

    void Update ()
    {
        Gametime += Time.deltaTime * 3;
        SetTime(Gametime);
    }
    
    //Test Method. whenever the code is complete, this method will be trashed
    public void PresentTime()
    {
        Debug.Log(Gametime);
    }

    public void GetTimeTextFromUI()
    {

    }

    public void SetTime(float Gametime)
    {
        float Sec=Gametime;
        int Day = 0, Hour = 0, Min = 0;

        if (Sec >= 60)
        {
            Gametime = 0;
            Min++;
        }

        if (Min >= 60)
        {
            Min = 0;
            Hour++;
        }

        if (Hour >= 24)
        {
            Hour = 0;
            Day++;
        }

        Debug.Log("Day : " + Day + "Time :" + Hour + ":" + Min +":"+ Sec);
    }
}
