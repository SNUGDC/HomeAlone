using UnityEngine;
using System.Collections;

public class AmmoEp : MonoBehaviour {
	public GameObject sound, dialog;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Play(){
		if (dialog.GetComponent<Dialog> ().LineNumber == 4)
			sound.GetComponent<AudioSource> ().Play ();
	}
}
