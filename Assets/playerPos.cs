using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class playerPos : MonoBehaviour {
	public static GameObject playerObject;
	public static GameObject bed1, bed2,floor1, floor2, desk;
	public static string myPos;

	public GameObject crocoBed, crocoDesk, playerbed;
	public static GameObject RoomBed;

	void Awake()
	{
		playerObject = GameObject.Find("Player");
		bed1 = GameObject.Find("player_bed1");
		bed2 = GameObject.Find("player_bed2");
		floor1 = GameObject.Find("player_floor1");
		floor2 = GameObject.Find("player_floor2");
		desk = GameObject.Find("player_desk");
		RoomBed = GameObject.Find ("Room_bed");
	}

	void Start () {
		if (PlayerPrefs.HasKey ("PlayerPos"))
			myPos = PlayerPrefs.GetString ("PlayerPos");

		switch (myPos) {
		case("bed1"):
			playerObject.GetComponent<Image> ().enabled = false;
			bed1.GetComponent<Image> ().enabled = true;
			break;

		case("bed2"):
			playerObject.GetComponent<Image> ().enabled = false;
			bed2.GetComponent<Image> ().enabled = true;
			break;

		case("floor1"):
			playerObject.GetComponent<Image> ().enabled = false;
			floor1.GetComponent<Image> ().enabled = true;
			break;

		case("floor2"):
			playerObject.GetComponent<Image> ().enabled = false;
			floor2.GetComponent<Image> ().enabled = true;
			break;

		case("desk"):
			playerObject.GetComponent<Image> ().enabled = false;
			desk.GetComponent<Image> ().enabled = true;
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
