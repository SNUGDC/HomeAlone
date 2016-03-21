using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BirthdayEvent : MonoBehaviour {
	public GameObject Penguin, Crocodile, Owl, Sheep, Bear, Lion, Table, Cake;
	bool IsAlreadyShow1, IsAlreadyShow2;
	int month,day;

	// Use this for initialization
	void Start () {
		month = PlayerPrefs.GetInt("Month");
		day = PlayerPrefs.GetInt("Day");

		if (PlayerPrefs.HasKey ("BirthdayEvent1"))
			IsAlreadyShow1 = (PlayerPrefs.GetString ("BirthdayEvent1") == "True");
		else
			IsAlreadyShow1 = false;

		if (PlayerPrefs.HasKey ("BirthdayEvent2"))
			IsAlreadyShow2 = (PlayerPrefs.GetString ("BirthdayEvent2") == "True");
		else
			IsAlreadyShow2 = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (month == 8 && day == 10 && !IsAlreadyShow1 && PenguinBirthday ()) {
			// Penguin Birthday!!
			SceneManager.LoadScene ("Penguin Birthday");
			Cake.GetComponent<Item> ().decreaseItem ();
		} else if (month == 9 && day == 6 && !IsAlreadyShow2 && LionBirthday ()) {
			// Lion Birthday!
			SceneManager.LoadScene ("Lion Birthday");
			Cake.GetComponent<Item> ().decreaseItem ();
		}
	}

	private bool PenguinBirthday(){
		bool penguin = (Penguin.GetComponent<VisitFriend> ().VisitNumber > 0);
		bool crocodile = (Crocodile.GetComponent<VisitFriend> ().VisitNumber > 0);
		bool owl = (Owl.GetComponent<VisitFriend> ().VisitNumber > 0);
		bool table = Table.GetComponent<Item> ().haveItem ();
		bool cake = Table.GetComponent<Item> ().haveItem ();

		return penguin && crocodile && owl && table && cake ;
	}

	private bool LionBirthday(){
		bool sheep = (Sheep.GetComponent<VisitFriend> ().VisitNumber > 0);
		bool bear = (Bear.GetComponent<VisitFriend> ().VisitNumber > 0);
		bool lion = (Lion.GetComponent<VisitFriend> ().VisitNumber > 0);
		bool table = Table.GetComponent<Item> ().haveItem ();
		bool cake = Table.GetComponent<Item> ().haveItem ();

		return sheep && bear && lion && table && cake ;
	}
}
