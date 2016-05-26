using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DeveloperEvent : MonoBehaviour {
	public GameObject Dialog, croco, carrot, cookie, girim, EQ, cameleon1, cameleon2, Fade;
	public GameObject[] button;

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetString ("DeveloperShow", "True");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ImageChange(){
		if (Dialog.GetComponent<Dialog> ().LineNumber == 1) {
			// fade in
			Fade.GetComponent<Fade>().enabled =true;

			// audio
			Fade.GetComponent<AudioSource>().enabled = false;
			GetComponent<AudioSource> ().enabled = true;
			croco.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 2) {
			croco.SetActive(false);
			carrot.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 3) {
			carrot.SetActive(false);
			cookie.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 4) {
			cookie.SetActive(false);
			croco.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 5) {
			cameleon1.SetActive(false);
			cameleon2.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 6) {
			// cameleon fade out
			cameleon2.GetComponent<Fade>().enabled = true;
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 8) {
			croco.SetActive(false);
			carrot.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 9) {
			carrot.SetActive(false);
			girim.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 10) {
			girim.SetActive(false);
			croco.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 11) {
			croco.SetActive(false);
			EQ.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 12) {
			EQ.SetActive(false);
			croco.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 13) {
			for (int i = 0; i < button.Length; i++)
				button [i].GetComponent<Button> ().enabled = true;
			Dialog.SetActive (false);
		} 
	}
}
