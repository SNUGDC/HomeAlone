using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class cushion : MonoBehaviour {
	public GameObject ammonite;
	// Use this for initialization
	void Start () {
		ammonite.GetComponent<VisitFriend>().Seat[1] = "floor1";
		ammonite.GetComponent<VisitFriend>().SeatImage[1].sprite = ammonite.GetComponent<Image>().sprite;

		ammonite.GetComponent<VisitFriend>().Seat[2] = "floor2";
		ammonite.GetComponent<VisitFriend>().SeatImage[2].sprite = ammonite.GetComponent<Image>().sprite;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
