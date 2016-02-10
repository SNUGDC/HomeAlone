using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class VisitFriend : MonoBehaviour {
	public GameObject FriendImage;
	public string FriendNameVisit;
	public Text VisitCounter;
	public int VisitProbability;
	public int BackProbability;
	int VisitNumber;
	string LoadTime;

	DateTime SysTime, LoadDateTime;
	DateTime UpdatedTime;
	TimeSpan Delta, Delta2;

	void Start () {
		Delta = new TimeSpan(0, 0, 5);
		Delta2 = new TimeSpan (0, 1, 0);
		SysTime = System.DateTime.Now;
		UpdatedTime = SysTime;

		//load
		if (PlayerPrefs.HasKey ("FriendTimer")) {
			LoadTime = PlayerPrefs.GetString ("FriendTimer");
			LoadDateTime = System.DateTime.Parse (LoadTime);

			if (SysTime - LoadDateTime > Delta2) {
				if (FriendImage.activeSelf == false)
					visit ();
				else
					back ();
			}
		}

		if (PlayerPrefs.HasKey (FriendNameVisit)) {
			VisitCounter.text = PlayerPrefs.GetString (FriendNameVisit);
			VisitNumber = IntParseFast(VisitCounter.text);
		}
	}
	
	// Update is called once per frame
	void Update () {
		SysTime = System.DateTime.Now;
		if (TimeOver ()) {
			UpdatedTime = SysTime;
			if (FriendImage.activeSelf == false) visit ();
			else if (FriendImage.activeSelf == true) back ();
		}

		//save
		PlayerPrefs.SetString("FriendTimer", SysTime.ToString());
		PlayerPrefs.SetString (FriendNameVisit, VisitCounter.text);
	}

	void visit(){
		if (FriendList.VisitorNum < FriendList.MaxVisitorNum) {
			if (UnityEngine.Random.Range (1, 100) <= VisitProbability) {
				FriendImage.SetActive (true);
				FriendList.VisitorNum++;
				VisitNumber++;
				VisitCounter.text = VisitNumber.ToString();
			}
		}
	}

	void back(){
		if (UnityEngine.Random.Range (1, 100) <= BackProbability) {
			FriendImage.SetActive (false);
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
