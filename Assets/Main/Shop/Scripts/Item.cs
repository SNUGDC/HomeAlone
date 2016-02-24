using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Item : MonoBehaviour {

	public int ItemPrice;
	public string ItemName;
	public int BoughtNumber = 0;
	public GameObject SetActiveObject, SetActiveObject2;	// SetActiveObject1 is friend.
	public GameObject BoughtImage;
	public Text HavingNumber;

	public void Buy(){
		if (ItemName == "soda") {
			if (BoughtNumber > 0 || soda.sodaBoughtTimes == 2)
				Debug.Log ("you already have one OR bought two times.");
			else {
				if (MoneySystem.money >= ItemPrice) {
					MoneySystem.money = MoneySystem.money - ItemPrice;
					MoneySystem.MoneyOut = true;
					MoneySystem.remainder = MoneySystem.money;
					SetActiveObject.SetActive (true);
					SetActiveObject2.SetActive (true);
					BoughtImage.SetActive (true);
					BoughtNumber++;
					save ();
					Debug.Log ("Buy!");
				}
			}
		}
		else if (ItemName == "Table" || ItemName == "Cushion" || ItemName == "laundry" || ItemName == "gompang" || ItemName == "mug" || ItemName == "plate" || ItemName == "cake") {
			if (BoughtNumber > 0)
				Debug.Log ("you have already one!");
			else {
				if (MoneySystem.money >= ItemPrice) {
					MoneySystem.money = MoneySystem.money - ItemPrice;
					MoneySystem.MoneyOut = true;
					MoneySystem.remainder = MoneySystem.money;
					SetActiveObject.SetActive (true);
					SetActiveObject2.SetActive (true);
					BoughtImage.SetActive (true);
					BoughtNumber++;
					save ();
					Debug.Log ("Buy!");
				}
			}
		}
		else if (MoneySystem.money >= ItemPrice) {
				MoneySystem.money = MoneySystem.money - ItemPrice;
				MoneySystem.MoneyOut = true;
//				MoneySystem.ContentsName = ItemName;
//				MoneySystem.outcome = -ItemPrice;
				MoneySystem.remainder = MoneySystem.money;
				//SetActiveObject.GetComponent<Image> ().enabled = true;
				SetActiveObject.SetActive(true);
				SetActiveObject2.SetActive(true);
				BoughtImage.SetActive (true);
				BoughtNumber++;
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
		if (BoughtNumber == 0)
			BoughtImage.SetActive (false);
		if (BoughtNumber > 0 && ItemName != "soda" && ItemName != "banana" && ItemName != "Table" && ItemName != "Cushion" && ItemName != "laundry" && ItemName != "gompang" && ItemName != "mug" && ItemName != "plate" && ItemName != "cake")
			HavingNumber.text = SetActiveObject2.GetComponent<StrawberryMilk> ().RemainTime.Hours.ToString () + "시간 " + SetActiveObject2.GetComponent<StrawberryMilk> ().RemainTime.Minutes.ToString () + "분 남음";
		else if (ItemName == "banana")
			HavingNumber.text = BoughtNumber + "개 보유";
		else if (ItemName == "soda" && soda.sodaBoughtTimes == 2)
			HavingNumber.text = "구매 불가";
	}

	public bool haveItem(){
		if (BoughtNumber > 0)
			return true;
		else
			return false;
	}

	public void decreaseItem(){
		if (haveItem())
			BoughtNumber--;
		else
			Debug.Log ("you don't have item");
		save ();
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