using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class CrocEvent : MonoBehaviour {
	public GameObject This;
	public GameObject banana, DialogWindow;
	public Text text;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (text.text == "(바나나를 머리에 올린 악어의 모습)") {
			banana.SetActive (true);
			This.GetComponent<SpriteRenderer>().enabled = false;
		}

		if (!DialogWindow.activeSelf) {
			banana.GetComponent<Button> ().enabled = true;
		}
	}

	public void SceneChange(){
		SceneManager.LoadScene ("Main");
	}
}
