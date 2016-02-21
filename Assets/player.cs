using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
	static Vector3 posBed2 = new Vector3(270,210,0);
	public static GameObject playerObject;
	static string myPos;

	// Use this for initialization

	void Awake()
	{
		playerObject = GameObject.Find("Player");
	}

	void Start () {
		if(PlayerPrefs.HasKey("PlayerPos"))
			myPos = PlayerPrefs.GetString ("PlayerPos");
		
		switch (myPos) {
		case("bed2"):
			playerObject.transform.position = posBed2;
			break;

		case("floor1"):
			playerObject.transform.position = VisitFriend.posFloor1;
			break;

		case("floor2"):
			playerObject.transform.position = VisitFriend.posFloor2;
			break;

		case("desk"):
			playerObject.transform.position = VisitFriend.posDesk;
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
			playerObject.transform.position = posBed2;
			myPos = "bed2";
			Debug.Log ("****PlayerPos : " + myPos);
		}
		else {
			switch (n) {
			case(1):
				if (!FriendList.desk) {
					playerObject.transform.position = VisitFriend.posDesk;
					FriendList.desk = true;		
					myPos = "desk";
					Debug.Log ("****PlayerPos : " + myPos);
				}
				break;
			
			case(2):
				if (!FriendList.floor1) {
					playerObject.transform.position = VisitFriend.posFloor1;
					FriendList.floor1 = true;		
					myPos = "floor1";
					Debug.Log ("****PlayerPos : " + myPos);
				}
				break;

			case(3):
				if (!FriendList.floor2) {
					playerObject.transform.position = VisitFriend.posFloor2;
					FriendList.floor2 = true;		
					myPos = "floor2";
					Debug.Log ("****PlayerPos : " + myPos);
				}
				break;

			default:
				if (!FriendList.desk) {
					playerObject.transform.position = VisitFriend.posDesk;
					FriendList.desk = true;		
					myPos = "desk";
					Debug.Log ("****PlayerPos : " + myPos);
				}
				break;
			}
		}

		PlayerPrefs.SetString ("PlayerPos", myPos);
	}

	static void PlayerPosChange(){
		switch (myPos) {
		case("desk"):
			FriendList.desk = false;
			break;

		case("floor1"):
			FriendList.floor1 = false;
			break;

		case("floor2"):
			FriendList.floor2 = false;
			break;
		}
	}
}
