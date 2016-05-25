using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class plate : MonoBehaviour {
	public GameObject DialogPanel, VisitFriend,ShopItem, buyButton, QuestionBox, PopUp, PopUpClose;
	public Text PopUpText;
	public int openVisitCount;
	public int lionEventVisitNumber,lionEventVisitNumber2;
	bool IsAlreadyOpen;
	bool IsAlreadyShow,IsAlreadyShow2;

	// Use this for initialization

	void Start () {
		load ();
		if (PlayerPrefs.HasKey ("LionEvent"))
			IsAlreadyShow = (PlayerPrefs.GetString ("LionEvent") == "True");
		else
			IsAlreadyShow = false;
		
		IsAlreadyShow2 = (PlayerPrefs.GetString ("SheepEvent2") == "True");
	}

	// Update is called once per frame
	void Update () {
		if (!DialogPanel.activeSelf) {
			//event
			if (VisitFriend.GetComponent<VisitFriend> ().VisitNumber >= lionEventVisitNumber && !IsAlreadyShow) {
				IsAlreadyShow = true;
				SceneManager.LoadScene ("Lion Event");
				PlayerPrefs.SetString ("LionEvent", IsAlreadyShow.ToString ());
			}

			//event2 - sheep&lion
			else if (VisitFriend.GetComponent<VisitFriend> ().VisitNumber >= lionEventVisitNumber2 && !IsAlreadyShow2) {
				IsAlreadyShow2 = true;
				SceneManager.LoadScene ("Sheep Event2");
			}

			if (VisitFriend.GetComponent<VisitFriend> ().VisitNumber >= openVisitCount) {
				ShopItem.GetComponent<Button> ().enabled = true;
				buyButton.GetComponent<Button> ().enabled = true;
				QuestionBox.SetActive (false);
				if (!IsAlreadyOpen) {
					PopUpText.text = "이제 상점에서 <접시 세트>를 구입할 수 있습니다!";
					PopUpClose.SetActive (true);
					PopUp.SetActive (true);
					IsAlreadyOpen = true;
				}
			}
		}
		save ();
	}

	void save(){
		PlayerPrefs.SetString("plateOPEN",IsAlreadyOpen.ToString());
	}

	void load(){
		if(PlayerPrefs.HasKey("plateOPEN"))
			IsAlreadyOpen = (PlayerPrefs.GetString ("plateOPEN") == "True");
	}
}
