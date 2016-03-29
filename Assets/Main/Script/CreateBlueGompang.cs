using UnityEngine;
using System.Collections;
using System;

public class CreateBlueGompang : MonoBehaviour
{
    public GameObject GompangCleaner;
    public GameObject BlueGompang;
    public int BlueGompangRespawnTimeGap;
    public int MaxBlueGompang;

    DateTime SysTime;
    DateTime UpdatedTime;
    TimeSpan Delta;
    TimeSpan TimeGap;

    int BlueGompangAmount;
    int k;

    void Start()
    {
        if (GompangCleaner.GetComponent<Item>().haveItem())
        {
            SysTime = System.DateTime.Now;
            Delta = new TimeSpan(0, 0, BlueGompangRespawnTimeGap);
            UpdatedTime = SysTime;

            TimeGap = TimeCheck.OFFtime();

            for (TimeSpan Gap = TimeGap; Gap >= Delta && BlueGompangAmount < MaxBlueGompang; Gap -= Delta)
            {
                BlueGompangAmount = BlueGompangAmount + 1;
                Instantiate(BlueGompang);
            }
            SaveBlueGompang();
        }
    }

    void Update()
    {
        if (GompangCleaner.GetComponent<Item>().haveItem())
        {
            LoadBlueGompang();

            SysTime = System.DateTime.Now;

            if (TimeOver() && BlueGompangAmount < MaxBlueGompang)
            {
                UpdatedTime = SysTime;
                Instantiate(BlueGompang);
            }
            SaveBlueGompang();
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

    void SaveBlueGompang()
    {
        PlayerPrefs.SetInt("BlueGompangAmount", BlueGompangAmount);
    }

    void LoadBlueGompang()
    {
        BlueGompangAmount = PlayerPrefs.GetInt("BlueGompangAmount");
    }
}
