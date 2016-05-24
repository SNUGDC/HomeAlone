using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Friend : MonoBehaviour {
	public Text VisitCount;
	public string FriendNameVisit;
	public GameObject QuestionBox, TalkBalloon_2;
	public GameObject[] heart;
	public int IntVisitCount;
	public Button myButton;

	public Button[] eventButton;
	public Text[] eventText;
	public string[] eventTitle;
	public string[] eventSave;

	public static int love1=1,love2=20,love3=45;

	void Awake () {
		//myButton = GetComponent<Button>();
		IntVisitCount = VisitFriend.IntParseFast (VisitCount.text);
	}
		
	void Update () {
		IntVisitCount = VisitFriend.IntParseFast (VisitCount.text);
//		AlbumUpdate ();
	}

	public void AlbumUpdate(){
		IntVisitCount = VisitFriend.IntParseFast (VisitCount.text);
		switch(IntVisitCount){
		case 0:
			QuestionBox.SetActive (true);
			myButton.enabled = false;
			break;
		default:
			QuestionBox.SetActive (false);
			myButton.enabled = true;
			if (IntVisitCount >= love1)
				heart [0].SetActive (true);
			if (IntVisitCount >= love2)
				heart [1].SetActive (true);
			if (IntVisitCount >= love3)
				heart [2].SetActive (true);
			break;
		}
	}

	public void SendVisitNumber(Text Counter){
		Counter.text = IntVisitCount.ToString ();
	}

	public void HeartToRed1(Image red){
		red.enabled=false;
		if (IntVisitCount >= love1)
			red.enabled=true;
	}

	public void HeartToRed2(Image red){
		red.enabled=false;
		if (IntVisitCount >= love2)
			red.enabled=true;
	}

	public void HeartToRed3(Image red){
		red.enabled=false;
		if (IntVisitCount >= love3)
			red.enabled=true;
	}

	public void EpisodeEnabled(GameObject ep){
		if (TalkBalloon_2.GetComponent<TalkBalloon> ().NumberOfTalk () >= 20)
			ep.SetActive (true);
		else
			ep.SetActive (false);
	}

	public void EpisodeNotice(GameObject ep){
		if (TalkBalloon_2.GetComponent<TalkBalloon> ().NumberOfTalk () < 20)
			ep.SetActive (true);
		else
			ep.SetActive (false);
	}

	public void EventEnabled(){
		for (int i = 0; i < eventButton.Length; i++) {
			if (PlayerPrefs.GetString (eventSave[i]) == "True") {
				eventButton [i].enabled = true;
				eventText [i].text = eventTitle [i];
			}
		}
	}

	public int HowFriendly(){
		IntVisitCount = VisitFriend.IntParseFast (PlayerPrefs.GetString (FriendNameVisit));
		if (IntVisitCount < love1)
			return 0;
		else if (IntVisitCount < love2)
			return 1;
		else if (IntVisitCount < love3)
			return 2;
		else
			return 3;
	}

}