using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class HappyEnding : MonoBehaviour {
	public Text text;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!text.enabled)
			GoToStart ();
	}

	public void GoToStart(){
		SceneManager.LoadScene("Start");
	}
}
