using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class window : MonoBehaviour {
	public static bool open;
	public GameObject openedImage, yellowdustImage, yellowdust2, beautifulImage, rainImage, dustImage, snowImage;
	public GameObject[] Friends;
	public int yellowdust, beautiful, rain, dust, snow;
	private int month, hour, random;
	private string weather;


	void Start () {
		load ();
		openedImage.SetActive (open);
		random = UnityEngine.Random.Range (1, 100);
		if (open) {
			if ((month == 3) || (month == 4))
				YellowDust (yellowdust);
			else if ((month == 5) || (month == 6))
				Beautiful (beautiful);
				//StartCoroutine(Beautiful(beautiful, 3));
			else if ((7 <= month) && (month <= 9))
				Rain (rain);
			else if ((month == 10) || (month == 11))
				Dust (dust);
			else if ((month == 12) || (month == 1))
				Snow (snow);

		}
	}
	
	// Update is called once per frame
	void Update () {
	}

	void save(){
		PlayerPrefs.SetString ("window", open.ToString());
	}

	void load(){
		open = (PlayerPrefs.GetString ("window") == "True");
		month = PlayerPrefs.GetInt("Month");
		hour = PlayerPrefs.GetInt("Hour");
	}

	public void toggle(){
		//close
		if (open) {
			openedImage.SetActive (false);
			open = false;

			switch (weather) {

			case("YellowDust"):
				yellowdustImage.SetActive (false);
				yellowdust2.SetActive (false);
				break;

			case("Beautiful"):
				beautifulImage.SetActive (false);
				break;

			case("Rain"):
				rainImage.SetActive (false);
				break;

			case("Dust"):
				dustImage.SetActive (false);
				break;

			case("Snow"):
				snowImage.SetActive (false);
				break;
			}

			save ();
		}

		//open
		else {
			openedImage.SetActive (true);
			open = true;
			switch (weather) {

			case("YellowDust"):
				yellowdustImage.SetActive (true);
				yellowdust2.SetActive (true);
				break;

			case("Beautiful"):
				beautifulImage.SetActive (true);
				break;

			case("Rain"):
				rainImage.SetActive (true);
				break;

			case("Dust"):
				dustImage.SetActive (true);
				break;

			case("Snow"):
				snowImage.SetActive (true);
				break;
			}

			save ();
		}
	}

	//Event #0
	void YellowDust(int probability){
		if (random <= probability){
			weather = "YellowDust";
			yellowdustImage.SetActive (true);
			yellowdust2.SetActive (true);
			Debug.Log ("yellowDust Event");
//			changeImage (0);			// #0
		}
	}

	/*
	only one time!!!!!!!
	IEnumerator Beautiful(int probability, float delay)
	{
		yield return new WaitForSeconds(delay);

		// code here
		if (random <= probability){
			weather = "Beautiful";
			beautifulImage.SetActive (true);
			Debug.Log ("beautifulScene Event");
			SceneManager.LoadScene ("beautifulScene Event");
		}
	}
	*/


	// code here
	void Beautiful(int probability){
		if (random <= probability && 9 <= hour && hour < 15) {
			weather = "Beautiful";
			beautifulImage.SetActive (true);
			Debug.Log ("beautifulScene Event");
		}
	}

	//event #1
	void Rain(int probability){
		if (random <= probability){
			weather = "Rain";
			rainImage.SetActive (true);
			Debug.Log ("rain Event");
//			changeImage (1);			// #1
		}
	}

	//event #2
	void Dust(int probability){
		if (random <= probability){
			weather = "Dust";
			dustImage.SetActive (true);
			Debug.Log ("dust Event");
//			changeImage (2);			// #2
		}
	}

	//event #3
	void Snow(int probability){
		if (random <= probability){
			weather = "Snow";
			snowImage.SetActive (true);
			Debug.Log ("snow Event");
//			changeImage (3);			// #3
		}
	}
	/*
	void changeImage(int EventNumber){
		for (int i = 0; i < Friends.Length; i++) {
			// if visit, change the image
			if (Friends [i].GetComponent<Image> ().enabled) {
				//except crocodile
				if (!(Friends [i].GetComponent<VisitFriend> ().FriendNameVisit == "crocodileVisit")) {
					Debug.Log ("change Image : " + Friends [i].GetComponent<VisitFriend> ().FriendNameVisit);
					Friends [i].GetComponent<Image>().sprite = Friends [i].GetComponent<VisitFriend> ().EventImage [EventNumber].sprite;
				}
			}
		}
	}
	*/

}
