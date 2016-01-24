using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CashBook : MoneySystem {
	// 어레이로...
	public Text[] ContentsArray;
	public Text[] IncomeArray;
	public Text[] OutcomeArray;
	public Text[] RemainderArray;

	string[] SavedContents = {"SC1","SC2","SC3","SC4","SC5","SC6"};
	string[] SavedIncome = {"SI1","SI2","SI3","SI4","SI5","SI6"};
	string[] SavedOutcome = {"SO1","SO2","SO3","SO4","SO5","SO6"};
	string[] SavedRemainder = {"SR1","SR2","SR3","SR4","SR5","SR6"};



	// Use this for initialization
	void Start () {
		for (int i = 0; i < 6; i++) {
			ContentsArray[i].text = PlayerPrefs.GetString (SavedContents[i]);
			IncomeArray[i].text = PlayerPrefs.GetString (SavedIncome[i]);
			OutcomeArray[i].text = PlayerPrefs.GetString (SavedOutcome[i]);
			RemainderArray[i].text = PlayerPrefs.GetString (SavedRemainder[i]);
		}
	}

	// Update is called once per frame
	void Update () {
		WriteCashBook ();
		save ();
	}

	void WriteCashBook(){
		if (MoneyIn) {
			DownLine ();
			ContentsArray[0].text = ContentsName;
			IncomeArray[0].text = income.ToString();
			OutcomeArray[0].text = "";
			RemainderArray[0].text = remainder.ToString();
			MoneyIn = false;

		} else if (MoneyOut) {
			DownLine ();
			ContentsArray[0].text = ContentsName;
			IncomeArray[0].text = "";
			OutcomeArray[0].text = outcome.ToString();
			RemainderArray[0].text = remainder.ToString();
			MoneyOut = false;
		}
	}

	void DownLine(){
		for(int i=0; i<5;i++){
			Swap (ContentsArray [0], ContentsArray [i + 1]);
			Swap (IncomeArray [0], IncomeArray [i + 1]);
			Swap (OutcomeArray [0], OutcomeArray [i + 1]);
			Swap (RemainderArray [0], RemainderArray [i + 1]);
		}
	}

	void Swap(Text a, Text b){
		string temp = b.text;
		b.text = a.text;
		a.text = temp;
	}
		
	public void save(){
		for (int i = 0; i < 6; i++) {
			PlayerPrefs.SetString (SavedContents[i],ContentsArray[i].text);
			PlayerPrefs.SetString (SavedIncome[i],IncomeArray[i].text);
			PlayerPrefs.SetString (SavedOutcome[i],OutcomeArray[i].text);
			PlayerPrefs.SetString (SavedRemainder[i],RemainderArray[i].text);
		}
	}

	public void CashbookReset(){
		for (int i = 0; i < 6; i++) {
			ContentsArray[i].text = "";
			IncomeArray[i].text = "";
			OutcomeArray[i].text = "";
			RemainderArray[i].text = "";
		}
	}
}