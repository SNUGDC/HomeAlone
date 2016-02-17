using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TalkList : MonoBehaviour {
	private bool[] IsSaved;
	private string[] text;

	public Button[] ButtonList;
	public Text[] ButtonTextList;
	public Text PanelText;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	}

	public void OnMouseDown(int i){
		PanelText.text = text[i];
	}

	public void SetTalkList(GameObject TalkBalloon){
		Debug.Log ("SetTalkList!");
		TalkBalloon.GetComponent<TalkBalloon> ().load();
		text = TalkBalloon.GetComponent<TalkBalloon> ().Text;
		IsSaved = TalkBalloon.GetComponent<TalkBalloon> ().IsAlreadyShow;

		for (int i = 0; i < ButtonTextList.Length; i++) {
			ButtonTextList [i].text = "?";
			ButtonList [i].enabled = false;
			if (IsSaved [i]) {
				ButtonTextList [i].text = TalkBalloon.GetComponent<TalkBalloon> ().TextSubject [i];
				ButtonList [i].enabled = true;
				Debug.Log ("Saved");
			}
		}
	}
}
