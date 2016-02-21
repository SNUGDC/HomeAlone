using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FriendList : MonoBehaviour {
	public GameObject[] FriendArray, TalkBalloonArray;
	public string[] FriendName, TalkBalloonName;
	public static int MaxVisitorNum, VisitorNum;
	public static bool bed1, bed2, floor1, floor2, desk, laundry;

	// Use this for initialization
	void Start () {
		load ();
	}

	// Update is called once per frame
	void Update () {
		save ();
	}

	void save(){
		for (int i = 0; i < FriendArray.Length; i++) {
			PlayerPrefs.SetString(FriendName[i],FriendArray[i].activeSelf.ToString());
			PlayerPrefs.SetString(FriendName[i] + "image",FriendArray[i].GetComponent<Image>().enabled.ToString());
			PlayerPrefs.SetString(TalkBalloonName[i],TalkBalloonArray[i].activeSelf.ToString());
		}
		PlayerPrefs.SetInt("MaxVisitorNum", MaxVisitorNum);
		PlayerPrefs.SetInt("VisitorNum", VisitorNum);
	}

	void load(){
		for (int i = 0; i < FriendArray.Length; i++) {
			FriendArray[i].SetActive((PlayerPrefs.GetString (FriendName[i]) == "True"));
			FriendArray[i].GetComponent<Image>().enabled = ((PlayerPrefs.GetString (FriendName[i] + "image") == "True"));
			TalkBalloonArray[i].SetActive((PlayerPrefs.GetString (TalkBalloonName[i]) == "True"));
		}
		if (PlayerPrefs.HasKey ("MaxVisitorNum"))
			MaxVisitorNum = PlayerPrefs.GetInt ("MaxVisitorNum");
		else
			MaxVisitorNum = 1;
		VisitorNum = PlayerPrefs.GetInt ("VisitorNum");;
	}

	public void IncreaseMaxVisitor(){
		MaxVisitorNum++;
	}
}