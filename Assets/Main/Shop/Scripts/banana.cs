using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class banana : MonoBehaviour {
	public GameObject VisitFriend, ShopItem,  buyButton, QuestionBox, PopUp, PopUpClose;
	public Image Croco;
	public Text PopUpText;
	public int openVisitCount;
	bool IsAlreadyOpen, IsAlreadyShow;

	// Use this for initialization

	void Start () {
		load ();
	}

	// Update is called once per frame
	void Update () {
		//soda event
		ShopItem.GetComponent<Item> ().load();
		if (ShopItem.GetComponent<Item> ().haveItem() && Croco.enabled && !IsAlreadyShow) {
			IsAlreadyShow = true;
			SceneManager.LoadScene ("Crocodile Event");
		}

		if (VisitFriend.GetComponent<VisitFriend> ().VisitNumber >= openVisitCount) {
			ShopItem.GetComponent<Button> ().enabled = true;
			buyButton.GetComponent<Button> ().enabled = true;
			QuestionBox.SetActive (false);
			if (!IsAlreadyOpen) {
				PopUpText.text = "이제 상점에서 <바나나>를 구입할 수 있습니다!";
				PopUpClose.SetActive (true);
				PopUp.SetActive (true);
				IsAlreadyOpen = true;
			}
		}
		save ();
	}

	void save(){
		PlayerPrefs.SetString("bananaOPEN",IsAlreadyOpen.ToString());
		PlayerPrefs.SetString ("CrocoEvent",IsAlreadyShow.ToString());
	}

	void load(){
		if(PlayerPrefs.HasKey("CrocoEvent"))
			IsAlreadyShow = (PlayerPrefs.GetString ("CrocoEvent") == "True");
		else
			IsAlreadyShow = false;
		
		if(PlayerPrefs.HasKey("bananaOPEN"))
			IsAlreadyOpen = (PlayerPrefs.GetString ("bananaOPEN") == "True");
	}
}
