using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LivingPoint : MonoBehaviour {
	public GameObject[] Dust;
	public GameObject[] QuestionBox;
	public Text[] Value;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void DustUpdate(){
		if (DustController.DefaultDustCatch > 0) {
			Dust[0].SetActive (true);
			Dust [0].GetComponent<Button> ().enabled = true;
			QuestionBox [0].SetActive (false);
			Value [0].text = "잡은 횟수: " + DustController.DefaultDustCatch;
		}

		if (BigDustController.BigDustCatch > 0) {
			Dust[1].SetActive (true);
			Dust [1].GetComponent<Button> ().enabled = true;
			QuestionBox [1].SetActive (false);
			Value [1].text = "잡은 횟수: " + BigDustController.BigDustCatch;
		}
		/*
		if (StockingController.StockingDustCatch > 0) {
			Dust[2].SetActive (true);
			Dust [2].GetComponent<Button> ().enabled = true;
			QuestionBox [2].SetActive (false);
			Value [2].text = "잡은 횟수: " + StockingController.StockingDustCatch;
		}
		*/
	}

}
