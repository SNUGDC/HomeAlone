using UnityEngine;
using System.Collections;
using System;

public class CreateRedGompang : MonoBehaviour
{
    public GameObject GompangCleaner;
    public GameObject RedGompang;
    public int RedGompangRespawnTimeGap;
    public int MaxRedGompang;

    DateTime SysTime;
    DateTime UpdatedTime;
    TimeSpan Delta;
    TimeSpan TimeGap;

    int RedGompangAmount;
    int k;

    void Start()
    {
        if (GompangCleaner.GetComponent<Item>().haveItem())
        {
            SysTime = System.DateTime.Now;
            Delta = new TimeSpan(0, 0, RedGompangRespawnTimeGap);
            UpdatedTime = SysTime;

            TimeGap = TimeCheck.OFFtime();

            for (TimeSpan Gap = TimeGap; Gap >= Delta && RedGompangAmount < MaxRedGompang; Gap -= Delta)
            {
                RedGompangAmount = RedGompangAmount + 1;
                Instantiate(RedGompang);
            }
            SaveRedGompang();
        }
    }

    void Update()
    {
        if (GompangCleaner.GetComponent<Item>().haveItem())
        {
            LoadRedGompang();

            SysTime = System.DateTime.Now;

            if (TimeOver() && RedGompangAmount < MaxRedGompang)
            {
                UpdatedTime = SysTime;
                Instantiate(RedGompang);
            }
            SaveRedGompang();
        }
    }

    bool TimeOver()
    {
        if (SysTime - UpdatedTime >= Delta)
        {
            return true;
        }
        else return false;
    }

    void SaveRedGompang()
    {
        PlayerPrefs.SetInt("RedGompangAmount", RedGompangAmount);
    }

    void LoadRedGompang()
    {
        RedGompangAmount = PlayerPrefs.GetInt("RedGompangAmount");
    }
}

