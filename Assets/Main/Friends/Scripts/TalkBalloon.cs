using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TalkBalloon : MonoBehaviour {
	public string[] Text, TextSubject;
	public string NameTalk;
	public int[] TextProbability;	// same size to Text & SUM is 100
	public Text PanelText;
	private int RandomNumber, saveNumber;

	public bool[] IsAlreadyShow = {false};

	// Use this for initialization
	void Start () {
		load ();
	}
	
	// Update is called once per frame
	void Update () {
		RandomNumber = UnityEngine.Random.Range (1, 100);
	}

	public void SendTextToPanel(){
		saveNumber = RandomNumber;
		if (saveNumber <= TextProbability [0]) {
			PanelText.text = Text [0];
			IsAlreadyShow [0] = true;
			save ();
		}

		else for (int i = 1; i < TextProbability.Length; i++) {
				if ((TextProbability [i - 1] < saveNumber) && (saveNumber <= TextProbability [i])) {
					PanelText.text = Text [i];
					IsAlreadyShow [i] = true;
					save ();
					break;
				}
		}

	}

	public int NumberOfTalk(){
		int result=0;
		for (int i = 0; i < Text.Length; i++) {
			if (IsAlreadyShow [i])
				result++;
		}
		return result;
	}

	private void save(){
		for (int i = 0; i < Text.Length; i++) {
			PlayerPrefs.SetString(NameTalk + i.ToString(),IsAlreadyShow[i].ToString());
		}
	}

	public void load(){
		for (int i = 0; i < Text.Length; i++) {
			IsAlreadyShow [i] = (PlayerPrefs.GetString(NameTalk + i.ToString()) == "True");
		}
	}
}
