using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Friend : MonoBehaviour {
	public Text VisitCount;
	public GameObject QuestionBox;
	public GameObject[] heart;
	public int IntVisitCount;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		IntVisitCount = VisitFriend.IntParseFast (VisitCount.text);
		AlbumUpdate ();
	}

	void AlbumUpdate(){
		switch(IntVisitCount){
		case 0:
			QuestionBox.SetActive (true);
			break;
		default:
			QuestionBox.SetActive (false);
			if (IntVisitCount >= 3)
				heart [0].SetActive (true);
			if (IntVisitCount >= 10)
				heart [1].SetActive (true);
			if (IntVisitCount >= 100)
				heart [2].SetActive (true);
			break;
		}
	}
}