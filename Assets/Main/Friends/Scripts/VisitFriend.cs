using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class VisitFriend : MonoBehaviour {
	public GameObject ThisObject;
	public Image FriendImage;
	public GameObject TalkBalloonImage;
	public string FriendNameVisit;
	public Text VisitCounter;
	public GameObject[] VisitItem;
	public string[] Seat;
	public Image[] SeatImage;
	public int VisitProbability;
	public int BackProbability;
	public int VisitNumber;
	int n, posNumber;
	public string myPos;

	public static Vector3 posBed1 = new Vector3(-5,0,0);
//	Vector3 posBed2 = new Vector3(270,210,0);
	public static Vector3 posFloor1 = new Vector3(-1,1,0);
	public static Vector3 posFloor2 = new Vector3(2,-1,0);
	public static Vector3 posDesk = new Vector3(1,1,0);
	public static Vector3 posLaundry = new Vector3(0,-2,0);

	public GameObject Laundry, table, cushion, crocobed, crocodesk;
	public static GameObject penguin, lion, crocodile, ammonite, owl, snake, sheep, bear;

	DateTime SysTime;
	DateTime UpdatedTime;
	TimeSpan Delta, Delta2;

	void Awake()
	{
		penguin = GameObject.Find ("Penguin_f");
		lion = GameObject.Find ("lion_f");
		crocodile = GameObject.Find ("crocodile_f");
		ammonite = GameObject.Find ("ammonite_f");
		owl = GameObject.Find ("owl_f");
		snake = GameObject.Find ("snake_f");
		sheep = GameObject.Find ("Sheep_f");
		bear = GameObject.Find ("bear_f");

		load ();
	}

	void Start () {
		if (!FriendList.Sleeping) {
			Delta = new TimeSpan (0, 0, 2);		// friends visit,back per 5 second 
			Delta2 = new TimeSpan (0, 0, 5);	// save during 1 minute.
			SysTime = System.DateTime.Now;
			UpdatedTime = SysTime;

			switch (myPos) {
			case("bed1"):
				if (ThisObject.GetComponent<VisitFriend> ().FriendNameVisit == "crocodileVisit" && !FriendList.bed2){
					ThisObject.transform.position = posBed1;
					crocobed.SetActive (true);
				}
				else {
					FriendImage.sprite = SeatImage [posNumber].sprite;
					ThisObject.transform.position = posBed1;
				}
				break;

//		case("bed2"):
//			ThisObject.transform.position = posBed2;
//			break;

			case("floor1"):
				if (ThisObject.GetComponent<VisitFriend> ().FriendNameVisit == "ammoniteVisit") {
					cushion.transform.position = posFloor1;
					cushion.GetComponent<Image>().enabled = true;
				}
				FriendImage.sprite = SeatImage [posNumber].sprite;
				ThisObject.transform.position = posFloor1;
				break;

			case("floor2"):
				if (ThisObject.GetComponent<VisitFriend> ().FriendNameVisit == "ammoniteVisit") {
					cushion.transform.position = posFloor2;
					cushion.GetComponent<Image>().enabled = true;
				}
				FriendImage.sprite = SeatImage [posNumber].sprite;
				ThisObject.transform.position = posFloor2;
				break;

			case("desk"):
				if (ThisObject.GetComponent<VisitFriend> ().FriendNameVisit == "crocodileVisit") {
					ThisObject.transform.position = posDesk;
					crocodesk.SetActive (true);
				}
				else {
					FriendImage.sprite = SeatImage [posNumber].sprite;
					ThisObject.transform.position = posDesk;
				}
				break;

			case("laundry"):
				Laundry.SetActive (false);
				FriendImage.sprite = SeatImage [posNumber].sprite;
				ThisObject.transform.position = posLaundry;
				break;
			}



			if (PlayerPrefs.HasKey (FriendNameVisit)) {
				VisitCounter.text = PlayerPrefs.GetString (FriendNameVisit);
				VisitNumber = IntParseFast (VisitCounter.text);
			}

			if (TimeCheck.TimeOver (Delta2)) {
				if (FriendImage.GetComponent<Image> ().enabled == false && ItemCheck ()) {
					visit ();
				} else if (FriendImage.GetComponent<Image> ().enabled) {
					back ();
				}
			}
		}
	}

	// Update is called once per frame
	void Update () {
		if (!FriendList.Sleeping) {
			SysTime = System.DateTime.Now;
			if (TimeOver ()) {
				UpdatedTime = SysTime;
				if ((FriendImage.GetComponent<Image> ().enabled == false) && ItemCheck ())
					visit ();
				else if (FriendImage.GetComponent<Image> ().enabled)
					back ();
			}

			//save
			PlayerPrefs.SetString (FriendNameVisit, VisitCounter.text);
		}
	}

	void visit(){
		if (snakeOK()) {
			if (UnityEngine.Random.Range (1, 100) <= VisitProbability) {
				int i = UnityEngine.Random.Range (0, Seat.Length);
				if (ThisObject.GetComponent<VisitFriend> ().FriendNameVisit == "lionVisit" && IsPartyTime())
					i = 1;
				else if (ThisObject.GetComponent<VisitFriend> ().FriendNameVisit == "lionVisit")
					i = 0;
				
				switch(Seat[i]){
				case("bed1"):
					if (!FriendList.bed1) {
						if (ThisObject.GetComponent<VisitFriend> ().FriendNameVisit == "crocodileVisit" && !FriendList.bed2) {
							ThisObject.transform.position = posBed1;
							FriendList.bed1 = true;
							myPos = "bed1";
							EnableImage ();
							crocobed.SetActive (true);
							player.playerPos ();
							posNumber = i;
						} else {
							ThisObject.transform.position = posBed1;
							FriendList.bed1 = true;
							myPos = "bed1";
							FriendImage.sprite = SeatImage [i].sprite;
							EnableImage ();
							player.playerPos ();
							posNumber = i;
						}
					}
					break;

//				case("bed2"):
//					if (!FriendList.bed2) {
//						ThisObject.transform.position = posBed2;
//						FriendList.bed2 = true;
//						myPos = "bed2";
//						EnableImage ();
//					}
//					break;

				case("floor1"):
					if (!FriendList.floor1) {
						if (ThisObject.GetComponent<VisitFriend> ().FriendNameVisit == "ammoniteVisit") {
							cushion.transform.position = posFloor1;
							cushion.GetComponent<Image>().enabled = true;
						}
						FriendList.floor1 = true;
						ThisObject.transform.position = posFloor1;
						myPos = "floor1";
						FriendImage.sprite = SeatImage [i].sprite;
						EnableImage ();
						player.playerPos();
						posNumber = i;
					}
					break;

				case("floor2"):
					if (!FriendList.floor2) {
						if (ThisObject.GetComponent<VisitFriend> ().FriendNameVisit == "ammoniteVisit") {
							cushion.transform.position = posFloor2;
							cushion.GetComponent<Image>().enabled = true;
						}
						ThisObject.transform.position = posFloor2;
						FriendList.floor2 = true;
						myPos = "floor2";
						FriendImage.sprite = SeatImage [i].sprite;
						EnableImage ();
						player.playerPos();
						posNumber = i;
					}
					break;

				case("desk"):
					if (!FriendList.desk) {
						if (ThisObject.GetComponent<VisitFriend> ().FriendNameVisit == "crocodileVisit") {
							ThisObject.transform.position = posDesk;
							FriendList.desk = true;
							myPos = "desk";
							EnableImage ();
							crocodesk.SetActive (true);
							player.playerPos ();
							posNumber = i;
						} else {
							ThisObject.transform.position = posDesk;
							FriendList.desk = true;
							myPos = "desk";
							FriendImage.sprite = SeatImage [i].sprite;
							EnableImage ();
							player.playerPos ();
							posNumber = i;
						}
					}
					break;

				case("laundry"):				// only lion!
					if (!FriendList.laundry) {
						ThisObject.transform.position = posLaundry;
						Laundry.SetActive (false);
						FriendList.laundry = true;
						myPos = "laundry";
						FriendImage.sprite = SeatImage [i].sprite;
						EnableImage ();
						player.playerPos();
						posNumber = i;
					}
					break;
				
				default:
					Debug.Log ("NULL!");
					break;
				}
			}
		}
		save ();
	}

	void back(){
		if (UnityEngine.Random.Range (1, 100) <= BackProbability) {
			switch (myPos) {
			case("bed1"):
				if (crocobed.activeSelf)
					crocobed.SetActive (false);
				FriendList.bed1 = false;
				disableImage ();
				break;

//			case("bed2"):
//				FriendList.bed2 = false;
//				break;

			case("floor1"):
				if (ThisObject.GetComponent<VisitFriend> ().FriendNameVisit == "ammoniteVisit") {
					cushion.GetComponent<Image>().enabled = false;
				}
				FriendList.floor1 = false;
				disableImage ();
				break;

			case("floor2"):
				if (ThisObject.GetComponent<VisitFriend> ().FriendNameVisit == "ammoniteVisit") {
					cushion.GetComponent<Image>().enabled = false;
				}
				FriendList.floor2 = false;
				disableImage ();
				break;

			case("desk"):
				if (crocodesk.activeSelf)
					crocodesk.SetActive (false);
				FriendList.desk = false;
				disableImage ();
				break;

			case("laundry"):
				Laundry.SetActive (true);
				FriendList.laundry = false;
				disableImage ();
				break;
			}
		}

		save ();
	}

	bool TimeOver()
	{
		if (SysTime - UpdatedTime >= Delta)
		{
			return true;
		}
		else return false;
	}

	public static int IntParseFast(string value)
	{
		int result = 0;
		for (int i = 0; i < value.Length; i++)
		{
			char letter = value[i];
			result = 10 * result + (letter - 48);
		}
		return result;
	}

	bool ItemCheck(){
		for (int i = 0; i < VisitItem.Length; i++) {
			VisitItem [i].GetComponent<Item> ().load ();
			if (VisitItem [i].GetComponent<Item> ().BoughtNumber > 0) {
				n = i;
				return true;
			};
		}
		return false;
	}

	void save(){
		PlayerPrefs.SetInt (FriendNameVisit + "posNumber" , posNumber);
		PlayerPrefs.SetString(FriendNameVisit + "myPos", myPos);
		PlayerPrefs.SetString("bed1",FriendList.bed1.ToString());
//		PlayerPrefs.SetString("bed2",FriendList.bed2.ToString());
		PlayerPrefs.SetString("floor1",FriendList.floor1.ToString());
		PlayerPrefs.SetString("floor2",FriendList.floor2.ToString());
		PlayerPrefs.SetString("desk",FriendList.desk.ToString());
		PlayerPrefs.SetString("laundry",FriendList.laundry.ToString());
	}

	void load(){
		posNumber = PlayerPrefs.GetInt (FriendNameVisit + "posNumber");
		if(PlayerPrefs.HasKey(FriendNameVisit + "myPos"))
			myPos = PlayerPrefs.GetString (FriendNameVisit + "myPos");
		FriendList.bed1 = (PlayerPrefs.GetString("bed1") == "True");
//		FriendList.bed2 = (PlayerPrefs.GetString("bed2") == "True");
		FriendList.floor1 = (PlayerPrefs.GetString("floor1") == "True");
		FriendList.floor2 = (PlayerPrefs.GetString("floor2") == "True");
		FriendList.desk = (PlayerPrefs.GetString("desk") == "True");
		FriendList.laundry = (PlayerPrefs.GetString("laundry") == "True");
	}

	void EnableImage(){
		Debug.Log (FriendNameVisit + " : " + myPos);
		FriendImage.GetComponent<Image>().enabled = true;
		TalkBalloonImage.SetActive (true);
		FriendList.VisitorNum++;
		VisitNumber++;
		Debug.Log (FriendList.VisitorNum);
		//VisitItem[n].GetComponent<Item> ().BoughtNumber--;
		VisitItem [n].GetComponent<Item> ().save ();
		VisitCounter.text = VisitNumber.ToString();
	}

	void disableImage(){
		myPos = "";
		Debug.Log (FriendNameVisit + "back");
		FriendImage.GetComponent<Image>().enabled = false;
		TalkBalloonImage.SetActive (false);
		FriendList.VisitorNum--;
	}

	bool snakeOK(){
		if (snake != null)
			return (ThisObject.GetComponent<VisitFriend> ().FriendNameVisit == "snakeVisit" && FriendList.VisitorNum == 0) || ((!snake.GetComponent<Image> ().enabled) && ThisObject.GetComponent<VisitFriend> ().FriendNameVisit != "snakeVisit");
		else
			return true;
	}

	bool IsPartyTime(){
		if (bear != null && sheep != null)
			return table.activeSelf && bear.GetComponent<Image> ().enabled && sheep.GetComponent<Image> ().enabled;
		else
			return false;
	}
}
