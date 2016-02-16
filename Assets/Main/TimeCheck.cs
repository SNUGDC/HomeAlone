using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class TimeCheck : MonoBehaviour {
	public static string LoadTime;
	public static DateTime SysTime, LoadDateTime;

	// Use this for initialization
	void Start () {
		SysTime = System.DateTime.Now;
	}
	
	// Update is called once per frame
	void Update () {
		PlayerPrefs.SetString("TimeSave", SysTime.ToString());
	}

	public static bool TimeOver(TimeSpan Delta){
		if (PlayerPrefs.HasKey ("TimeSave")) {
			LoadTime = PlayerPrefs.GetString ("TimeSave");
			LoadDateTime = System.DateTime.Parse (LoadTime);

			if (SysTime - LoadDateTime > Delta)
				return true;
			else
				return false;
		} else
			return false;
	}

}
