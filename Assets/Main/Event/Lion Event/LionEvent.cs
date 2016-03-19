﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LionEvent : MonoBehaviour {
	public GameObject lion1, lion2, lion3;
	public GameObject Dialog;

	// Use this for initialization

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ImageChange(){
		if (Dialog.GetComponent<Dialog> ().LineNumber == 2) {
			lion1.GetComponent<Image> ().enabled = false;
			lion2.GetComponent<Image> ().enabled = true;
		}
		else if (Dialog.GetComponent<Dialog> ().LineNumber == 3) {
			lion2.GetComponent<Image> ().enabled = false;
			lion3.GetComponent<Image> ().enabled = true;
		}
		else if (Dialog.GetComponent<Dialog> ().LineNumber == 5) {
			lion3.GetComponent<Image> ().enabled = false;
			lion2.GetComponent<Image> ().enabled = true;
		}
		else if (Dialog.GetComponent<Dialog> ().LineNumber == 6) {
			lion2.GetComponent<Image> ().enabled = false;
			lion3.GetComponent<Image> ().enabled = true;
			lion3.GetComponent<Button> ().enabled = true;
		}
	}

	public void ChangeScene(){
		Invoke("GoToMain" , 5);
	}

	void GoToMain(){
		SceneManager.LoadScene ("Main");
	}
}