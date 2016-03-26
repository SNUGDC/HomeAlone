using UnityEngine;
using System.Collections;

public class LionEp : MonoBehaviour {
	public GameObject dialogwindow, dialog, choose, YesDialog, NoDialog;
	public string IsAlreadyShowSaveName, AnswerSaveName;
	private bool IsAlreadyShow, SaveAnswer;

	// Use this for initialization
	void Start () {
		IsAlreadyShow = (PlayerPrefs.GetString (IsAlreadyShowSaveName) == "True");
		SaveAnswer = (PlayerPrefs.GetString (AnswerSaveName) == "True");
		PlayerPrefs.SetString (IsAlreadyShowSaveName, "True");
		Debug.Log ("Save Answer : " + SaveAnswer);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OpenChoose(int line){
		if (dialog.GetComponent<Dialog> ().LineNumber == line) {
			if (!IsAlreadyShow) {
				choose.SetActive (true);
				dialogwindow.SetActive (false);
			}

			// Already Show
			else {
				// answer "yes"
				if (SaveAnswer) {
					YesDialog.SetActive (true);
					dialogwindow.SetActive (false);
				}

				// answer "no"
				else {
					NoDialog.SetActive (true);
					dialogwindow.SetActive (false);
				}
			}
		}
	}
}
