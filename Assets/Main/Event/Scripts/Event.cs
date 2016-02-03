using UnityEngine;
using System.Collections;

public class Event : MonoBehaviour {
	public static bool canActiveEvent;
	public GameObject[] NonActiveEventObjects;

	// Use this for initialization
	void Start () {
		canActiveEvent = true;
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < NonActiveEventObjects.Length; i++) {
			if (NonActiveEventObjects [i].activeSelf == true) {
				canActiveEvent = false;
			}
		}
	}

	public void CanActiveEvent(){
		Event.canActiveEvent = true;
	}
}