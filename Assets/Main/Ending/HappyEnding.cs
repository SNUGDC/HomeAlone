using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class HappyEnding : MonoBehaviour {
	public Image TextImage;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetString("WhatIsEnd", "HappyEnding");
	}
	
	// Update is called once per frame
	void Update () {
		if (!TextImage.enabled)
			GoToStart ();
	}

	public void GoToStart(){
		SceneManager.LoadScene("Start");
	}
}
