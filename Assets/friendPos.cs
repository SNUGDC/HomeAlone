using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class friendPos : MonoBehaviour {
	public GameObject ThisObject;
	public Image FriendImage;
	public string FriendNameVisit;
	public Image[] SeatImage;
	int posNumber;
	public string myPos;

	public static Vector3 posBed1 = new Vector3(-5,0,0);
	public static Vector3 posFloor1 = new Vector3(-1,1,0);
	public static Vector3 posFloor2 = new Vector3(2,-1,0);
	public static Vector3 posDesk = new Vector3(1,1,0);
	public static Vector3 posLaundry = new Vector3(0,-2,0);

	public GameObject crocobed, crocodesk;
	public static GameObject penguin, lion, crocodile, ammonite, owl, snake, sheep, bear;

	// Use this for initialization
	void Awake(){
		penguin = GameObject.Find ("Penguin_f");
		lion = GameObject.Find ("lion_f");
		crocodile = GameObject.Find ("crocodile_f");
		ammonite = GameObject.Find ("ammonite_f");
		owl = GameObject.Find ("owl_f");
		snake = GameObject.Find ("snake_f");
		sheep = GameObject.Find ("Sheep_f");
		bear = GameObject.Find ("bear_f");
		load ();
	}
	void Start () {
		switch (myPos) {
		case("bed1"):
			if (ThisObject.GetComponent<friendPos> ().FriendNameVisit == "crocodileVisit"){
				ThisObject.transform.position = posBed1;
				crocobed.SetActive (true);
				playerPos.RoomBed.SetActive (false);
			}
			else {
				FriendImage.sprite = SeatImage [posNumber].sprite;
				ThisObject.transform.position = posBed1;
			}
			break;

		case("floor1"):
			FriendImage.sprite = SeatImage [posNumber].sprite;
			ThisObject.transform.position = posFloor1;
			break;

		case("floor2"):
			FriendImage.sprite = SeatImage [posNumber].sprite;
			ThisObject.transform.position = posFloor2;
			break;

		case("desk"):
			if (ThisObject.GetComponent<friendPos> ().FriendNameVisit == "crocodileVisit") {
				ThisObject.transform.position = posDesk;
				crocodesk.SetActive (true);
			}
			else {
				FriendImage.sprite = SeatImage [posNumber].sprite;
				ThisObject.transform.position = posDesk;
			}
			break;

		case("laundry"):
			FriendImage.sprite = SeatImage [posNumber].sprite;
			ThisObject.transform.position = posLaundry;
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void load(){
		posNumber = PlayerPrefs.GetInt (FriendNameVisit + "posNumber");
		if(PlayerPrefs.HasKey(FriendNameVisit + "myPos"))
			myPos = PlayerPrefs.GetString (FriendNameVisit + "myPos");
	}
}
