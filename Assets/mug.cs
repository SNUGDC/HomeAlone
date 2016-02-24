using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class mug : MonoBehaviour {
	public GameObject VisitFriend,ShopItem, buyButton, QuestionBox, PopUp, PopUpClose;
	public Text PopUpText;
	public int openVisitCount;
	bool IsAlreadyOpen;

	// Use this for initialization

	void Start () {
		load ();
	}

	// Update is called once per frame
	void Update () {
		if (VisitFriend.GetComponent<VisitFriend> ().VisitNumber >= openVisitCount) {
			ShopItem.GetComponent<Button> ().enabled = true;
			buyButton.GetComponent<Button> ().enabled = true;
			QuestionBox.SetActive (false);
			if (!IsAlreadyOpen) {
				PopUpText.text = "이제 상점에서 <머그컵 세트>를 구입할 수 있습니다!";
				PopUpClose.SetActive (true);
				PopUp.SetActive (true);
				IsAlreadyOpen = true;
			}
		}
		save ();
	}

	void save(){
		PlayerPrefs.SetString("mugOPEN",IsAlreadyOpen.ToString());
	}

	void load(){
		if(PlayerPrefs.HasKey("mugOPEN"))
			IsAlreadyOpen = (PlayerPrefs.GetString ("mugOPEN") == "True");
	}
}
