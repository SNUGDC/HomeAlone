using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class GoToMain : MonoBehaviour
{
    TimeSpan HowMuchTimePass;
    DateTime NowTime;
    TimeSpan PassTime;

    void Start()
    {
        if (!(PlayerPrefs.HasKey("HowMuchTimePass")))
            PlayerPrefs.SetInt("HowMuchTimePass", 0);
        else
            PlayerPrefs.SetInt("HowMuchTimePass", PlayerPrefs.GetInt("HowMuchTimePass") + TimeCheck.OFFtime().Minutes);
        NowTime = DateTime.Now;
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("HowMuchTimePass") > 10)
            SceneManager.LoadScene("Main");
        PassTime = DateTime.Now - NowTime;
        PlayerPrefs.SetInt("HowMuchTimePass", PlayerPrefs.GetInt("HowMuchTimePass") + PassTime.Minutes);
    }
}
