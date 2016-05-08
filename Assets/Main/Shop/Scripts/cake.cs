using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class cake : MonoBehaviour {
	public GameObject Cake, DialogPanel, ShopItem, buyButton, QuestionBox, PopUp, PopUpClose;
	public Text PopUpText;
	bool IsAlreadyOpen;
	public int StartMonth1,StartMonth2, StartDay1,StartDay2, EndMonth1,EndMonth2,EndDay1,EndDay2;
	int month,day;

	// Use this for initialization

	void Start () {
		load ();
	}

	// Update is called once per frame
	void Update () {
		month = PlayerPrefs.GetInt("Month");
		day = PlayerPrefs.GetInt("Day");

		if (IsAlreadyOpen)
			Cake.SetActive (true);
		
		if (!DialogPanel.activeSelf) {
			if (((StartMonth1 <= month) && (StartDay1 <= day) && (month <= EndMonth1) && (day <= EndDay1)) || ((StartMonth2 <= month) && (StartDay2 <= day) && (month <= EndMonth2) && (day <= EndDay2))) {
				Cake.SetActive (true);
				buyButton.GetComponent<Button> ().enabled = true;
				ShopItem.GetComponent<Button> ().enabled = true;
				QuestionBox.SetActive (false);
				if (!IsAlreadyOpen) {
					PopUpText.text = "특정 기간에만 나오는 케이크를 지금 상점에서 구입할 수 있습니다!";
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
		PlayerPrefs.SetString("cakeOPEN",IsAlreadyOpen.ToString());
	}

	void load(){
		if(PlayerPrefs.HasKey("cakeOPEN"))
			IsAlreadyOpen = (PlayerPrefs.GetString ("cakeOPEN") == "True");
	}
}
