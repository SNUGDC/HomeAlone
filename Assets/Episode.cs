using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Episode : MonoBehaviour {
	public string[] conversation;
	public Text dialogText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SendText(){
		Dialog.AssignText (conversation);
		dialogText.text = conversation [0];
	}
}
