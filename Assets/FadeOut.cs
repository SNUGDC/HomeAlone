using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeOut : MonoBehaviour {
	public GameObject ThisObject, text;
	Color black,transblack,white,transwhite;
	// Use this for initialization
	void Start () {
		black = new Color (0, 0, 0, 255.0f);
		transblack = new Color (0, 0, 0, 0.0f);
		white = new Color (255, 255, 255, 255.0f);
		transwhite = new Color (255, 255, 255, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		ThisObject.GetComponent<Image> ().color = Color.Lerp(ThisObject.GetComponent<Image> ().color, transblack, Time.deltaTime*10);
		text.GetComponent<Text>().color = Color.Lerp(text.GetComponent<Text>().color, transwhite, Time.deltaTime*10);

		if (ThisObject.GetComponent<Image> ().color == transblack) {
			ThisObject.GetComponent<Image> ().enabled = false;
			text.GetComponent<Text> ().enabled = false;
			ThisObject.GetComponent<Image> ().color = black;
			text.GetComponent<Text> ().color = white;
			ThisObject.GetComponent<FadeOut> ().enabled = false;
		}
	}
}