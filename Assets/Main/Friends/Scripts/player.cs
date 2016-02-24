﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class player : MonoBehaviour {
//	static Vector3 posBed2 = new Vector3(-2,0,0);
	public static GameObject playerObject;
	public static GameObject bed1, bed2,floor1, floor2, desk;
	public static string myPos;
//	static int posNumber;

	// Use this for initialization

	void Awake()
	{
		playerObject = GameObject.Find("Player");
		bed1 = GameObject.Find("player_bed1");
		bed2 = GameObject.Find("player_bed2");
		floor1 = GameObject.Find("player_floor1");
		floor2 = GameObject.Find("player_floor2");
		desk = GameObject.Find("player_desk");

		int n = Random.Range (1, 100);
		if (n <= 7)	// 7 percent sleeping
			FriendList.Sleeping = true;
		else
			FriendList.Sleeping = false;
	}

	void Start () {
		if (FriendList.Sleeping) {
			playerObject.GetComponent<Image> ().enabled = false;
			bed1.GetComponent<Image> ().enabled = true;
			FriendList.bed1 = false;
			FriendList.bed2 = false;
			FriendList.floor1 = false;
			FriendList.floor2 = false;
			FriendList.desk = false;
			FriendList.laundry = false;
			FriendList.VisitorNum = 0;

			if (VisitFriend.penguin != null) {
				VisitFriend.penguin.GetComponent<VisitFriend> ().myPos = "";
				PlayerPrefs.SetString ("PenguinVisitmyPos", "");
			}
			if (VisitFriend.sheep != null) {
				VisitFriend.sheep.GetComponent<VisitFriend> ().myPos = "";
				PlayerPrefs.SetString ("SheepVisitmyPos", "");
			}
			if (VisitFriend.bear != null) {
				VisitFriend.bear.GetComponent<VisitFriend> ().myPos = "";
				PlayerPrefs.SetString ("bearVisitmyPos", "");
			}
			if (VisitFriend.snake != null) {
				VisitFriend.snake.GetComponent<VisitFriend> ().myPos = "";
				PlayerPrefs.SetString ("snakeVisitmyPos", "");
			}
			if (VisitFriend.owl != null) {
				VisitFriend.owl.GetComponent<VisitFriend> ().myPos = "";
				PlayerPrefs.SetString ("owlVisitmyPos", "");
			}
			if (VisitFriend.ammonite != null) {
				VisitFriend.ammonite.GetComponent<VisitFriend> ().myPos = "";
				PlayerPrefs.SetString ("ammoniteVisitmyPos", "");
			}
			if (VisitFriend.crocodile != null) {
				VisitFriend.crocodile.GetComponent<VisitFriend> ().myPos = "";
				PlayerPrefs.SetString ("crocodileVisitmyPos", "");
			}
			if (VisitFriend.lion != null) {
				VisitFriend.lion.GetComponent<VisitFriend> ().myPos = "";
				PlayerPrefs.SetString ("lionVisitmyPos", "");
			}
			
			if (PlayerPrefs.HasKey ("PlayerPos"))
				myPos = PlayerPrefs.GetString ("PlayerPos");
			
			switch (myPos) {
			case("bed1"):
				FriendList.bed1 = true;
				break;

			case("bed2"):
				FriendList.bed2 = true;
				break;

			case("floor1"):
				FriendList.floor1 = true;
				break;

			case("floor2"):
				FriendList.floor2 = true;
				break;

			case("desk"):
				FriendList.desk = true;
				break;
			}

			PlayerPrefs.SetString("bed1",FriendList.bed1.ToString());
			PlayerPrefs.SetString("bed2",FriendList.bed2.ToString());
			PlayerPrefs.SetString("floor1",FriendList.floor1.ToString());
			PlayerPrefs.SetString("floor2",FriendList.floor2.ToString());
			PlayerPrefs.SetString("desk",FriendList.desk.ToString());
			PlayerPrefs.SetString("laundry",FriendList.laundry.ToString());
		}
		else {
			if (PlayerPrefs.HasKey ("PlayerPos"))
				myPos = PlayerPrefs.GetString ("PlayerPos");

			switch (myPos) {
			case("bed1"):
				playerObject.GetComponent<Image> ().enabled = false;
				bed1.GetComponent<Image> ().enabled = true;
				break;

			case("bed2"):
//			posNumber = 0;
				playerObject.GetComponent<Image> ().enabled = false;
				bed2.GetComponent<Image> ().enabled = true;
//			playerObject.transform.position = posBed2;
				break;

			case("floor1"):
				playerObject.GetComponent<Image> ().enabled = false;
				floor1.GetComponent<Image> ().enabled = true;
//			playerObject.transform.position = VisitFriend.posFloor1;
				break;

			case("floor2"):
				playerObject.GetComponent<Image> ().enabled = false;
				floor2.GetComponent<Image> ().enabled = true;
//			playerObject.transform.position = VisitFriend.posFloor2;
				break;

			case("desk"):
				playerObject.GetComponent<Image> ().enabled = false;
				desk.GetComponent<Image> ().enabled = true;
//			playerObject.transform.position = VisitFriend.posDesk;
				break;
			}
		}
		FriendList.showBool ();
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	public static void playerPos(){
		if (!FriendList.Sleeping) {
			PlayerPosChange ();

			int n = UnityEngine.Random.Range (1, 3);
			if (FriendList.desk) {
//			posNumber = 0;
				playerObject.GetComponent<Image> ().enabled = false;
				bed2.GetComponent<Image> ().enabled = true;
//			playerObject.transform.position = posBed2;
				myPos = "bed2";
				Debug.Log ("****PlayerPos : " + myPos);
			} else {
				switch (n) {
				case 1:
					if (!FriendList.desk) {
//					posNumber = 1;
						playerObject.GetComponent<Image> ().enabled = false;
						desk.GetComponent<Image> ().enabled = true;
						//playerObject.transform.position = VisitFriend.posDesk;
						FriendList.desk = true;		
						myPos = "desk";
						Debug.Log ("****PlayerPos : " + myPos);
					}
				//else
				//defaultOption ();
					break;
			
				case 2:
					if (!FriendList.floor1) {
//					posNumber = 2;
						playerObject.GetComponent<Image> ().enabled = false;
						floor1.GetComponent<Image> ().enabled = true;
						//playerObject.transform.position = VisitFriend.posFloor1;
						FriendList.floor1 = true;		
						myPos = "floor1";
						Debug.Log ("****PlayerPos : " + myPos);
					} else
						defaultOption ();
					break;

				case 3:
					if (!FriendList.floor2) {
//					posNumber = 3;
						playerObject.GetComponent<Image> ().enabled = false;
						floor2.GetComponent<Image> ().enabled = true;
						//playerObject.transform.position = VisitFriend.posFloor2;
						FriendList.floor2 = true;		
						myPos = "floor2";
						Debug.Log ("****PlayerPos : " + myPos);
					} else
						defaultOption ();
					break;

				default:
					defaultOption ();
					break;

				}
				Debug.Log ("switch");
			}
			PlayerPrefs.SetString ("PlayerPos", myPos);
//		PlayerPrefs.SetInt ("PlayerPosNumber", posNumber);

			FriendList.showBool ();
		}
	}

	static void PlayerPosChange(){
		if (!FriendList.Sleeping) {
			switch (myPos) {
			case("bed1"):
				FriendList.bed1 = false;
				bed1.GetComponent<Image> ().enabled = false;
				break;

			case("bed2"):
				bed2.GetComponent<Image> ().enabled = false;
				break;

			case("desk"):
				FriendList.desk = false;
				desk.GetComponent<Image> ().enabled = false;
				break;

			case("floor1"):
				FriendList.floor1 = false;
				floor1.GetComponent<Image> ().enabled = false;
				break;

			case("floor2"):
				FriendList.floor2 = false;
				floor2.GetComponent<Image> ().enabled = false;
				break;
			}
		}
	}

	static void defaultOption(){
		if (!FriendList.Sleeping) {
			Debug.Log ("Default");
			if (!FriendList.desk) {
//			posNumber = 1;
				playerObject.GetComponent<Image> ().enabled = false;
				desk.GetComponent<Image> ().enabled = true;
				//playerObject.transform.position = VisitFriend.posDesk;
				FriendList.desk = true;		
				myPos = "desk";
				Debug.Log ("****PlayerPos : " + myPos);
			}
		}
	}
}