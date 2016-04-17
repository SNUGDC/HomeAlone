using UnityEngine;
using System.Collections;
using System;

public class StrawberryMilk : MonoBehaviour {
	public GameObject ShopObject, ThisObject;

	int BoughtNumber;
	public int Hour;
	public string ItemName;		// !!!MUST SAME TO SHOP ITEM NAME!!!

	// zeroTimeSpan = default value
	DateTime StartTime, UpdatedTime, zeroTime;
	public TimeSpan ItemHour, AllTime, PassedTime, RemainTime, zeroTimeSpan;

	void Start () {
		if(PlayerPrefs.HasKey(ItemName + "StartTime"))
			StartTime = System.DateTime.Parse (PlayerPrefs.GetString(ItemName + "StartTime"));	//load

		ItemHour = TimeSpan.FromHours(Hour);	// later, FromHours

		// initialization & save
		if (StartTime == zeroTime) {
			StartTime = System.DateTime.Now;
			PlayerPrefs.SetString (ItemName + "StartTime", StartTime.ToString ());
		}

		UpdatedTime = System.DateTime.Now;;
	}

	void Update () {
		if(PlayerPrefs.HasKey(ItemName + "StartTime"))
			StartTime = System.DateTime.Parse (PlayerPrefs.GetString(ItemName + "StartTime"));	//load
		if (StartTime == zeroTime) {
			StartTime = System.DateTime.Now;
			PlayerPrefs.SetString (ItemName + "StartTime", StartTime.ToString ());
		}
			
		UpdatedTime = System.DateTime.Now;
		BoughtNumber = PlayerPrefs.GetInt (ItemName + "BoughtNumber");
		AllTime = TimeSpan.FromTicks(ItemHour.Ticks * BoughtNumber);
		PassedTime = UpdatedTime - StartTime;
		RemainTime = AllTime - PassedTime;
//		RemainHour = RemainTime.Days * 24 + RemainTime.Hours;

		if (RemainTime <= zeroTimeSpan) {
			PlayerPrefs.SetString (ItemName + "StartTime", zeroTime.ToString ());
			ShopObject.GetComponent<Item> ().BoughtNumber = 0;
			PlayerPrefs.SetInt (ItemName + "BoughtNumber", 0);
			ThisObject.SetActive (false);
		}
	}
}
