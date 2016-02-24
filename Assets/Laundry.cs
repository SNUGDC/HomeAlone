﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Laundry : MonoBehaviour {
	public GameObject VisitFriend, buyButton, QuestionBox, PopUp, PopUpClose;
	public Text PopUpText;
	public int openVisitCount;
	bool IsAlreadyOpen;

	// Use this for initialization

	void Start () {
		load ();
	}

	// Update is called once per frame
	void Update () {
		if (VisitFriend.GetComponent<VisitFriend> ().VisitNumber >= openVisitCount) {
			buyButton.GetComponent<Button> ().enabled = true;
			QuestionBox.SetActive (false);
			if (!IsAlreadyOpen) {
				PopUpText.text = "이제 상점에서 <빨래건조대>를 구입할 수 있습니다!";
				PopUpClose.SetActive (true);
				PopUp.SetActive (true);
				IsAlreadyOpen = true;
			}
		}
		save ();
	}

	void save(){
		PlayerPrefs.SetString("laundryOPEN",IsAlreadyOpen.ToString());
	}

	void load(){
		if(PlayerPrefs.HasKey("laundryOPEN"))
			IsAlreadyOpen = (PlayerPrefs.GetString ("laundryOPEN") == "True");
	}
}
