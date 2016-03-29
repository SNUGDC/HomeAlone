using UnityEngine;
using System.Collections;
using System;

public class CreateTowel : MonoBehaviour
{
    public GameObject ShopLaudary;
    public GameObject Towel;
    public GameObject Sheep;
    public GameObject Croco;
    public int TowelRespawnTimeGap;
    public int MaxTowel;

    DateTime SysTime;
    DateTime UpdatedTime;
    TimeSpan Delta;
    TimeSpan TimeGap;

    int TowelAmount;
    int k;

    void Start()
    {
        if (ShopLaudary.GetComponent<Item>().haveItem() && Sheep.GetComponent<Friend>().HowFriendly() > 1 && Croco.GetComponent<Friend>().HowFriendly() > 1)
        {
            SysTime = System.DateTime.Now;
            Delta = new TimeSpan(0, 0, TowelRespawnTimeGap);
            UpdatedTime = SysTime;

            TimeGap = TimeCheck.OFFtime();

            for (TimeSpan Gap = TimeGap; Gap >= Delta && TowelAmount < MaxTowel; Gap -= Delta)
            {
                TowelAmount = TowelAmount + 1;
                Instantiate(Towel);
            }
            SaveTowel();
        }
    }

    void Update()
    {
        if (ShopLaudary.GetComponent<Item>().haveItem() && Sheep.GetComponent<Friend>().HowFriendly() > 1 && Croco.GetComponent<Friend>().HowFriendly() > 1)
        {
            LoadTowel();

            k = UnityEngine.Random.Range(1, 3);
            SysTime = System.DateTime.Now;

            if (TimeOver() && TowelAmount < MaxTowel)
            {
                UpdatedTime = SysTime;
                Instantiate(Towel);
            }
            SaveTowel();
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

    void SaveTowel()
    {
        PlayerPrefs.SetInt("TowelAmount", TowelAmount);
    }

    void LoadTowel()
    {
        TowelAmount = PlayerPrefs.GetInt("TowelAmount");
    }
}
