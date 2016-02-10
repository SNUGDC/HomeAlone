﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FriendList : MonoBehaviour {
	public GameObject[] FriendArray;
	public string[] FriendName;
	public static int MaxVisitorNum, VisitorNum;

	// Use this for initialization
	void Start () {
		load ();
	}

	// Update is called once per frame
	void Update () {
		save ();
	}

	void save(){
		for (int i = 0; i < FriendArray.Length; i++) {
			PlayerPrefs.SetString(FriendName[i],FriendArray[i].activeSelf.ToString());
		}
		PlayerPrefs.SetInt("MaxVisitorNum", MaxVisitorNum);
		PlayerPrefs.SetInt("VisitorNum", VisitorNum);
	}

	void load(){
		for (int i = 0; i < FriendArray.Length; i++) {
			FriendArray[i].SetActive((PlayerPrefs.GetString (FriendName[i]) == "True"));
		}
		if (PlayerPrefs.HasKey ("MaxVisitorNum"))
			MaxVisitorNum = PlayerPrefs.GetInt ("MaxVisitorNum");
		else
			MaxVisitorNum = 1;
		VisitorNum = PlayerPrefs.GetInt ("VisitorNum");;
	}

	public void IncreaseMaxVisitor(){
		MaxVisitorNum++;
	}
}