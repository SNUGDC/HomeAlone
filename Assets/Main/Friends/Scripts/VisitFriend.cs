using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class VisitFriend : MonoBehaviour {
	public Image FriendImage;
	public GameObject TalkBalloonImage;
	public string FriendNameVisit;
	public Text VisitCounter;
	public GameObject[] VisitItem;
	public int VisitProbability;
	public int BackProbability;
	int VisitNumber, n;
//	string LoadTime;

	DateTime SysTime;
//	DateTime LoadDateTime;
	DateTime UpdatedTime;
	TimeSpan Delta, Delta2;

	void Start () {
		Delta = new TimeSpan(0, 0, 5);		// friends visit,back per 5 second 
		Delta2 = new TimeSpan (0, 0, 5);	// save during 1 minute.
		SysTime = System.DateTime.Now;
		UpdatedTime = SysTime;

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
	}

	void back(){
		if (UnityEngine.Random.Range (1, 100) <= BackProbability) {
			FriendImage.GetComponent<Image>().enabled = false;
			TalkBalloonImage.SetActive (false);
			FriendList.VisitorNum--;
		}
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
}
