using UnityEngine;
using System.Collections;

public class Birthday : MonoBehaviour {
	public GameObject Friend1, Friend2, Friend3, Dialog;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LionBirthdayImage(){
		if (Dialog.GetComponent<Dialog> ().LineNumber == 1) {
			Friend1.SetActive (false);
			Friend2.SetActive (true);
		}
		else if (Dialog.GetComponent<Dialog> ().LineNumber == 2) {
			Friend2.SetActive (false);
			Friend3.SetActive (true);
		}
		else if (Dialog.GetComponent<Dialog> ().LineNumber == 4) {
			Friend3.SetActive (false);
			Friend2.SetActive (true);
		}
		else if (Dialog.GetComponent<Dialog> ().LineNumber == 5) {
			Friend2.SetActive (false);
			Friend1.SetActive (true);
		}
		else if (Dialog.GetComponent<Dialog> ().LineNumber == 6) {
			Friend1.SetActive (false);
			Friend3.SetActive (true);
		}
	}

	public void PenguinBirthdayImage(){
		if (Dialog.GetComponent<Dialog> ().LineNumber == 1) {
			Friend1.SetActive (false);
			Friend2.SetActive (true);
		}
		else if (Dialog.GetComponent<Dialog> ().LineNumber == 2) {
			Friend2.SetActive (false);
			Friend3.SetActive (true);
		}
		else if (Dialog.GetComponent<Dialog> ().LineNumber == 3) {
			Friend3.SetActive (false);
			Friend1.SetActive (true);
		}
		else if (Dialog.GetComponent<Dialog> ().LineNumber == 4) {
			Friend1.SetActive (false);
			Friend2.SetActive (true);
		}
		else if (Dialog.GetComponent<Dialog> ().LineNumber == 5) {
			Friend2.SetActive (false);
			Friend3.SetActive (true);
		}
		else if (Dialog.GetComponent<Dialog> ().LineNumber == 6) {
			Friend3.SetActive (false);
			Friend1.SetActive (true);
		}
		else if (Dialog.GetComponent<Dialog> ().LineNumber == 7) {
			Friend1.SetActive (false);
			Friend3.SetActive (true);
		}
	}
}
