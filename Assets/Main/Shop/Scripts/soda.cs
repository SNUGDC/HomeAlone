using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class soda : MonoBehaviour {
	public GameObject VisitFriend, ShopItem, buyButton, QuestionBox, PopUp, PopUpClose;
	public Image Penguin;
	public Text PopUpText;
	public int openVisitCount;
	public static int sodaBoughtTimes;
	bool IsAlreadyOpen;

	// Use this for initialization

	void Start () {
		load ();
	}
	
	// Update is called once per frame
	void Update () {
		//soda event
		ShopItem.GetComponent<Item> ().load();
		if (ShopItem.GetComponent<Item> ().haveItem () && Penguin.enabled && sodaBoughtTimes < 2) {
			ShopItem.GetComponent<Item> ().decreaseItem ();
			sodaBoughtTimes++;
			SceneManager.LoadScene ("Penguin Event");
		}
		if (VisitFriend.GetComponent<VisitFriend> ().VisitNumber >= openVisitCount) {
			buyButton.GetComponent<Button> ().enabled = true;
			ShopItem.GetComponent<Button> ().enabled = true;
			QuestionBox.SetActive (false);
			if (!IsAlreadyOpen) {
				PopUpText.text = "이제 상점에서 <형제소다>를 구입할 수 있습니다!";
				PopUpClose.SetActive (true);
				PopUp.SetActive (true);
				IsAlreadyOpen = true;
			}
		}
		save ();
	}

	void save(){
		PlayerPrefs.SetString("sodaOPEN",IsAlreadyOpen.ToString());
		PlayerPrefs.SetInt("sodaBoughtTimes",sodaBoughtTimes);
	}

	void load(){
		sodaBoughtTimes = PlayerPrefs.GetInt("sodaBoughtTimes");
		if(PlayerPrefs.HasKey("sodaOPEN"))
			IsAlreadyOpen = (PlayerPrefs.GetString ("sodaOPEN") == "True");
	}
}
