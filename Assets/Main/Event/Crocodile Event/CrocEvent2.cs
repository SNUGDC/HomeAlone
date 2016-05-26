using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class CrocEvent2 : MonoBehaviour {
	public GameObject Dialog,player, player2, hanhwa,talking,talking2,baseball,base1,base2,base3, arrow;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetString ("CrocodileEvent2", "True");
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void ImageChange(){
		if (Dialog.GetComponent<Dialog> ().LineNumber == 1) {
			hanhwa.SetActive (false);
			talking.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 5) {
			talking.SetActive (false);
			talking2.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 6) {
			talking2.SetActive (false);
			hanhwa.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 7) {
			player.SetActive (false);
			player2.SetActive (true);
			hanhwa.SetActive (false);
			baseball.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 8) {
			baseball.SetActive (false);
			base1.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 10) {
			base1.SetActive (false);
			base2.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 11) {
			base2.SetActive (false);
			base3.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 12) {
			base3.GetComponent<Button> ().enabled = true;
			arrow.SetActive (true);
			Dialog.SetActive (false);
		} 
	}

	public void ChangeScene(){
		Invoke("GoToMain" , 5);
	}

	void GoToMain(){
		SceneManager.LoadScene("Main");
	}
}
