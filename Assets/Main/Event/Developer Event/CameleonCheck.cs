using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CameleonCheck : MonoBehaviour {
	public Text Title;
	public Button EventButton;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void developerShowCheck(){
		if (PlayerPrefs.GetString ("DeveloperShow") == "True") {
			Title.text = "개발진 후일담";
			EventButton.enabled = true;
		}
	}
}
