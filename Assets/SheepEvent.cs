using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SheepEvent : MonoBehaviour {
	public GameObject VisitSheep;
	public int ExcuteVisitNumber;
	int SheepVisitNumber;
	bool IsAlreadyShow;

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.HasKey ("SheepEvent"))
			IsAlreadyShow = (PlayerPrefs.GetString ("SheepEvent") == "True");
		else
			IsAlreadyShow = false;
		
		SheepVisitNumber = VisitSheep.GetComponent<VisitFriend> ().VisitNumber;
	}
	
	// Update is called once per frame
	void Update () {
		SheepVisitNumber = VisitSheep.GetComponent<VisitFriend> ().VisitNumber;
		if (SheepVisitNumber >= ExcuteVisitNumber && !IsAlreadyShow) {
			IsAlreadyShow = true;
			SceneManager.LoadScene ("Sheep Event");
			PlayerPrefs.SetString ("SheepEvent",IsAlreadyShow.ToString());
		}
	}
}
