﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Episode : MonoBehaviour {
	public string[] conversation;
	public Text dialogText;

	void Start () {
	}
	

	void Update () {
	}

	public void SendText(){
		Dialog.AssignText (conversation);
		dialogText.text = conversation [0];
	}
}
