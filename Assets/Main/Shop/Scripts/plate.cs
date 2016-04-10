using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class plate : MonoBehaviour {
	public GameObject DialogPanel, VisitFriend,ShopItem, buyButton, QuestionBox, PopUp, PopUpClose;
	public Text PopUpText;
	public int openVisitCount;
	public int lionEventVisitNumber;
	bool IsAlreadyOpen;
	bool IsAlreadyShow;

	// Use this for initialization

	void Start () {
		load ();
		if (PlayerPrefs.HasKey ("LionEvent"))
			IsAlreadyShow = (PlayerPrefs.GetString ("LionEvent") == "True");
		else
			IsAlreadyShow = false;
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
