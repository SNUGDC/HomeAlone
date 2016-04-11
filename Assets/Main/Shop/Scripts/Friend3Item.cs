using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// This is not a 3-item-open script........... Only 2 + 1...?

public class Friend3Item : MonoBehaviour {
	public GameObject DialogPanel, Balloon, ShopItem1, ShopItem2,ShopItem3, buyButton1,buyButton2,buyButton3, QuestionBox1,QuestionBox2,QuestionBox3, PopUp, PopUpClose;
	public Text PopUpText;
	public int NeedTalkCount, NeedTalkCount2;
	public string text, text2, SaveName;
	bool IsAlreadyOpen, IsAlreadyOpen2;

	// Use this for initialization

	void Start () {
		Balloon.GetComponent<TalkBalloon> ().load ();
		load ();
	}

	// Update is called once per frame
	void Update () {
		if ((Balloon.GetComponent<TalkBalloon> ().NumberOfTalk() >= NeedTalkCount) && !DialogPanel.activeSelf) {
			ShopItem1.GetComponent<Button> ().enabled = true;
			ShopItem2.GetComponent<Button> ().enabled = true;
//			ShopItem3.GetComponent<Button> ().enabled = true;
			buyButton1.GetComponent<Button> ().enabled = true;
			buyButton2.GetComponent<Button> ().enabled = true;
//			buyButton3.GetComponent<Button> ().enabled = true;
			QuestionBox1.SetActive (false);
			QuestionBox2.SetActive (false);
//			QuestionBox3.SetActive (false);
			if (!IsAlreadyOpen) {
				PopUpText.text = text;
				PopUpClose.SetActive (true);
				PopUp.SetActive (true);
				IsAlreadyOpen = true;
			}
		}

		if ((Balloon.GetComponent<TalkBalloon> ().NumberOfTalk() >= NeedTalkCount2) && !DialogPanel.activeSelf) {
			ShopItem3.GetComponent<Button> ().enabled = true;
			buyButton3.GetComponent<Button> ().enabled = true;
			QuestionBox3.SetActive (false);
			if (!IsAlreadyOpen2) {
				PopUpText.text = text2;
				PopUpClose.SetActive (true);
				PopUp.SetActive (true);
				IsAlreadyOpen2 = true;
			}
		}
		save ();
	}

	void save(){
		PlayerPrefs.SetString(SaveName +"OPEN",IsAlreadyOpen.ToString());
		PlayerPrefs.SetString (SaveName + "OPEN2", IsAlreadyOpen2.ToString ());
	}

	void load(){
		if(PlayerPrefs.HasKey(SaveName +"OPEN"))
			IsAlreadyOpen = (PlayerPrefs.GetString (SaveName +"OPEN") == "True");
		if (PlayerPrefs.HasKey (SaveName + "OPEN2"))
			IsAlreadyOpen2 = (PlayerPrefs.GetString (SaveName + "OPEN2") == "True");
	}
}
