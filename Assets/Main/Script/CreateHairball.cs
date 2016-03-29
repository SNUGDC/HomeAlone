using UnityEngine;
using System.Collections;
using System;

public class CreateHairball : MonoBehaviour
{
    public GameObject Hairball1;
    public GameObject Hairball2;
    public GameObject Hairball3;
    public GameObject Hairball4;
    public GameObject Hairball5;
    public int HairballRespawnTimeGap;
    public int MaxHairball;

    DateTime SysTime;
    DateTime UpdatedTime;
    TimeSpan Delta;
    TimeSpan TimeGap;

    int HairballAmount;
    int k;

    void Start()
    {
        SysTime = System.DateTime.Now;
        Delta = new TimeSpan(0, 0, HairballRespawnTimeGap);
        UpdatedTime = SysTime;

        LoadHairball();

        TimeGap = TimeCheck.OFFtime();

        for (TimeSpan Gap = TimeGap; Gap >= Delta && HairballAmount <= MaxHairball; Gap -= Delta)
        {
            HairballAmount = HairballAmount + 1;
        }

        for (int i = 0; i <= HairballAmount; i++)
        {
            int a = i % 5;
            switch (a)
            {
                case 0:
                    Instantiate(Hairball1);
                    break;
                case 1:
                    Instantiate(Hairball2);
                    break;
                case 2:
                    Instantiate(Hairball3);
                    break;
                case 3:
                    Instantiate(Hairball4);
                    break;
                case 4:
                    Instantiate(Hairball5);
                    break;
                default:
                    Instantiate(Hairball1);
                    break;
            }
        }

        SaveHairball();
    }

    void Update()
    {
        LoadHairball();

        k = UnityEngine.Random.Range(1, 6);
        SysTime = System.DateTime.Now;

        if (TimeOver() && HairballAmount < MaxHairball)
        {
            UpdatedTime = SysTime;

            switch (k)
            {
                case 1:
                    Instantiate(Hairball1);
                    HairballAmount = HairballAmount + 1;
                    break;
                case 2:
                    Instantiate(Hairball2);
                    HairballAmount = HairballAmount + 1;
                    break;
                case 3:
                    Instantiate(Hairball3);
                    HairballAmount = HairballAmount + 1;
                    break;
                case 4:
                    Instantiate(Hairball4);
                    HairballAmount = HairballAmount + 1;
                    break;
                case 5:
                    Instantiate(Hairball5);
                    HairballAmount = HairballAmount + 1;
                    break;
                default:
                    Instantiate(Hairball5);
                    HairballAmount = HairballAmount + 1;
                    break;
            }
        }
        SaveHairball();
    }

    bool TimeOver()
    {
        if (SysTime - UpdatedTime >= Delta)
        {
            return true;
        }
        else return false;
    }

    void SaveHairball()
    {
        PlayerPrefs.SetInt("HairballAmount", HairballAmount);
    }

    void LoadHairball()
    {
        HairballAmount = PlayerPrefs.GetInt("HairballAmount");
    }
}
