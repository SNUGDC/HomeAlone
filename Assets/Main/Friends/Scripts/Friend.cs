using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Friend : MonoBehaviour {
	public Text VisitCount;
	public GameObject QuestionBox;
	public GameObject[] heart;
	public int IntVisitCount;
	private Button myButton;

	void Awake () {
		myButton = GetComponent<Button>();
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
			if (IntVisitCount >= 1)
				heart [0].SetActive (true);
			if (IntVisitCount >= 10)
				heart [1].SetActive (true);
			if (IntVisitCount >= 40)
				heart [2].SetActive (true);
			break;
		}
	}

	public void SendVisitNumber(Text Counter){
		Counter.text = IntVisitCount.ToString ();
	}

	public void HeartToRed1(Image red){
		red.enabled=false;
		if (IntVisitCount >= 1)
			red.enabled=true;
	}

	public void HeartToRed2(Image red){
		red.enabled=false;
		if (IntVisitCount >= 10)
			red.enabled=true;
	}

	public void HeartToRed3(Image red){
		red.enabled=false;
		if (IntVisitCount >= 40)
			red.enabled=true;
	}

	public void EpisodeEnabled1(GameObject ep){
		if (IntVisitCount >= 1)
			ep.SetActive (true);
	}

	public void EpisodeEnabled2(GameObject ep){
		if (IntVisitCount >= 10)
			ep.SetActive (true);
	}

	public void EpisodeEnabled3(GameObject ep){
		if (IntVisitCount >= 40)
			ep.SetActive (true);
	}

}