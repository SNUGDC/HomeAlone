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

	private void SetDust(int catchNumber, int i){
		if (catchNumber > 0) {
			Dust[i].SetActive (true);
			Dust [i].GetComponent<Button> ().enabled = true;
			QuestionBox [i].SetActive (false);
			Value [i].text = "잡은 횟수: " + catchNumber;
		}
	}
	public void DustUpdate(){
		SetDust (PlayerPrefs.GetInt ("DefaultDustCatch"), 0);	//default
		SetDust (PlayerPrefs.GetInt("DefaultHairballCatch"), 1);	//hair
		SetDust (PlayerPrefs.GetInt ("BigDustCatch"), 2);	//big
		SetDust (PlayerPrefs.GetInt("DefaultBlackStockingCatch"), 3);	//black stocking
		SetDust (PlayerPrefs.GetInt("DefaultIvoryStockingCatch"), 4);	//ivory stocking
		SetDust (PlayerPrefs.GetInt("DefaultDustCatch"), 5);	//towel
		SetDust (PlayerPrefs.GetInt("DefaultTShirtCatch"), 6);	//tshirt
		SetDust (PlayerPrefs.GetInt("DefaultDishCatch"), 7);	//plate
		SetDust (PlayerPrefs.GetInt("DefaultBlueGompangCatch"), 8);	//blue gompang
		SetDust (PlayerPrefs.GetInt("DefaultRedGompangCatch"), 9);	//red gompang
	}

}
