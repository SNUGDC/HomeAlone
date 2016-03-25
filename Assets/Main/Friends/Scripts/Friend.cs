using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Friend : MonoBehaviour {
	public Text VisitCount;
	public GameObject QuestionBox, TalkBalloon_2;
	public GameObject[] heart;
	public int IntVisitCount;
	private Button myButton;
	public static int love1,love2,love3;

	void Awake () {
		myButton = GetComponent<Button>();
		love1 = 1;
		love2 = 10; // 10
		love3 = 40; // 40
	}
		
	void Update () {
		IntVisitCount = VisitFriend.IntParseFast (VisitCount.text);
		AlbumUpdate ();
	}

	public void AlbumUpdate(){
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
		if (TalkBalloon_2.GetComponent<TalkBalloon> ().NumberOfTalk () == 20)
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

	/*
	public void EpisodeEnabled2(GameObject ep){
		if (IntVisitCount >= love2)
			ep.SetActive (true);
	}

	public void EpisodeEnabled3(GameObject ep){
		if (IntVisitCount >= love3)
			ep.SetActive (true);
	}
	*/

	public int HowFriendly(){
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