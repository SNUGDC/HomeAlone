using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class TimeCheck : MonoBehaviour {
	public static string LoadTime;
	public static DateTime SysTime, UpdateTime, LoadDateTime;
	public static TimeSpan Deltazero;
	public GameObject Milk;
	bool GetMilk;

	// Use this for initialization
	void Awake () {
		SysTime = System.DateTime.Now;
		UpdateTime = SysTime;
		Deltazero = new TimeSpan (0, 0, 0);
		if (PlayerPrefs.HasKey ("TimeSave")) {
			LoadTime = PlayerPrefs.GetString ("TimeSave");
			LoadDateTime = System.DateTime.Parse (LoadTime);
		} else
			LoadDateTime = SysTime;
	}

	void Start(){
		if (PlayerPrefs.HasKey ("GetMilk"))
			GetMilk = (PlayerPrefs.GetString ("GetMilk") == "True");
		else
			GetMilk = false;
	}
	// Update is called once per frame
	void Update () {
		if (!GetMilk) {
			MoneySystem.money += 1200;
			Milk.GetComponent<Item> ().Buy ();
			GetMilk = true;
			PlayerPrefs.SetString ("GetMilk", GetMilk.ToString ());
		}
		UpdateTime = System.DateTime.Now;
		PlayerPrefs.SetString("TimeSave", UpdateTime.ToString());
	}

	public static bool TimeOver(TimeSpan Delta){
		if (SysTime - LoadDateTime > Delta) {
//			Debug.Log( SysTime - LoadDateTime);
			return true;
		} else {
			return false;
		}
	}

	public static TimeSpan OFFtime(){
		return SysTime - LoadDateTime;
	}

	public void ChangeScene(string SceneName){
		SceneManager.LoadScene (SceneName);
	}
}
