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

	static GameObject Notice1, Notice2, Notice3, Text1, Text2, Text3;

	void Awake () {
		Notice1 = GameObject.Find ("Notice1");
		Notice2 = GameObject.Find ("Notice2");
		Notice3 = GameObject.Find ("Notice3");
		Text1 = GameObject.Find ("N_Text1");
		Text2 = GameObject.Find ("N_Text2");
		Text3 = GameObject.Find ("N_Text3");
	}

	public void Buy(){
		if (ItemName == "soda") {
			if (BoughtNumber > 0 || soda.sodaBoughtTimes == 2) {
				//already have
				if (Text1 != null && Notice1 != null) {
					Text1.GetComponent<Text> ().enabled = true;
					Notice1.GetComponent<Image> ().enabled = true;
					Notice1.GetComponent<FadeOut> ().enabled = true;
				}
				Debug.Log ("you already have one OR bought two times.");
			}
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
					if (Text3 != null && Notice3 != null) {
						Text3.GetComponent<Text> ().enabled = true;
						Notice3.GetComponent<Image> ().enabled = true;
						Notice3.GetComponent<FadeOut> ().enabled = true;
					}
					Debug.Log ("Buy!");
				} else {
					if (Text2 != null && Notice2 != null) {
						Text2.GetComponent<Text> ().enabled = true;
						Notice2.GetComponent<Image> ().enabled = true;
						Notice2.GetComponent<FadeOut> ().enabled = true;
					}
					//not enough money
				}
			}
		} else if (ItemName == "Table" || ItemName == "Cushion" || ItemName == "laundry" || ItemName == "gompang" || ItemName == "mug" || ItemName == "plate" || ItemName == "cake") {
			if (BoughtNumber > 0) {
				//already have
				if (Text1 != null && Notice1 != null) {
					Text1.GetComponent<Text> ().enabled = true;
					Notice1.GetComponent<Image> ().enabled = true;
					Notice1.GetComponent<FadeOut> ().enabled = true;
				}
				Debug.Log ("you have already one!");
			} else {
				if (MoneySystem.money >= ItemPrice) {
					MoneySystem.money = MoneySystem.money - ItemPrice;
					MoneySystem.MoneyOut = true;
					MoneySystem.remainder = MoneySystem.money;
					SetActiveObject.SetActive (true);
					SetActiveObject2.SetActive (true);
					BoughtImage.SetActive (true);
					BoughtNumber++;
					save ();
					if (Text3 != null && Notice3 != null) {
						Text3.GetComponent<Text> ().enabled = true;
						Notice3.GetComponent<Image> ().enabled = true;
						Notice3.GetComponent<FadeOut> ().enabled = true;
					}
					Debug.Log ("Buy!");
				} else {
					//not enough money
					if (Text2 != null && Notice2 != null) {
						Text2.GetComponent<Text> ().enabled = true;
						Notice2.GetComponent<Image> ().enabled = true;
						Notice2.GetComponent<FadeOut> ().enabled = true;
					}
				}
			}
		} else {	// basic item
			if (MoneySystem.money >= ItemPrice) {
				MoneySystem.money = MoneySystem.money - ItemPrice;
				MoneySystem.MoneyOut = true;
//				MoneySystem.ContentsName = ItemName;
//				MoneySystem.outcome = -ItemPrice;
				MoneySystem.remainder = MoneySystem.money;
				//SetActiveObject.GetComponent<Image> ().enabled = true;
				SetActiveObject.SetActive (true);
				SetActiveObject2.SetActive (true);
				BoughtImage.SetActive (true);
				BoughtNumber++;
				save ();
				if (Text3 != null && Notice3 != null) {
					Text3.GetComponent<Text> ().enabled = true;
					Notice3.GetComponent<Image> ().enabled = true;
					Notice3.GetComponent<FadeOut> ().enabled = true;
				}
				Debug.Log ("Buy!");
			} else {
				//not enough money
				if (Text2 != null && Notice2 != null) {
					Text2.GetComponent<Text> ().enabled = true;
					Notice2.GetComponent<Image> ().enabled = true;
					Notice2.GetComponent<FadeOut> ().enabled = true;
				}
				Debug.Log ("Be short of money");
			}
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
		if (BoughtNumber > 0 && ItemName != "soda" && ItemName != "Table" && ItemName != "Cushion" && ItemName != "laundry" && ItemName != "gompang" && ItemName != "mug" && ItemName != "plate" && ItemName != "cake")
			HavingNumber.text = SetActiveObject2.GetComponent<StrawberryMilk> ().RemainTime.Hours.ToString () + "시간 " + SetActiveObject2.GetComponent<StrawberryMilk> ().RemainTime.Minutes.ToString () + "분 남음";
		else if (ItemName == "soda" && soda.sodaBoughtTimes == 2)
			HavingNumber.text = "구매 불가";
	}

	public bool haveItem(){
		load ();
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

	public void increaseItem(){
		SetActiveObject.SetActive (true);
		SetActiveObject2.SetActive (true);
		BoughtImage.SetActive (true);
		BoughtNumber++;
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