using UnityEngine;
using System.Collections;

public class Event_Vodka : MonoBehaviour {

	public GameObject EventMessage;

	void Start () {
		Debug.Log ("Start Vodka");
		Invoke ("ActiveEvent", 3.0f);
	}
	

	void Update () {
	}

	void ActiveEvent()
	{

		if (Random.Range (1, 100) <= 100 && Event.canActiveEvent) {
			Event.canActiveEvent = false;
			EventMessage.SetActive (true);
		}
	}
}