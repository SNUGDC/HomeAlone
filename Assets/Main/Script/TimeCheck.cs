using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class TimeCheck : MonoBehaviour {
	public static string LoadTime;
	public static DateTime SysTime, UpdateTime, LoadDateTime;
	public static TimeSpan Deltazero;

	// Use this for initialization
	void Start () {
		SysTime = System.DateTime.Now;
		UpdateTime = SysTime;
		Deltazero = new TimeSpan (0, 0, 0);
		if (PlayerPrefs.HasKey ("TimeSave")) {
			LoadTime = PlayerPrefs.GetString ("TimeSave");
			LoadDateTime = System.DateTime.Parse (LoadTime);
		} else
			LoadDateTime = SysTime;

		Debug.Log(SysTime);
		Debug.Log(LoadDateTime);
		Debug.Log(SysTime - LoadDateTime);
	}
	
	// Update is called once per frame
	void Update () {
		UpdateTime = System.DateTime.Now;
		PlayerPrefs.SetString("TimeSave", UpdateTime.ToString());
	}

	public static bool TimeOver(TimeSpan Delta){
		if (SysTime - LoadDateTime > Delta)
			return true;
		else
			return false;
	}

	public static TimeSpan OFFtime(){
		return SysTime - LoadDateTime;
	}
}
