using UnityEngine;
using System.Collections;

public class Event_Vodka : MonoBehaviour {

	public GameObject EventMessage;
    public int LeisureTime;
    SelectBehavior Script;

	void Start () {
		Debug.Log ("Start Vodka");
		Invoke ("ActiveEvent", 3.0f);
	}
	

	void Update ()
    {
        LeisureTime = Script.LeisureTime;
    }
	

	void ActiveEvent()
	{

		if (Random.Range (1, 100) <= 100 && Event.canActiveEvent && LeisureTime >= 30) {
			Event.canActiveEvent = false;
			EventMessage.SetActive (true);
		}
	}
}