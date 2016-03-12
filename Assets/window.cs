using UnityEngine;
using System.Collections;

public class window : MonoBehaviour {
	public static bool open;
	public GameObject openedImage, closedImage;
	// Use this for initialization
	void Start () {
		load ();
		openedImage.SetActive (open);
		closedImage.SetActive (!open);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void save(){
		PlayerPrefs.SetString ("window", open.ToString());
	}

	void load(){
		open = (PlayerPrefs.GetString ("window") == "True");
	}

	public void toggle(){
		//close
		if (open) {
			openedImage.SetActive (false);
			closedImage.SetActive (true);
			open = false;
			save ();
		}

		//open
		else {
			openedImage.SetActive (true);
			closedImage.SetActive (false);
			open = true;
			save ();
		}
	}
}
