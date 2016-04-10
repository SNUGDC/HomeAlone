using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Budwiser : MonoBehaviour {
	public GameObject DialogPanel, ShopItem, buyButton, QuestionBox, PopUp, PopUpClose;
	public Text PopUpText;
	bool IsAlreadyOpen;
	public int StartHour, EndHour;
	int hour;

	// Use this for initialization

	void Start () {
		load ();
	}

	// Update is called once per frame
	void Update () {
		hour = PlayerPrefs.GetInt("Hour");
	//	hour = PlayerPrefs.GetInt("Min");
		if (!DialogPanel.activeSelf) {
			if ((StartHour <= hour) || (hour < EndHour)) {
				buyButton.GetComponent<Button> ().enabled = true;
				ShopItem.GetComponent<Button> ().enabled = true;
				QuestionBox.SetActive (false);
				if (!IsAlreadyOpen) {
					PopUpText.text = "늦은 시간에만 구입할 수 있는 <버드미사일>! 지금 상점에서 구입할 수 있습니다.";
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
		PlayerPrefs.SetString("budOPEN",IsAlreadyOpen.ToString());
	}

	void load(){
		if(PlayerPrefs.HasKey("budOPEN"))
			IsAlreadyOpen = (PlayerPrefs.GetString ("budOPEN") == "True");
	}
}
