using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Dialog : MonoBehaviour {
	private static string[] conversation = null;
	public Text myText;
	public GameObject ThisEventMessage;
	public int LineNumber;
	private int NumberOfNegativeChoice;

	void Start () {
		LineNumber = 0;
		NumberOfNegativeChoice = PlayerPrefs.GetInt ("NumberOfNegativeChoice");
	}

	void Update () {
		
	}

	public static void AssignText(string[] Text){
		conversation = Text;
	}

	public void OnMouseDown(){
		if (ThisEventMessage.activeSelf) {
			LineNumber++;
			if (conversation != null) {
				if (LineNumber < conversation.Length) {
					myText.text = conversation [LineNumber];
				} else {
					ThisEventMessage.SetActive (false);
					LineNumber = 0;
				}
			}
		}
	}

	public void GoToMain(int EndLineNumber){
		if(LineNumber == EndLineNumber)
			SceneManager.LoadScene ("Main");
	}

	// ** SaveYes SaveName = SaveNo SaveName
	public void SaveYes(string SaveName){
		PlayerPrefs.SetString (SaveName, "True");
	}

	public void SaveNo(string SaveName){
		PlayerPrefs.SetString (SaveName, "False");
		NumberOfNegativeChoice++;
		PlayerPrefs.SetInt ("NumberOfNegativeChoice", NumberOfNegativeChoice);
	}
}
