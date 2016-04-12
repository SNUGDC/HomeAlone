using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class OpenThreeItem : MonoBehaviour {
	public GameObject DialogPanel, VisitFriend, ShopItem1, ShopItem2,ShopItem3, buyButton1, buyButton2,buyButton3, QuestionBox1, QuestionBox2,QuestionBox3, PopUp, PopUpClose;
	public Text PopUpText;
	public string text, text2;
	public string savename;
	public int openVisitCount,openVisitCount2;
	bool IsAlreadyOpen,IsAlreadyOpen2, IsAlreadyShow;

	// Use this for initialization

	void Start () {
		load ();
	}

	// Update is called once per frame
	void Update () {
		// ShopItem3 = banana (crocodile banana event)
		ShopItem3.GetComponent<Item> ().load();
		if (ShopItem3.GetComponent<Item> ().haveItem() && VisitFriend.GetComponent<Image>().enabled && !IsAlreadyShow) {
			IsAlreadyShow = true;
			SceneManager.LoadScene ("Crocodile Event");
		}


		if (VisitFriend.GetComponent<VisitFriend> ().VisitNumber >= openVisitCount && !DialogPanel.activeSelf) {
//			ShopItem1.GetComponent<Button> ().enabled = true;
			ShopItem2.GetComponent<Button> ().enabled = true;
			ShopItem3.GetComponent<Button> ().enabled = true;
//			buyButton1.GetComponent<Button> ().enabled = true;
			buyButton2.GetComponent<Button> ().enabled = true;
			buyButton3.GetComponent<Button> ().enabled = true;
//			QuestionBox1.SetActive (false);
			QuestionBox2.SetActive (false);
			QuestionBox3.SetActive (false);
			if (!IsAlreadyOpen) {
				PopUpText.text = text;
				//				PopUpText.text = "이제 상점에서 <하겐다즈 망고라즈베리 파인트>와 <접이식 테이블>을 구입할 수 있습니다!";
				PopUpClose.SetActive (true);
				PopUp.SetActive (true);
				IsAlreadyOpen = true;
			}
		}

		if (VisitFriend.GetComponent<VisitFriend> ().VisitNumber >= openVisitCount2 && !DialogPanel.activeSelf) {
			ShopItem1.GetComponent<Button> ().enabled = true;
			buyButton1.GetComponent<Button> ().enabled = true;
			QuestionBox1.SetActive (false);

			if (!IsAlreadyOpen2) {
				PopUpText.text = text2;
				//				PopUpText.text = "이제 상점에서 <하겐다즈 망고라즈베리 파인트>와 <접이식 테이블>을 구입할 수 있습니다!";
				PopUpClose.SetActive (true);
				PopUp.SetActive (true);
				IsAlreadyOpen2 = true;
			}
		}

		save ();
	}

	void save(){
		PlayerPrefs.SetString(savename+ "OPEN",IsAlreadyOpen.ToString());
		PlayerPrefs.SetString(savename+ "OPEN2",IsAlreadyOpen2.ToString());
		PlayerPrefs.SetString ("CrocoEvent",IsAlreadyShow.ToString());
	}

	void load(){
		if(PlayerPrefs.HasKey("CrocoEvent"))
			IsAlreadyShow = (PlayerPrefs.GetString ("CrocoEvent") == "True");
		else
			IsAlreadyShow = false;
		
		if(PlayerPrefs.HasKey(savename+ "OPEN"))
			IsAlreadyOpen = (PlayerPrefs.GetString (savename+ "OPEN") == "True");
		if(PlayerPrefs.HasKey(savename+ "OPEN2"))
			IsAlreadyOpen2 = (PlayerPrefs.GetString (savename+ "OPEN2") == "True");
	}
}
