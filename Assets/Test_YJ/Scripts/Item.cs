using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Item : MoneySystem {

	public int ItemPrice;
	public string ItemName;
	public GameObject SetActiveObject;


	public Item(int ItemPrice, string ItemName){
		this.ItemPrice=ItemPrice;
		this.ItemName=ItemName;
	}

	public void Buy(){
		if (money >= ItemPrice) {
			money = money - ItemPrice;
			MoneyOut = true;
			ContentsName = ItemName;
			outcome = -ItemPrice;
			remainder = money;
			SetActiveObject.SetActive (true);
		}

		else {
			Debug.Log ("Be short of money");
		}
	}


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}
}