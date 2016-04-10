using UnityEngine;
using System.Collections;

public class OwnerEvent : MonoBehaviour {
	public GameObject Image1, Image2, dialog;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ImageChange(int n){
		if (dialog.GetComponent<Dialog> ().LineNumber == n) {
			Image1.SetActive (false);
			Image2.SetActive (true);
		}
	}
}
