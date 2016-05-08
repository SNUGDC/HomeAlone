using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class sodaimage : MonoBehaviour {
	public GameObject soda, soldoutimage;
	private int sodaBoughtTimes;

	// Use this for initialization
	void Start () {
		sodaBoughtTimes = PlayerPrefs.GetInt("sodaBoughtTimes");
	}
	
	// Update is called once per frame
	void Update () {
		sodaBoughtTimes = PlayerPrefs.GetInt("sodaBoughtTimes");
		if ((soda.GetComponent<Item> ().BoughtNumber == 0) && (sodaBoughtTimes > 0)) {
			soldoutimage.SetActive (true);
		}
	}
}
