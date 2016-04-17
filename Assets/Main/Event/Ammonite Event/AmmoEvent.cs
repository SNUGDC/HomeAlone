using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class AmmoEvent : MonoBehaviour {
	public GameObject Dialog, count_bg;
	public Text count;

	public static DateTime StartTime, UpdateTime;
	public static TimeSpan Delta;
	private bool start;
	int t;
	// Use this for initialization
	void Start () {
		t = IntParseFast (count.GetComponent<Text> ().text);
		Delta = new TimeSpan (0, 0, 1);
	}
	
	// Update is called once per frame
	void Update () {
		if (start) {
			Debug.Log ("start true");
			UpdateTime = DateTime.Now;
			if(t <= 0)
				SceneManager.LoadScene ("MiniGame");
			if ((UpdateTime - StartTime) >= Delta) {
				Debug.Log ("time over");
				t = IntParseFast (count.GetComponent<Text> ().text);
				Debug.Log (t);
				count.GetComponent<Text> ().text = (t-1).ToString ();
				t--;
				StartTime = DateTime.Now;
			}
		}
	}

	public void Countdown(int line){
		if(Dialog.GetComponent<Dialog>().LineNumber == line){
			count_bg.SetActive (true);
			StartTime = DateTime.Now;
			start = true;
		}
	}

	public static int IntParseFast(string value)
	{
		int result = 0;
		for (int i = 0; i < value.Length; i++)
		{
			char letter = value[i];
			result = 10 * result + (letter - 48);
		}
		return result;
	}

}
