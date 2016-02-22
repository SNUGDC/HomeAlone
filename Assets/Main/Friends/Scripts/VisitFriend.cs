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
	public int VisitProbability;
	public int BackProbability;
	int VisitNumber, n;
	string myPos;

	public static Vector3 posBed1 = new Vector3(-4,0,0);
//	Vector3 posBed2 = new Vector3(270,210,0);
	public static Vector3 posFloor1 = new Vector3(-2,1,0);
	public static Vector3 posFloor2 = new Vector3(2,-1,0);
	public static Vector3 posDesk = new Vector3(0,1,0);
	public static Vector3 posLaundry = new Vector3(0,-2,0);


	DateTime SysTime;
	DateTime UpdatedTime;
	TimeSpan Delta, Delta2;

	void Start () {
		Delta = new TimeSpan(0, 0, 2);		// friends visit,back per 5 second 
		Delta2 = new TimeSpan (0, 0, 5);	// save during 1 minute.
		SysTime = System.DateTime.Now;
		UpdatedTime = SysTime;

		load ();
		switch (myPos) {
		case("bed1"):
			ThisObject.transform.position = posBed1;
			break;

//		case("bed2"):
//			ThisObject.transform.position = posBed2;
//			break;

		case("floor1"):
			ThisObject.transform.position = posFloor1;
			break;

		case("floor2"):
			ThisObject.transform.position = posFloor2;
			break;

		case("desk"):
			ThisObject.transform.position = posDesk;
			break;

		case("laundry"):
			ThisObject.transform.position = posLaundry;
			break;
		}



		if (PlayerPrefs.HasKey (FriendNameVisit)) {
			VisitCounter.text = PlayerPrefs.GetString (FriendNameVisit);
			VisitNumber = IntParseFast(VisitCounter.text);
		}

		if (TimeCheck.TimeOver (Delta2)) {
			if (FriendImage.GetComponent<Image> ().enabled == false && ItemCheck ()) {
				visit ();
			} else if(FriendImage.GetComponent<Image> ().enabled) {
				back ();
			}
		}
	}

	// Update is called once per frame
	void Update () {
		SysTime = System.DateTime.Now;
		if (TimeOver ()) {
			UpdatedTime = SysTime;
			if ((FriendImage.GetComponent<Image>().enabled == false) && ItemCheck()) visit ();
			else if (FriendImage.GetComponent<Image>().enabled) back ();
		}

		//save
		PlayerPrefs.SetString (FriendNameVisit, VisitCounter.text);
	}

	void visit(){
		if (FriendList.VisitorNum < FriendList.MaxVisitorNum) {
			if (UnityEngine.Random.Range (1, 100) <= VisitProbability) {
				
				switch(Seat[UnityEngine.Random.Range(0,Seat.Length)]){
				case("bed1"):
					if (!FriendList.bed1) {
						ThisObject.transform.position = posBed1;
						FriendList.bed1 = true;
						myPos = "bed1";
						EnableImage ();
						player.playerPos();
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
						FriendList.floor1 = true;
						ThisObject.transform.position = posFloor1;
						myPos = "floor1";
						EnableImage ();
						player.playerPos();
					}
					break;

				case("floor2"):
					if (!FriendList.floor2) {
						ThisObject.transform.position = posFloor2;
						FriendList.floor2 = true;
						myPos = "floor2";
						EnableImage ();
						player.playerPos();
					}
					break;

				case("desk"):
					if (!FriendList.desk) {
						ThisObject.transform.position = posDesk;
						FriendList.desk = true;
						myPos = "desk";
						EnableImage ();
						player.playerPos();
					}
					break;

				case("laundry"):
					if (!FriendList.laundry) {
						ThisObject.transform.position = posLaundry;
						FriendList.laundry = true;
						myPos = "laundry";
						EnableImage ();
						player.playerPos();
					}
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
				FriendList.bed1 = false;
				break;

//			case("bed2"):
//				FriendList.bed2 = false;
//				break;

			case("floor1"):
				FriendList.floor1 = false;
				break;

			case("floor2"):
				FriendList.floor2 = false;
				break;

			case("desk"):
				FriendList.desk = false;
				break;

			case("laundry"):
				FriendList.laundry = false;
				break;
			}

			FriendImage.GetComponent<Image>().enabled = false;
			TalkBalloonImage.SetActive (false);
			FriendList.VisitorNum--;
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
		PlayerPrefs.SetString(FriendNameVisit + "myPos", myPos);
		PlayerPrefs.SetString("bed1",FriendList.bed1.ToString());
//		PlayerPrefs.SetString("bed2",FriendList.bed2.ToString());
		PlayerPrefs.SetString("floor1",FriendList.floor1.ToString());
		PlayerPrefs.SetString("floor2",FriendList.floor2.ToString());
		PlayerPrefs.SetString("desk",FriendList.desk.ToString());
		PlayerPrefs.SetString("laundry",FriendList.laundry.ToString());
	}

	void load(){
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
		VisitItem[n].GetComponent<Item> ().BoughtNumber--;
		VisitItem[n].GetComponent<Item>().HavingNumber.text = VisitItem[n].GetComponent<Item>().BoughtNumber + "개 보유";
		VisitItem [n].GetComponent<Item> ().save ();
		VisitCounter.text = VisitNumber.ToString();
	}
}
