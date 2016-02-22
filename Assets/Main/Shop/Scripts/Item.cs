using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Item : MonoBehaviour {

	public int ItemPrice;
	public string ItemName;
	public int BoughtNumber = 0;
	public GameObject SetActiveObject;
	public GameObject BoughtImage;
	public Text HavingNumber;

	public void Buy(){
		if (MoneySystem.money >= ItemPrice) {
				MoneySystem.money = MoneySystem.money - ItemPrice;
				MoneySystem.MoneyOut = true;
//				MoneySystem.ContentsName = ItemName;
//				MoneySystem.outcome = -ItemPrice;
				MoneySystem.remainder = MoneySystem.money;
				//SetActiveObject.GetComponent<Image> ().enabled = true;
				SetActiveObject.SetActive(true);
				BoughtImage.SetActive (true);
				BoughtNumber++;
				HavingNumber.text = BoughtNumber + "개 보유";
				save ();
				Debug.Log ("Buy!");
			}

		else {
			Debug.Log ("Be short of money");
		}
	}


	// Use this for initialization
	void Start () {
		load ();
		if (BoughtNumber > 0)
			BoughtImage.SetActive (true);
	}

	// Update is called once per frame
	void Update () {
	}

	public void save(){
		PlayerPrefs.SetInt(ItemName + "BoughtNumber",BoughtNumber);
		PlayerPrefs.SetString (ItemName + "HavingNumber",HavingNumber.text);
	}

	public void load(){
		BoughtNumber = PlayerPrefs.GetInt (ItemName + "BoughtNumber");
		HavingNumber.text = PlayerPrefs.GetString (ItemName + "HavingNumber");
	}
}