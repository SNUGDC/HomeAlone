using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Dialog : MonoBehaviour {
	public GameObject[] TextLine;
	public GameObject ThisEventMessage;
	int LineNumber;

	void Start () {
		LineNumber = 0;
		TextLine [LineNumber].SetActive (true);
	}

	void Update () {
	
	}

	public void OnMouseDown(){
		LineNumber++;
		if (LineNumber < TextLine.Length) {
			ChangeNextText (LineNumber);
		}
		else {
			ThisEventMessage.SetActive (false);
		}
	}

	void ChangeNextText(int n){
		TextLine[n-1].SetActive (false);
		TextLine[n].SetActive (true);
	}
}
