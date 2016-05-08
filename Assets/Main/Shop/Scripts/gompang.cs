using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gompang : MonoBehaviour {
	public GameObject DialogPanel, ShopItem, buyButton, QuestionBox, PopUp, PopUpClose, Wall_gompang;
	public Text PopUpText;
	bool IsAlreadyOpen, CameleonEventShow;
	public int StartMonth, Startday, EndMonth;
	int month, day;

	// Use this for initialization

	void Start () {
		load ();
		CameleonEventShow = (PlayerPrefs.GetString ("CameleonEventShow") == "True");
	}

	// Update is called once per frame
	void Update () {
		day = PlayerPrefs.GetInt("Day");
		month = PlayerPrefs.GetInt("Month");
		if (!DialogPanel.activeSelf) {
			CameleonEventShow = (PlayerPrefs.GetString ("CameleonEventShow") == "True");
			if ((ShopItem.GetComponent<Item> ().haveItem ()) && !CameleonEventShow) {
				Wall_gompang.GetComponent<Image> ().enabled = true;
				Wall_gompang.GetComponent<Button> ().enabled = true;
			}

			//	hour = PlayerPrefs.GetInt("Min");
			if (((StartMonth == month) && (day >= Startday)) || ((month > StartMonth) && (month < EndMonth))) {
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
