using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class VisitFriend : MonoBehaviour {
	public Image FriendImage;
	public GameObject TalkBalloonImage;
	public string FriendNameVisit;
	public Text VisitCounter;
	public int VisitProbability;
	public int BackProbability;
	int VisitNumber;
//	string LoadTime;

	DateTime SysTime;
//	DateTime LoadDateTime;
	DateTime UpdatedTime;
	TimeSpan Delta, Delta2;

	void Start () {
		Debug.Log("start");
		Delta = new TimeSpan(0, 0, 5);		// friends visit,back per 5 second 
		Delta2 = new TimeSpan (0, 0, 5);	// save during 1 minute.
		SysTime = System.DateTime.Now;
		UpdatedTime = SysTime;

		if (PlayerPrefs.HasKey (FriendNameVisit)) {
			VisitCounter.text = PlayerPrefs.GetString (FriendNameVisit);
			VisitNumber = IntParseFast(VisitCounter.text);
		}

		if (TimeCheck.TimeOver (Delta2)) {
			Debug.Log ("TimeOver!!");
			if (FriendImage.GetComponent<Image>().enabled == false) {
				visit ();
			} else
			{
				back ();}
		}
	}
	
	// Update is called once per frame
	void Update () {
		SysTime = System.DateTime.Now;
		if (TimeOver ()) {
			UpdatedTime = SysTime;
			if (FriendImage.GetComponent<Image>().enabled == false) visit ();
			else if (FriendImage.GetComponent<Image>().enabled) back ();
		}

		//save
/////**		PlayerPrefs.SetString("FriendTimer", SysTime.ToString());
		PlayerPrefs.SetString (FriendNameVisit, VisitCounter.text);
	}

	void visit(){
		if (FriendList.VisitorNum < FriendList.MaxVisitorNum) {
			Debug.Log("visit excute");
			if (UnityEngine.Random.Range (1, 100) <= VisitProbability) {
				Debug.Log("visit true");
				FriendImage.GetComponent<Image>().enabled = true;
				TalkBalloonImage.SetActive (true);
				FriendList.VisitorNum++;
				VisitNumber++;
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
}
