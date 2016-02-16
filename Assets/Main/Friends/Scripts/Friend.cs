﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Friend : MonoBehaviour {
	public Text VisitCount;
	public GameObject QuestionBox;
	public GameObject[] heart;
	public int IntVisitCount;
	private Button myButton;
	// Use this for initialization
	void Start () {
		myButton = GetComponent<Button>();
	}

	// Update is called once per frame
	void Update () {
		IntVisitCount = VisitFriend.IntParseFast (VisitCount.text);
		AlbumUpdate ();
	}

	void AlbumUpdate(){
		switch(IntVisitCount){
		case 0:
			QuestionBox.SetActive (true);
			break;
		default:
			QuestionBox.SetActive (false);
			myButton.enabled = true;
			if (IntVisitCount >= 3)
				heart [0].SetActive (true);
			if (IntVisitCount >= 10)
				heart [1].SetActive (true);
			if (IntVisitCount >= 100)
				heart [2].SetActive (true);
			break;
		}
	}

	public void SendVisitNumber(Text Counter){
		Counter.text = IntVisitCount.ToString ();
	}

	public void HeartToRed1(Image red){
		red.enabled=false;
		if (IntVisitCount >= 3)
			red.enabled=true;
	}

	public void HeartToRed2(Image red){
		red.enabled=false;
		if (IntVisitCount >= 10)
			red.enabled=true;
	}

	public void HeartToRed3(Image red){
		red.enabled=false;
		if (IntVisitCount >= 100)
			red.enabled=true;
	}
}