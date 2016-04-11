using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class VisitFriend : MonoBehaviour {
	public GameObject ThisObject;
	public Image FriendImage;
	public GameObject TalkBalloonImage,TalkBalloonImage2;
	public string FriendNameVisit;
	public Text VisitCounter;
	public GameObject[] VisitItem;
	public string[] Seat;
	public Image[] SeatImage, EventImage;
	public int VisitProbability;
	public int BackProbability;
	public int VisitNumber;
	int n, posNumber;
	public string myPos;

	public bool itemVisible;

	public static Vector3 posBed1 = new Vector3(-5,0,0);
	public static Vector3 posCrocoBed = new Vector3(-7,1,0);
//	Vector3 posBed2 = new Vector3(270,210,0);
	public static Vector3 posFloor1 = new Vector3(-1,1,0);
	public static Vector3 posFloor2 = new Vector3(2,-1,0);
	public static Vector3 posDesk = new Vector3(0.6f,0.6f,0);
	public static Vector3 posCrocoDesk = new Vector3(1,0,0);
	public static Vector3 posLaundry = new Vector3(0,-2,0);

	public GameObject ShopLaundry, hagendaz, Laundry, LaundryFold, table, cushion, crocobed, crocodesk;
	public static GameObject penguin, lion, crocodile, ammonite, owl, snake, sheep, bear;

	private int RandomNumber, saveNumber;

	private static GameObject window, crocohagen;
	private static bool windowCheck;

	private static bool AmmoOpened;

	DateTime SysTime;
	DateTime UpdatedTime;
	TimeSpan Delta, Delta2;

	void Awake()
	{
		crocohagen = GameObject.Find ("desk_hagen");
		window = GameObject.Find ("window");
		windowCheck = false;
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
		AmmoOpened = (PlayerPrefs.GetString ("AmmoOpened") == "True");
		if (ThisObject.GetComponent<VisitFriend> ().FriendNameVisit == "ammoniteVisit" && !AmmoOpened) {
			AmmoOpened = true;
			PlayerPrefs.SetString ("AmmoOpened", "True");

			int month = PlayerPrefs.GetInt ("Month");
			int day = PlayerPrefs.GetInt ("Day");
			PlayerPrefs.SetInt ("AmmoMonth", month);
			PlayerPrefs.SetInt ("AmmoDay", day);
		}

		load ();

		if (!FriendList.Sleeping) {
			//default: 0,0,7
			Delta = new TimeSpan (0, 0, 7);		// friends visit,back per 5 second 
			Delta2 = new TimeSpan (0, 0, 7);	// save during 1 minute.
			SysTime = System.DateTime.Now;
			UpdatedTime = SysTime;

			switch (myPos) {
			case("bed1"):
				// not bed2 option...
				if (ThisObject.GetComponent<VisitFriend> ().FriendNameVisit == "crocodileVisit"){
					ThisObject.transform.position = posCrocoBed;
					crocobed.SetActive (true);
					player.RoomBed.SetActive (false);
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
					ThisObject.transform.position = posCrocoDesk;
					if (PlayerPrefs.GetInt ("hagendazBoughtNumber") == 0)
						crocodesk.SetActive (true);
					else
						crocohagen.GetComponent<Image> ().enabled = true;
				}
				else {
					FriendImage.sprite = SeatImage [posNumber].sprite;
					ThisObject.transform.position = posDesk;
				}
				break;

			case("laundry"):
				Laundry.SetActive (false);
				if(ShopLaundry.GetComponent<Item>().BoughtNumber > 0)
					LaundryFold.SetActive (true);
				FriendImage.sprite = SeatImage [posNumber].sprite;
				ThisObject.transform.position = posLaundry;
				break;
			}

			if (TimeCheck.TimeOver (Delta2)) {
				if (FriendImage.GetComponent<Image> ().enabled == false && ItemCheck ()) {
					visit ();
				} else if (FriendImage.GetComponent<Image> ().enabled) {
					back ();
				}
			}
		}

		if (PlayerPrefs.HasKey (FriendNameVisit)) {
			VisitCounter.text = PlayerPrefs.GetString (FriendNameVisit);
			VisitNumber = IntParseFast (VisitCounter.text);
		}
	}

	// Update is called once per frame
	void Update () {
		if (!windowCheck) {
			Debug.Log ("window check");
			window.GetComponent<window> ().enabled = true;
			windowCheck = true;
		}
//		RandomNumber = UnityEngine.Random.Range (0, TalkBalloonImage.GetComponent<TalkBalloon>().EnableTalkList.Count-1);
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
						// !bed2 option..
						if (ThisObject.GetComponent<VisitFriend> ().FriendNameVisit == "crocodileVisit") {
							ThisObject.transform.position = posCrocoBed;
							FriendList.bed1 = true;
							myPos = "bed1";
							EnableImage ();
							crocobed.SetActive (true);
							player.RoomBed.SetActive (false);
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
							ThisObject.transform.position = posCrocoDesk;
							FriendList.desk = true;
							myPos = "desk";
							EnableImage ();
							//crocodesk.SetActive (true);
							if (hagendaz.GetComponent<Item> ().BoughtNumber == 0)
								crocodesk.SetActive (true);
							else
								crocohagen.GetComponent<Image> ().enabled = true;
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
						if(ShopLaundry.GetComponent<Item>().BoughtNumber > 0)
							LaundryFold.SetActive (true);
						FriendList.laundry = true;
						myPos = "laundry";
						FriendImage.sprite = SeatImage [i].sprite;
						EnableImage ();
						player.playerPos();
						posNumber = i;
					}
					break;
				
				default:
//					Debug.Log ("NULL!");
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
				if (crocobed.activeSelf) {
					crocobed.SetActive (false);
					player.RoomBed.SetActive (true);
				}
				FriendList.bed1 = false;
				disableImage ();
				break;

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
				if (crocohagen.GetComponent<Image> ().enabled)
					crocohagen.GetComponent<Image> ().enabled = false;
				FriendList.desk = false;
				disableImage ();
				break;

			case("laundry"):
				if(ShopLaundry.GetComponent<Item>().BoughtNumber > 0){
					Laundry.SetActive (true);
					LaundryFold.SetActive (false);
				}
				FriendList.laundry = false;
				disableImage ();
				break;

			case(""):
				//bug!!
				if (ThisObject.GetComponent<VisitFriend> ().FriendNameVisit == "ammoniteVisit") {
					cushion.GetComponent<Image> ().enabled = false;
				}
				if (ThisObject.GetComponent<VisitFriend> ().FriendNameVisit == "crocodileVisit") {
					crocodesk.SetActive (false);
					crocohagen.GetComponent<Image> ().enabled = false;
				}
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
		PlayerPrefs.SetString("bed2",FriendList.bed2.ToString());
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
		FriendList.bed2 = (PlayerPrefs.GetString("bed2") == "True");
		FriendList.floor1 = (PlayerPrefs.GetString("floor1") == "True");
		FriendList.floor2 = (PlayerPrefs.GetString("floor2") == "True");
		FriendList.desk = (PlayerPrefs.GetString("desk") == "True");
		FriendList.laundry = (PlayerPrefs.GetString("laundry") == "True");
	}

	void EnableImage(){
		TalkBalloonImage.GetComponent<TalkBalloon> ().load();
		TalkBalloonImage2.GetComponent<TalkBalloon> ().load();
		SetEnableTalkList ();
		if (TalkBalloonImage.GetComponent<TalkBalloon> ().EnableTalkList.Count > 0) {
			RandomNumber = UnityEngine.Random.Range (0, TalkBalloonImage.GetComponent<TalkBalloon> ().EnableTalkList.Count);
			Debug.Log (TalkBalloonImage.GetComponent<TalkBalloon> ().EnableTalkList.Count);
			saveNumber = TalkBalloonImage.GetComponent<TalkBalloon> ().EnableTalkList [RandomNumber];
		} else
			saveNumber = 0;
//		int talkNumber = TalkBalloonImage.GetComponent<TalkBalloon> ().whatTalk (saveNumber);
		FriendImage.GetComponent<Image>().enabled = true;
		if (IsAlreadyShow (saveNumber)) {
			TalkBalloonImage.SetActive (true);
			TalkBalloonImage.GetComponent<TalkBalloon> ().SaveTalkNumber = saveNumber;
			TalkBalloonImage.GetComponent<TalkBalloon> ().save();
//			Debug.Log (FriendNameVisit + " VisitTalkNumber SAVE : " + talkNumber);
		} else {
			TalkBalloonImage2.SetActive (true);
			TalkBalloonImage2.GetComponent<TalkBalloon> ().SaveTalkNumber = saveNumber;
			TalkBalloonImage2.GetComponent<TalkBalloon> ().save();
//			Debug.Log (FriendNameVisit + " VisitTalkNumber SAVE : " + talkNumber);
		}
		FriendList.VisitorNum++;
		VisitNumber++;
//		Debug.Log (FriendList.VisitorNum);
		//VisitItem[n].GetComponent<Item> ().BoughtNumber--;
		VisitItem [n].GetComponent<Item> ().save ();
		VisitCounter.text = VisitNumber.ToString();
	}

	void disableImage(){
		myPos = "";
//		Debug.Log (FriendNameVisit + "back");
		FriendImage.GetComponent<Image>().enabled = false;
		TalkBalloonImage.SetActive (false);
		TalkBalloonImage2.SetActive (false);
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

	bool IsAlreadyShow(int randNum){
		//int talkNum = TalkBalloonImage.GetComponent<TalkBalloon> ().whatTalk (randNum);
		return TalkBalloonImage.GetComponent<TalkBalloon> ().alreadyShow (randNum);
	}

	void SetEnableTalkList(){
		//clear
		TalkBalloonImage.GetComponent<TalkBalloon> ().EnableTalkList.Clear ();
		TalkBalloonImage2.GetComponent<TalkBalloon> ().EnableTalkList.Clear ();

		int friendly = HowFriendly ();
		// i = index
		// insert EnableTalkList
		for (int i = 0; i < TalkBalloonImage.GetComponent<TalkBalloon> ().howFriendly.Length; i++) {
			if (TalkBalloonImage.GetComponent<TalkBalloon> ().howFriendly [i] <= friendly) {
				TalkBalloonImage.GetComponent<TalkBalloon> ().EnableTalkList.Add (i);
				TalkBalloonImage2.GetComponent<TalkBalloon> ().EnableTalkList.Add (i);
			}
		}
	}

	public int HowFriendly(){
		if (VisitNumber < 1)
			return 0;
		else if (VisitNumber < 10)
			return 1;
		else if (VisitNumber < 40)
			return 2;
		else
			return 3;
	}

}
