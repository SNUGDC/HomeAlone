using UnityEngine;
using System.Collections;

public class LionEp : MonoBehaviour {
	public GameObject dialogwindow, dialog, choose;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OpenChoose(int line){
		if (dialog.GetComponent<Dialog> ().LineNumber == line) {
			choose.SetActive (true);
			dialogwindow.SetActive (false);
		}
	}
}
