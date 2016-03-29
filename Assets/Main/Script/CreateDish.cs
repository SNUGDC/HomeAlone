using UnityEngine;
using System.Collections;
using System;

public class CreateDish : MonoBehaviour
{
    public GameObject ShopDishes;
    public GameObject Dish1;
    public GameObject Dish2;
    public int DishesRespawnTimeGap;
    public int MaxDishes;

    DateTime SysTime;
    DateTime UpdatedTime;
    TimeSpan Delta;
    TimeSpan TimeGap;

    int DishesAmount;
    int k;

    void Start()
    {
        if (ShopDishes.GetComponent<Item>().haveItem())
        {
            SysTime = System.DateTime.Now;
            Delta = new TimeSpan(0, 0, DishesRespawnTimeGap);
            UpdatedTime = SysTime;

            TimeGap = TimeCheck.OFFtime();

            for (TimeSpan Gap = TimeGap; Gap >= Delta && DishesAmount < MaxDishes; Gap -= Delta)
            {
                DishesAmount = DishesAmount + 1;
            }

            for (int i = 0; i < DishesAmount; i++)
            {
                int a = i % 2;
                switch (a)
                {
                    case 0:
                        Instantiate(Dish1);
                        break;
                    case 1:
                        Instantiate(Dish2);
                        break;
                    default:
                        Instantiate(Dish1);
                        break;
                }
            }
            SaveDishes();
        }
    }

    void Update()
    {
        if (ShopDishes.GetComponent<Item>().haveItem())
        {
            LoadDishes();

            k = UnityEngine.Random.Range(1, 3);
            SysTime = System.DateTime.Now;

            if (TimeOver() && DishesAmount < MaxDishes)
            {
                UpdatedTime = SysTime;
                switch (k)
                {
                    case 1:
                        Instantiate(Dish1);
                        DishesAmount = DishesAmount + 1;
                        break;
                    case 2:
                        Instantiate(Dish2);
                        DishesAmount = DishesAmount + 1;
                        break;
                    default:
                        Instantiate(Dish1);
                        DishesAmount = DishesAmount + 1;
                        break;
                }
            }
            SaveDishes();
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

    void SaveDishes()
    {
        PlayerPrefs.SetInt("DishesAmount", DishesAmount);
    }

    void LoadDishes()
    {
        DishesAmount = PlayerPrefs.GetInt("DishesAmount");
    }
}
