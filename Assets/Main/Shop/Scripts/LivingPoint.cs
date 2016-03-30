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
		SetDust (DustController.DefaultDustCatch, 0);	//default
		SetDust (HairballController.DefaultHairballCatch, 1);	//hair
		SetDust (BigDustController.BigDustCatch, 2);	//big
		SetDust (BlackStockingController.DefaultBlackStockingCatch, 3);	//black stocking
		SetDust (IvoryStockingController.DefaultIvoryStockingCatch, 4);	//ivory stocking
		SetDust (TowelController.DefaultTowelCatch, 5);	//towel
		SetDust (TShirtController.DefaultTShirtCatch, 6);	//tshirt
		SetDust (DishController.DefaultDishCatch, 7);	//plate
		SetDust (BlueGompangController.DefaultBlueGompangCatch, 8);	//blue gompang
		SetDust (RedGompangController.DefaultRedGompangCatch, 9);	//red gompang
		/*
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

		if (BlackStockingController.DefaultBlackStockingCatch > 0) {
			Dust[2].SetActive (true);
			Dust [2].GetComponent<Button> ().enabled = true;
			QuestionBox [2].SetActive (false);
			Value [2].text = "잡은 횟수: " + BlackStockingController.DefaultBlackStockingCatch;
		}

		if (IvoryStockingController.DefaultIvoryStockingCatch > 0) {
			Dust[3].SetActive (true);
			Dust [3].GetComponent<Button> ().enabled = true;
			QuestionBox [3].SetActive (false);
			Value [3].text = "잡은 횟수: " + IvoryStockingController.DefaultIvoryStockingCatch;
		}
		*/

	}

}
