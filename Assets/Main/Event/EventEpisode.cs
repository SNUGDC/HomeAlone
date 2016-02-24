using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EventEpisode : MonoBehaviour {
	public string[] conversation;
	public Text dialogText;

	void Start () {
		SendText ();
	}


	void Update () {
	}

	public void SendText(){
		Dialog.AssignText (conversation);
		dialogText.text = conversation [0];
	}
}
