using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TalkBalloon : MonoBehaviour {
	public string[] Text;
	public int[] TextProbability;	// same size to Text & SUM is 100
	public Text PanelText;
	private int RandomNumber, saveNumber;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RandomNumber = UnityEngine.Random.Range (1, 100);
	}

	public void SendTextToPanel(){
		saveNumber = RandomNumber;
		if (saveNumber <= TextProbability [0])
			PanelText.text = Text[0];

		else for (int i = 1; i < TextProbability.Length; i++) {
				if ( (TextProbability [i-1] < saveNumber) && (saveNumber <= TextProbability [i]))
				PanelText.text = Text[i];
		}

	}
}
