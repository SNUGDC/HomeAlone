using UnityEngine;
using System.Collections;
using System;

public class CreateBigDust : MonoBehaviour
{
    public GameObject BigDust;

    TimeSpan TimeGap;
    String TimeGapString;

    void Start()
    {
        TimeGap = TimeCheck.OFFtime();
        Debug.Log(TimeGap);

        if(TimeGap > new TimeSpan(0,3,0))
            Instantiate(BigDust);
    }
}
