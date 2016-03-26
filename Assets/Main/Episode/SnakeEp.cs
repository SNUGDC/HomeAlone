using UnityEngine;
using System.Collections;

public class SnakeEp : MonoBehaviour {
	public GameObject DialogWindow, Dialog, Dialog_happy, Dialog_sad, Choose, snake1, player, snake2, snake3,snake4, hug;
	public string IsAlreadyShowSaveName, AnswerSaveName;
	private bool IsAlreadyShow, SaveAnswer;

	// Use this for initialization
	void Start () {
		IsAlreadyShow = (PlayerPrefs.GetString (IsAlreadyShowSaveName) == "True");
		PlayerPrefs.SetString (IsAlreadyShowSaveName, "True");
		SaveAnswer = (PlayerPrefs.GetString (AnswerSaveName) == "True");
		Debug.Log ("Save Answer : " + SaveAnswer);
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void ImageChange(){
		if (Dialog.GetComponent<Dialog> ().LineNumber == 8) {
			snake1.SetActive (false);
			player.SetActive (false);
			snake2.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 9) {
			snake2.SetActive (false);
			snake3.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 10) {
			snake3.SetActive (false);
			snake4.SetActive (true);
		} else if (Dialog.GetComponent<Dialog> ().LineNumber == 12) {
			DialogWindow.SetActive (false);
			if (!IsAlreadyShow)
				Choose.SetActive (true);
			else {
				// answer "yes"
				if (SaveAnswer) {
					Dialog_happy.SetActive (true);
					DialogWindow.SetActive (false);
				}

				// answer "no"
				else {
					Dialog_sad.SetActive (true);
					DialogWindow.SetActive (false);
				}
			}
		}
	}
}
