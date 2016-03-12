using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Friend3Item : MonoBehaviour {
	public GameObject Balloon, ShopItem1, ShopItem2,ShopItem3, buyButton1,buyButton2,buyButton3, QuestionBox1,QuestionBox2,QuestionBox3, PopUp, PopUpClose;
	public Text PopUpText;
	public int NeedTalkCount;
	public string text, SaveName;
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
			ShopItem3.GetComponent<Button> ().enabled = true;
			buyButton1.GetComponent<Button> ().enabled = true;
			buyButton2.GetComponent<Button> ().enabled = true;
			buyButton3.GetComponent<Button> ().enabled = true;
			QuestionBox1.SetActive (false);
			QuestionBox2.SetActive (false);
			QuestionBox3.SetActive (false);
			if (!IsAlreadyOpen) {
				PopUpText.text = text;
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
