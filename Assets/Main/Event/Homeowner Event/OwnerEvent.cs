using UnityEngine;
using System.Collections;

public class OwnerEvent : MonoBehaviour {
	public GameObject Image1, Image2, owner, ownerSecret, ownerSmile, dialog, dialog2;
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

	public void OwnerImage(){
		if (dialog2.GetComponent<Dialog> ().LineNumber == 1) {
			owner.SetActive (false);
			ownerSecret.SetActive (true);
		} else if (dialog2.GetComponent<Dialog> ().LineNumber == 2) {
			ownerSecret.SetActive (false);
			ownerSmile.SetActive (true);
		}
	}
}
