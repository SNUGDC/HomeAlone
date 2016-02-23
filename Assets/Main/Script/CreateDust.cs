using UnityEngine;
using System.Collections;
using System;

public class CreateDust : MonoBehaviour
{
    public GameObject Dust1;
    public GameObject Dust2;
    public GameObject Dust3;
    public GameObject Dust4;
    public GameObject Dust5;
    public int DustRespawnTimeGap;
    public int MaxDust;

    DateTime SysTime;
    DateTime UpdatedTime;
    TimeSpan Delta;
    TimeSpan TimeGap;

    int DustAmount;
    int k;

    void Start()
    {
        SysTime = System.DateTime.Now;
        Delta = new TimeSpan(0, 0, DustRespawnTimeGap);
        UpdatedTime = SysTime;

        LoadDust();

        TimeGap = TimeCheck.OFFtime();

        for (TimeSpan Gap = TimeGap; Gap >= Delta && DustAmount <= MaxDust; Gap -= Delta)
        {
            DustAmount = DustAmount + 1;
        }

        for (int i = 0; i <= DustAmount; i++)
        {
            int a = i % 5;
            switch (a)
            {
                case 0:
                    Instantiate(Dust1);
                    break;
                case 1:
                    Instantiate(Dust2);
                    break;
                case 2:
                    Instantiate(Dust3);
                    break;
                case 3:
                    Instantiate(Dust4);
                    break;
                case 4:
                    Instantiate(Dust5);
                    break;
                default:
                    Instantiate(Dust1);
                    break;
            }
        }

        SaveDust();
    }

    void Update()
    {
        LoadDust();

        k = UnityEngine.Random.Range(1, 5);
        SysTime = System.DateTime.Now;

        if (TimeOver() && DustAmount < MaxDust)
        {
            UpdatedTime = SysTime;

            switch(k)
            {
                case 1:
                    Instantiate(Dust1);
                    DustAmount = DustAmount + 1;
                    break;
                case 2:
                    Instantiate(Dust2);
                    DustAmount = DustAmount + 1;
                    break;
                case 3:
                    Instantiate(Dust3);
                    DustAmount = DustAmount + 1;
                    break;
                case 4:
                    Instantiate(Dust4);
                    DustAmount = DustAmount + 1;
                    break;
                case 5:
                    Instantiate(Dust5);
                    DustAmount = DustAmount + 1;
                    break;
                default:
                    Instantiate(Dust1);
                    DustAmount = DustAmount + 1;
                    break;
            }
        }

        SaveDust();
    }

    bool TimeOver()
    {
        if (SysTime - UpdatedTime >= Delta)
        {
            return true;
        }
        else return false;
    }

    void SaveDust()
    {
        PlayerPrefs.SetInt("DustAmount", DustAmount);
    }

    void LoadDust()
    {
        DustAmount = PlayerPrefs.GetInt("DustAmount");
    }
}
