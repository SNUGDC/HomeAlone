using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class CushionOpen : MonoBehaviour {
	public GameObject DialogPanel, VisitFriend, ShopItem, buyButton, QuestionBox, PopUp, PopUpClose;
	public Text PopUpText;
	public int openVisitCount, eventVisitCount;
	bool IsAlreadyOpen, IsAlreadyShow;

	// Use this for initialization

	void Start () {
		load ();
	}

	// Update is called once per frame
	void Update () {
		// ammonite event
		if (VisitFriend.GetComponent<VisitFriend> ().VisitNumber >= eventVisitCount && VisitFriend.GetComponent<Image>().enabled && !IsAlreadyShow) {
			IsAlreadyShow = true;
			SceneManager.LoadScene ("Ammonite Event");
		}


		if (!DialogPanel.activeSelf) {
			if (VisitFriend.GetComponent<VisitFriend> ().VisitNumber >= openVisitCount) {
				buyButton.GetComponent<Button> ().enabled = true;
				ShopItem.GetComponent<Button> ().enabled = true;
				QuestionBox.SetActive (false);
				if (!IsAlreadyOpen) {
					PopUpText.text = "이제 상점에서 <쿠션>을 구입할 수 있습니다!";
					PopUpClose.SetActive (true);
					PopUp.SetActive (true);
					IsAlreadyOpen = true;
				}
			}
		}
		save ();
	}

	void save(){
		PlayerPrefs.SetString("cushionOPEN",IsAlreadyOpen.ToString());
		PlayerPrefs.SetString("AmmoEvent",IsAlreadyShow.ToString());
	}

	void load(){
		if(PlayerPrefs.HasKey("cushionOPEN"))
			IsAlreadyOpen = (PlayerPrefs.GetString ("cushionOPEN") == "True");
		if(PlayerPrefs.HasKey("AmmoEvent"))
			IsAlreadyShow = (PlayerPrefs.GetString ("AmmoEvent") == "True");
	}
}
