using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemList : MonoBehaviour {
	public GameObject[] ItemArray;
	public string[] SavedItemArray;

	// Use this for initialization
	void Start () {
		load ();
	}
	
	// Update is called once per frame
	void Update () {
		save ();
	}

	void save(){
		for (int i = 0; i < ItemArray.Length; i++) {
			PlayerPrefs.SetString(SavedItemArray[i],ItemArray[i].GetComponent<Image>().enabled.ToString());
		}
	}

	void load(){
		for (int i = 0; i < ItemArray.Length; i++) {
			ItemArray[i].GetComponent<Image> ().enabled = (PlayerPrefs.GetString (SavedItemArray[i]) == "True");
		}
	}

	public void reset(){
		for (int i = 0; i < ItemArray.Length; i++) {
			ItemArray[i].GetComponent<Image> ().enabled = false;
		}
	}
}
