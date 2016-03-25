using UnityEngine;
using System.Collections;

public class BearEvent : MonoBehaviour {
	public GameObject Dialog;
	public GameObject bear1, bear2, bear3, bear4, bear5, bear6, bear7, bear8;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void bearImage(){
		if (Dialog.GetComponent<Dialog> ().LineNumber == 2) {
			bear1.SetActive (false);
			bear2.SetActive (true);
		}
		else if (Dialog.GetComponent<Dialog> ().LineNumber == 4) {
			bear2.SetActive (false);
			bear3.SetActive (true);
		}
		else if (Dialog.GetComponent<Dialog> ().LineNumber == 5) {
			bear3.SetActive (false);
			bear4.SetActive (true);
		}
		else if (Dialog.GetComponent<Dialog> ().LineNumber == 6) {
			bear4.SetActive (false);
			bear5.SetActive (true);
		}
		else if (Dialog.GetComponent<Dialog> ().LineNumber == 7) {
			bear5.SetActive (false);
			bear6.SetActive (true);
		}
		else if (Dialog.GetComponent<Dialog> ().LineNumber == 8) {
			bear6.SetActive (false);
			bear7.SetActive (true);
		}
		else if (Dialog.GetComponent<Dialog> ().LineNumber == 9) {
			bear7.SetActive (false);
			bear8.SetActive (true);
		}
	}
}
