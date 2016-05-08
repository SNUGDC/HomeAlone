using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class soda : MonoBehaviour {
	public GameObject DialogPanel, VisitFriend, TalkBalloon_2, ShopItem, buyButton, QuestionBox, PopUp, PopUpClose;
	public Image Penguin;
	public Text PopUpText;
	public int openVisitCount;
	public static int sodaBoughtTimes;
	bool IsAlreadyOpen, IsAlreadyOpen2;

	// Use this for initialization

	void Start () {
		load ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!DialogPanel.activeSelf) {
			//soda event
			ShopItem.GetComponent<Item> ().load ();
			if (ShopItem.GetComponent<Item> ().haveItem () && Penguin.enabled && sodaBoughtTimes < 1) {
				ShopItem.GetComponent<Item> ().decreaseItem ();
				sodaBoughtTimes++;
				SceneManager.LoadScene ("Penguin Event");
			}

			//soda
			if (VisitFriend.GetComponent<VisitFriend> ().VisitNumber >= openVisitCount) {
				buyButton.GetComponent<Button> ().enabled = true;
				ShopItem.GetComponent<Button> ().enabled = true;
				QuestionBox.SetActive (false);
				if (!IsAlreadyOpen) {
					PopUpText.text = "이제 상점에서 <형제소다>를 구입할 수 있습니다!";
					PopUpClose.SetActive (true);
					PopUp.SetActive (true);
					IsAlreadyOpen = true;
				}
			}

			//Episode
			if (TalkBalloon_2.GetComponent<TalkBalloon> ().NumberOfTalk () == 20) {
				if (!IsAlreadyOpen2) {
					SceneManager.LoadScene ("PenguinEp");
					IsAlreadyOpen2 = true;
				}
			}
		}
		save ();
	}

	void save(){
		PlayerPrefs.SetString("sodaOPEN",IsAlreadyOpen.ToString());
		PlayerPrefs.SetString ("penguinEpisode", IsAlreadyOpen2.ToString ());
		PlayerPrefs.SetInt("sodaBoughtTimes",sodaBoughtTimes);
	}

	void load(){
		sodaBoughtTimes = PlayerPrefs.GetInt("sodaBoughtTimes");
		if(PlayerPrefs.HasKey("sodaOPEN"))
			IsAlreadyOpen = (PlayerPrefs.GetString ("sodaOPEN") == "True");
		if(PlayerPrefs.HasKey("penguinEpisode"))
			IsAlreadyOpen2 = (PlayerPrefs.GetString ("penguinEpisode") == "True");
	}
}
