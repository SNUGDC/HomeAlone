using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TalkBalloon : MonoBehaviour {
	public GameObject TalkPanel, DialogWindow;
	public string[] Text, TextSubject;
	public string NameTalk;
	public int[] TextProbability;	// same size to Text & SUM is 100
	public Text PanelText;
	public Text DialogText;
	public int SaveTalkNumber;
	//private int RandomNumber, saveNumber;

	public bool[] IsAlreadyShow;

	// Use this for initialization
	void Awake () {
		load ();
		if (NameTalk == "ammoTalk") {
			for (int i = 13; i < 20;i++)
				IsAlreadyShow [i] = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
//		PlayerPrefs.SetInt (NameTalk + "TalkNum",SaveTalkNumber);
//		RandomNumber = UnityEngine.Random.Range (1, 100);
	}

	public int whatTalk(int saveNumber){
		if (saveNumber <= TextProbability [0])
			return 0;
		else {
			for (int i = 1; i < TextProbability.Length; i++) {
				if ((TextProbability [i - 1] < saveNumber) && (saveNumber <= TextProbability [i]))
					return i;
			}
		}
		return 100;
	}

	public bool alreadyShow(int talkNumber){
		return IsAlreadyShow [talkNumber];
	}


	public void SendTextToPanel(){
		string[] dialogString = splitText (Text [SaveTalkNumber]);
		Debug.Log (SaveTalkNumber);
		if (IsAlreadyShow [SaveTalkNumber]) {
				TalkPanel.SetActive (true);
				string panelString = null;
				for(int i=0;i<dialogString.Length;i++)
					panelString += dialogString [i];
				PanelText.text = panelString;
			} else {
				DialogWindow.SetActive (true);
				IsAlreadyShow [SaveTalkNumber] = true;
				Dialog.AssignText (dialogString);
				DialogText.text = dialogString [0];
			}
			save ();

	}

	/*
	public void SendTextToPanel(){
		int saveNumber = SaveTalkNumber;

		// case : first text
		if (saveNumber <= TextProbability [0]) {
			string[] dialogString = splitText (Text [0]);

			if (IsAlreadyShow [0]) {
				TalkPanel.SetActive (true);
				string panelString = null;
				for(int i=0;i<dialogString.Length;i++)
					panelString += dialogString [i];
				PanelText.text = panelString;
				Debug.Log (NameTalk + "TalkBalloon : 0");
			} else {
				DialogWindow.SetActive (true);
				IsAlreadyShow [0] = true;
				Dialog.AssignText (dialogString);
				DialogText.text = dialogString [0];
				Debug.Log (NameTalk + "TalkBalloon : 0");
			}
			save ();
		}

		else for (int i = 1; i < TextProbability.Length; i++) {
				if ((TextProbability [i - 1] < saveNumber) && (saveNumber <= TextProbability [i])) {
					string[] dialogString = splitText (Text [i]);

					if (IsAlreadyShow [i]) {
						TalkPanel.SetActive (true);
						string panelString = null;
						for(int n=0;n<dialogString.Length;n++)
							panelString += dialogString [n];
						PanelText.text = panelString;
						Debug.Log (NameTalk + "TalkBalloon : " + i);
					} else {
						DialogWindow.SetActive (true);
						IsAlreadyShow [i] = true;
						Dialog.AssignText (dialogString);
						DialogText.text = dialogString [0];
						Debug.Log (NameTalk + "TalkBalloon : " + i);
					}
					save ();
					break;
				}
		}

	}
	*/

	public int NumberOfTalk(){
		int result=0;
		for (int i = 0; i < Text.Length; i++) {
			if (IsAlreadyShow [i])
				result++;
		}
		return result;
	}

	private string[] splitText(string text){
		string[] sp = new string[] { "// " };
		string[] spstring = text.Split (sp,System.StringSplitOptions.None);

		return spstring;
	}

	public void save(){
		if (NameTalk == "ammoTalk") {
			for (int i = 13; i < 20;i++)
				IsAlreadyShow [i] = true;
		}
		PlayerPrefs.SetInt (NameTalk + "TalkNum",SaveTalkNumber);
		for (int i = 0; i < Text.Length; i++) {
			PlayerPrefs.SetString(NameTalk + i.ToString(),IsAlreadyShow[i].ToString());
		}
	}

	public void load(){
		SaveTalkNumber = PlayerPrefs.GetInt (NameTalk + "TalkNum");
		for (int i = 0; i < Text.Length; i++) {
			IsAlreadyShow [i] = (PlayerPrefs.GetString(NameTalk + i.ToString()) == "True");
		}
	}
}
