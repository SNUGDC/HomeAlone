using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OpenTwoItem : MonoBehaviour {
	public GameObject VisitFriend, ShopItem1, ShopItem2, buyButton1, buyButton2, QuestionBox1, QuestionBox2, PopUp, PopUpClose;
	public Text PopUpText;
	public string text;
	public string savename;
	public int openVisitCount;
	bool IsAlreadyOpen;

	// Use this for initialization

	void Start () {
		load ();
	}

	// Update is called once per frame
	void Update () {
		if (VisitFriend.GetComponent<VisitFriend> ().VisitNumber >= openVisitCount) {
			ShopItem1.GetComponent<Button> ().enabled = true;
			ShopItem2.GetComponent<Button> ().enabled = true;
			buyButton1.GetComponent<Button> ().enabled = true;
			buyButton2.GetComponent<Button> ().enabled = true;
			QuestionBox1.SetActive (false);
			QuestionBox2.SetActive (false);
			if (!IsAlreadyOpen) {
				PopUpText.text = text;
//				PopUpText.text = "이제 상점에서 <하겐다즈 망고라즈베리 파인트>와 <접이식 테이블>을 구입할 수 있습니다!";
				PopUpClose.SetActive (true);
				PopUp.SetActive (true);
				IsAlreadyOpen = true;
			}
		}
		save ();
	}

	void save(){
		PlayerPrefs.SetString(savename+ "OPEN",IsAlreadyOpen.ToString());
	}

	void load(){
		if(PlayerPrefs.HasKey(savename+ "OPEN"))
			IsAlreadyOpen = (PlayerPrefs.GetString (savename+ "OPEN") == "True");
	}
}
