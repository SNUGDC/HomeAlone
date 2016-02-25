using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Friend2Item : MonoBehaviour {
	public GameObject Balloon, ShopItem1, ShopItem2, buyButton1,buyButton2, QuestionBox1,QuestionBox2, PopUp, PopUpClose;
	public Text PopUpText;
	public int NeedTalkCount;
	public string ItemName1, ItemName2, SaveName;
	bool IsAlreadyOpen;

	// Use this for initialization

	void Start () {
		Balloon.GetComponent<TalkBalloon> ().load ();
		load ();
	}

	// Update is called once per frame
	void Update () {
		if ((Balloon.GetComponent<TalkBalloon> ().NumberOfTalk() >= NeedTalkCount)) {
			ShopItem1.GetComponent<Button> ().enabled = true;
			ShopItem2.GetComponent<Button> ().enabled = true;
			buyButton1.GetComponent<Button> ().enabled = true;
			buyButton2.GetComponent<Button> ().enabled = true;
			QuestionBox1.SetActive (false);
			QuestionBox2.SetActive (false);
			if (!IsAlreadyOpen) {
				PopUpText.text = "이제 상점에서 <" + ItemName1 + ">와 <"+ItemName2 +">을 구입할 수 있습니다!";
				PopUpClose.SetActive (true);
				PopUp.SetActive (true);
				IsAlreadyOpen = true;
			}
		}
		save ();
	}

	void save(){
		PlayerPrefs.SetString(SaveName +"OPEN",IsAlreadyOpen.ToString());
	}

	void load(){
		if(PlayerPrefs.HasKey(SaveName +"OPEN"))
			IsAlreadyOpen = (PlayerPrefs.GetString (SaveName +"OPEN") == "True");
	}
}
