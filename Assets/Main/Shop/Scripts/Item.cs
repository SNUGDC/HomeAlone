using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Item : MoneySystem {

	public int ItemPrice;
	public string ItemName;
	public GameObject SetActiveObject;
	public GameObject BoughtImage;


	public Item(int ItemPrice, string ItemName){
		this.ItemPrice=ItemPrice;
		this.ItemName=ItemName;
	}

	public void Buy(){
		if (money >= ItemPrice) {
			if (SetActiveObject.activeSelf == false) {
				money = money - ItemPrice;
				MoneyOut = true;
				ContentsName = ItemName;
				outcome = -ItemPrice;
				remainder = money;
				//SetActiveObject.GetComponent<Image> ().enabled = true;
				SetActiveObject.SetActive(true);
				BoughtImage.SetActive (true);
				Debug.Log ("Buy!");
			}
			else {
				Debug.Log ("You already have one!");
			}
		}

		else {
			Debug.Log ("Be short of money");
		}
	}


	// Use this for initialization
	void Start () {
		if (SetActiveObject.activeSelf == true) {
			BoughtImage.SetActive (true);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}