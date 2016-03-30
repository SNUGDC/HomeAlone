using UnityEngine;
using System.Collections;
using System;

public class CreateTShirt : MonoBehaviour
{
    public GameObject ShopLaudary;
    public GameObject TShirt;
    public GameObject Sheep;
    public GameObject Croco;
    public int TShirtRespawnTimeGap;
    public int MaxTShirt;

    DateTime SysTime;
    DateTime UpdatedTime;
    TimeSpan Delta;
    TimeSpan TimeGap;

    int TShirtAmount;
    int k;

    void Start()
    {
        if (!(PlayerPrefs.HasKey("TShirtAmount")))
            PlayerPrefs.SetInt("TShirtAmount", 0);

        //		Debug.Log (Sheep.GetComponent<Friend> ().HowFriendly ());
        //		Debug.Log (Croco.GetComponent<Friend> ().HowFriendly ());
        if (ShopLaudary.GetComponent<Item>().haveItem() && Sheep.GetComponent<Friend>().HowFriendly() > 1 && Croco.GetComponent<Friend>().HowFriendly() > 1)
        {
            SysTime = System.DateTime.Now;
            Delta = new TimeSpan(0, 0, TShirtRespawnTimeGap);
            UpdatedTime = SysTime;

            TimeGap = TimeCheck.OFFtime();

            for (TimeSpan Gap = TimeGap; Gap >= Delta && TShirtAmount < MaxTShirt; Gap -= Delta)
            {
                TShirtAmount = TShirtAmount + 1;
                Instantiate(TShirt);
            }
            SaveTShirt();
        }
    }

    void Update()
    {
        if (ShopLaudary.GetComponent<Item>().haveItem() && Sheep.GetComponent<Friend>().HowFriendly() > 1 && Croco.GetComponent<Friend>().HowFriendly() > 1)
        {
            LoadTShirt();

            SysTime = System.DateTime.Now;

            if (TimeOver() && TShirtAmount < MaxTShirt)
            {
                UpdatedTime = SysTime;
                Instantiate(TShirt);
            }
            SaveTShirt();
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

    void SaveTShirt()
    {
        PlayerPrefs.SetInt("TShirtAmount", TShirtAmount);
    }

    void LoadTShirt()
    {
        TShirtAmount = PlayerPrefs.GetInt("TShirtAmount");
    }
}
