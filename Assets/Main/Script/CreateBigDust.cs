using UnityEngine;
using System.Collections;
using System;

public class CreateBigDust : MonoBehaviour
{
    public GameObject BigDust;

    int BigDustAmount;
    TimeSpan TimeGap;

    void Start()
    {
        BigDustAmount = PlayerPrefs.GetInt("BigDustAmount");
        TimeGap = TimeCheck.OFFtime();
        Debug.Log(TimeGap);

        if (TimeGap < new TimeSpan(8, 0, 0) && BigDustAmount < 1)
        {
            BigDustAmount = 0;
        }
        else
        {
            Instantiate(BigDust);
            BigDustAmount = 1;
        }
        PlayerPrefs.SetInt("BigDustAmount", BigDustAmount);
    }
}
