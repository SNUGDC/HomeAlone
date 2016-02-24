using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gompang : MonoBehaviour {
	public GameObject ShopItem, buyButton, QuestionBox, PopUp, PopUpClose;
	public Text PopUpText;
	bool IsAlreadyOpen;
	public int StartMonth, EndMonth;
	int month;

	// Use this for initialization

	void Start () {
		load ();
	}

	// Update is called once per frame
	void Update () {
		month = PlayerPrefs.GetInt("Month");

		//	hour = PlayerPrefs.GetInt("Min");
		if ((StartMonth <= month) && (month < EndMonth)) {
			buyButton.GetComponent<Button> ().enabled = true;
			ShopItem.GetComponent<Button> ().enabled = true;
			QuestionBox.SetActive (false);
			if (!IsAlreadyOpen) {
				PopUpText.text = "특정 기간에만 나오는 곰팡이 제거제를 지금 상점에서 구입할 수 있습니다!";
				PopUpClose.SetActive (true);
				PopUp.SetActive (true);
				IsAlreadyOpen = true;
			}
		} else {
			buyButton.GetComponent<Button> ().enabled = false;
			if (IsAlreadyOpen) {
				ShopItem.GetComponent<Button> ().enabled = true;
				QuestionBox.SetActive (false);
			}
		}
		save ();
	}

	void save(){
		PlayerPrefs.SetString("gompangOPEN",IsAlreadyOpen.ToString());
	}

	void load(){
		if(PlayerPrefs.HasKey("gompangOPEN"))
			IsAlreadyOpen = (PlayerPrefs.GetString ("gompangOPEN") == "True");
	}
}
