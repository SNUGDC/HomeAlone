using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SheepEvent2 : MonoBehaviour {
	public GameObject Dialog, Player, Sheep, Lion, event_sheep1, event_sheep3, event_lion1, event_lion2, event_lion3, dialog_player, dialog_sheep, dialog_lion;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ImageChange(){
		if (Dialog.GetComponent<Dialog> ().LineNumber == 0) {
			dialog_player.SetActive (false);
			dialog_sheep.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 1) {
			dialog_sheep.SetActive (false);
			dialog_lion.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 2) {
			dialog_lion.SetActive (false);
			Player.SetActive (false);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 3) {
			dialog_sheep.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 4) {
			dialog_sheep.SetActive (false);
			dialog_lion.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 5) {
			dialog_lion.SetActive (false);
			dialog_sheep.SetActive (true);
			Sheep.SetActive (false);
			Lion.SetActive (false);
			event_sheep1.SetActive (true);
			event_lion2.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 6) {
			dialog_sheep.SetActive (false);
			dialog_lion.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 7) {
			dialog_lion.SetActive (false);
			dialog_sheep.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 8) {
			event_sheep1.SetActive (false);
			event_lion2.SetActive (false);
			event_sheep3.SetActive (true);
			event_lion3.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 9) {
			dialog_sheep.SetActive (false);
			dialog_lion.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 10) {
			dialog_lion.SetActive (false);
			dialog_sheep.SetActive (true);
			event_sheep3.SetActive (false);
			event_lion3.SetActive (false);
			event_sheep1.SetActive (true);
			event_lion1.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 11) {
			dialog_sheep.SetActive (false);
			dialog_lion.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 12) {
			dialog_lion.SetActive (false);
			dialog_sheep.SetActive (true);
			event_sheep1.SetActive (false);
			event_lion1.SetActive (false);
			event_sheep3.SetActive (true);
			event_lion3.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 14) {
			dialog_sheep.SetActive (false);
			dialog_lion.SetActive (true);
			event_sheep3.SetActive (false);
			event_lion3.SetActive (false);
			event_sheep1.SetActive (true);
			event_lion1.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 15) {
			dialog_lion.SetActive (false);
			dialog_sheep.SetActive (true);
			event_sheep1.SetActive (false);
			event_lion1.SetActive (false);
			event_sheep3.SetActive (true);
			event_lion3.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 16) {
			dialog_sheep.SetActive (false);
			dialog_lion.SetActive (true);
			event_sheep3.SetActive (false);
			event_lion3.SetActive (false);
			event_sheep1.SetActive (true);
			event_lion1.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 18) {
			dialog_lion.SetActive (false);
			dialog_sheep.SetActive (true);
			event_sheep1.SetActive (false);
			event_lion1.SetActive (false);
			event_sheep3.SetActive (true);
			event_lion3.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 19) {
			dialog_sheep.SetActive (false);
			dialog_lion.SetActive (true);
			event_sheep3.SetActive (false);
			event_lion3.SetActive (false);
			event_sheep1.SetActive (true);
			event_lion2.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 20) {
			dialog_lion.SetActive (false);
			dialog_sheep.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 21) {
			dialog_sheep.SetActive (false);
			dialog_lion.SetActive (true);
			event_lion2.SetActive (false);
			event_lion1.SetActive (true);
		}
	}
}