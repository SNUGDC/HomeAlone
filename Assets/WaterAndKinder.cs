using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WaterAndKinder : MonoBehaviour {
	public GameObject SheepBalloon, BearBalloon, ShopItem1, ShopItem2, buyButton1,buyButton2, QuestionBox1,QuestionBox2, PopUp, PopUpClose;
	public Text PopUpText;
	public int SheepTalkCount, BearTalkCount;
	bool IsAlreadyOpen;

	// Use this for initialization

	void Start () {
		SheepBalloon.GetComponent<TalkBalloon> ().load ();
		BearBalloon.GetComponent<TalkBalloon> ().load ();
		load ();
	}

	// Update is called once per frame
	void Update () {
		if ((SheepBalloon.GetComponent<TalkBalloon> ().NumberOfTalk() >= SheepTalkCount) && (BearBalloon.GetComponent<TalkBalloon> ().NumberOfTalk() >= BearTalkCount)) {
			ShopItem1.GetComponent<Button> ().enabled = true;
			ShopItem2.GetComponent<Button> ().enabled = true;
			buyButton1.GetComponent<Button> ().enabled = true;
			buyButton2.GetComponent<Button> ().enabled = true;
			QuestionBox1.SetActive (false);
			QuestionBox2.SetActive (false);
			if (!IsAlreadyOpen) {
				PopUpText.text = "이제 상점에서 <탄산수>와 <킨더초콜렛>을 구입할 수 있습니다!";
				PopUpClose.SetActive (true);
				PopUp.SetActive (true);
				IsAlreadyOpen = true;
			}
		}
		save ();
	}

	void save(){
		PlayerPrefs.SetString("WaterAndKinderOPEN",IsAlreadyOpen.ToString());
	}

	void load(){
		if(PlayerPrefs.HasKey("WaterAndKinderOPEN"))
			IsAlreadyOpen = (PlayerPrefs.GetString ("WaterAndKinderOPEN") == "True");
	}
}
