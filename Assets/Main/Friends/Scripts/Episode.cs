using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Episode : MonoBehaviour {
//	public Friend friend;
//	public Text TitleText;
	public string[] conversation;
//	public int NeedVisiting;
	public Text dialogText;

//	private Image myImage;
//	private Button myButton;

	void Start () {
//		myImage = GetComponent<Image>();
//		myButton = GetComponent<Button>();
	}
	

	void Update () {
		/*
		Debug.Log (friend.IntVisitCount);
		if (friend.IntVisitCount >= NeedVisiting){
			myImage.enabled = true;
			myButton.enabled = true;
			TitleText.enabled = true;
		}
		*/
	}

	public void SendText(){
		Dialog.AssignText (conversation);
		dialogText.text = conversation [0];
	}
}
