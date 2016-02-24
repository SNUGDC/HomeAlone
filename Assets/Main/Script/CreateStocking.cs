using UnityEngine;
using System.Collections;
using System;

public class CreateStocking : MonoBehaviour
{
	public GameObject ShopLaundry;
    public GameObject Stocking_Black;
    public GameObject Stocking_Ivory;
    public int StockingRespawnTimeGap;
    public int MaxStocking;

    DateTime SysTime;
    DateTime UpdatedTime;
    TimeSpan Delta;
    TimeSpan TimeGap;

    int StockingAmount;
    int k;

    void Start()
    {
		if (ShopLaundry.GetComponent<Item> ().haveItem ()) {
			SysTime = System.DateTime.Now;
			Delta = new TimeSpan (0, 0, StockingRespawnTimeGap);
			UpdatedTime = SysTime;

			if (!(PlayerPrefs.HasKey ("StockingAmount")))
				PlayerPrefs.SetInt ("StockingAmount", 0);
			else
				LoadStocking ();

			TimeGap = TimeCheck.OFFtime ();

			for (TimeSpan Gap = TimeGap; Gap >= Delta && StockingAmount <= MaxStocking; Gap -= Delta)
				StockingAmount = StockingAmount + 1;

			for (int i = 0; i <= StockingAmount; i++) {
				int a = i % 2;
				switch (a) {
				case 0:
					Instantiate (Stocking_Black);
					break;
				case 1:
					Instantiate (Stocking_Ivory);
					break;
				default:
					Instantiate (Stocking_Black);
					break;
				}
			}
			SaveStocking ();
		}
    }

    void Update()
    {
		if (ShopLaundry.GetComponent<Item> ().haveItem ()) {
			LoadStocking ();

			k = UnityEngine.Random.Range (1, 5);
			SysTime = System.DateTime.Now;

			Debug.Log (StockingAmount);

			if (TimeOver () && StockingAmount < MaxStocking) {
				UpdatedTime = SysTime;

				switch (k) {
				case 1:
					Instantiate (Stocking_Black);
					StockingAmount = StockingAmount + 1;
					break;
				case 2:
					Instantiate (Stocking_Ivory);
					StockingAmount = StockingAmount + 1;
					break;
				default:
					Instantiate (Stocking_Black);
					StockingAmount = StockingAmount + 1;
					break;
				}
			}

			SaveStocking ();
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

    void SaveStocking()
    {
        PlayerPrefs.SetInt("StockingAmount", StockingAmount);
    }

    void LoadStocking()
    {
        StockingAmount = PlayerPrefs.GetInt("StockingAmount");
    }
}
