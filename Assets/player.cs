using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class player : MonoBehaviour {
//	static Vector3 posBed2 = new Vector3(-2,0,0);
	public static GameObject playerObject;
	public static GameObject bed2,floor1, floor2, desk;
	static string myPos;
//	static int posNumber;

	// Use this for initialization

	void Awake()
	{
		playerObject = GameObject.Find("Player");
		bed2 = GameObject.Find("player_bed2");
		floor1 = GameObject.Find("player_floor1");
		floor2 = GameObject.Find("player_floor2");
		desk = GameObject.Find("player_desk");
	}

	void Start () {
		if(PlayerPrefs.HasKey("PlayerPos"))
			myPos = PlayerPrefs.GetString ("PlayerPos");
//			posNumber = PlayerPrefs.GetInt ("PlayerPosNumber");
		
		switch (myPos) {
		case("bed2"):
//			posNumber = 0;
			playerObject.GetComponent<Image> ().enabled = false;
			bed2.GetComponent<Image> ().enabled = true;
//			playerObject.transform.position = posBed2;
                Debug.Log("GotoSleep");
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
	
	// Update is called once per frame
	void Update () {
			
	}

	public static void playerPos(){
		PlayerPosChange ();

		int n = UnityEngine.Random.Range (1,3);
		if (FriendList.desk){
//			posNumber = 0;
			playerObject.GetComponent<Image> ().enabled = false;
			bed2.GetComponent<Image> ().enabled = true;
//			playerObject.transform.position = posBed2;
			myPos = "bed2";
			Debug.Log ("****PlayerPos : " + myPos);
		}

		else {
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
				defaultOption();
				break;

			}
			Debug.Log ("switch");
		}
		PlayerPrefs.SetString ("PlayerPos", myPos);
//		PlayerPrefs.SetInt ("PlayerPosNumber", posNumber);
	}

	static void PlayerPosChange(){
		switch (myPos) {
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

	static void defaultOption(){
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
