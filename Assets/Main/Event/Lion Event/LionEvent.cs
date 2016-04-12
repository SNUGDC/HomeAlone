using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LionEvent : MonoBehaviour {
	public GameObject lion1, lion2, lion3, surprise, arrow;
	public GameObject Dialog;

	public void ImageChange(){
		if (Dialog.GetComponent<Dialog> ().LineNumber == 1) {
			lion1.GetComponent<Image> ().enabled = false;
			lion2.GetComponent<Image> ().enabled = true;
			surprise.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 2) {
			lion2.GetComponent<Image> ().enabled = false;
			lion3.GetComponent<Image> ().enabled = true;
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 4) {
			lion3.GetComponent<Image> ().enabled = false;
			lion2.GetComponent<Image> ().enabled = true;
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 5) {
			lion2.GetComponent<Image> ().enabled = false;
			lion3.GetComponent<Image> ().enabled = true;
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 6) {
			surprise.SetActive (false);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 8) {
			arrow.SetActive (true);
			lion3.GetComponent<Button> ().enabled = true;
		}
	}

	public void ChangeScene(){
		Invoke("GoToMain" , 5);
	}

	void GoToMain(){
		SceneManager.LoadScene("Main");
	}
}
