﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Dialog : MonoBehaviour {
	private static string[] conversation;
	public Text myText;
	public GameObject ThisEventMessage;
	int LineNumber;

	void Start () {
		LineNumber = 0;
	}

	void Update () {
		
	}

	public static void AssignText(string[] Text){
		conversation = Text;
	}

	public void OnMouseDown(){
		LineNumber++;
		if (LineNumber < conversation.Length) {
			myText.text = conversation[LineNumber];
		}
		else {
			ThisEventMessage.SetActive (false);
			LineNumber = 0;
		}
	}
}