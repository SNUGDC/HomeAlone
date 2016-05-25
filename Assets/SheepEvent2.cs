using UnityEngine;
using System.Collections;

public class SheepEvent2 : MonoBehaviour {
	public GameObject Dialog, Player, Sheep, Lion, Image1, Image2, Image3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ImageChange(){
		if (Dialog.GetComponent<Dialog> ().LineNumber == 1) {
			Player.SetActive (false);
		}
	}
}