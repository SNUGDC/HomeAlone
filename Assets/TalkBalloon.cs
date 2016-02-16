using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TalkBalloon : MonoBehaviour {
	public string[] Text;
	public int[] TextProbability;	// same size to Text & SUM is 100
	public Text PanelText;
	private int RandomNumber;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RandomNumber = UnityEngine.Random.Range (1, 100);
	}

	public void SendTextToPanel(){
		if (RandomNumber < (TextProbability [0]))
			;

	}
}
