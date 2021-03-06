﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Laundry : MonoBehaviour {
	public GameObject DialogPanel, VisitFriend,ShopItem, buyButton, QuestionBox, PopUp, PopUpClose;
	public Text PopUpText;
	public int openVisitCount;
	bool IsAlreadyOpen, IsAlreadyShow;

	public int EventExecuteVisit;

	// Use this for initialization

	void Start () {
		load ();
	}

	// Update is called once per frame
	void Update () {
		if (!DialogPanel.activeSelf) {
			if (VisitFriend.GetComponent<VisitFriend> ().VisitNumber >= EventExecuteVisit && !IsAlreadyShow) {
				IsAlreadyShow = true;
				SceneManager.LoadScene ("Owl Event");
			}

			if (VisitFriend.GetComponent<VisitFriend> ().VisitNumber >= openVisitCount) {
				ShopItem.GetComponent<Button> ().enabled = true;
				buyButton.GetComponent<Button> ().enabled = true;
				QuestionBox.SetActive (false);
				if (!IsAlreadyOpen) {
					PopUpText.text = "이제 상점에서 <빨래건조대>를 구입할 수 있습니다!";
					PopUpClose.SetActive (true);
					PopUp.SetActive (true);
					IsAlreadyOpen = true;
				}
			}
		}
		save ();
	}

	void save(){
		PlayerPrefs.SetString("laundryOPEN",IsAlreadyOpen.ToString());
		PlayerPrefs.SetString ("OwlEvent",IsAlreadyShow.ToString());
	}

	void load(){
		if (PlayerPrefs.HasKey ("OwlEvent"))
			IsAlreadyShow = (PlayerPrefs.GetString ("OwlEvent") == "True");
		else
			IsAlreadyShow = false;
		
		if(PlayerPrefs.HasKey("laundryOPEN"))
			IsAlreadyOpen = (PlayerPrefs.GetString ("laundryOPEN") == "True");
	}
}
