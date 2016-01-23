using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CashBook : MoneySystem {
	// 어레이로...
	public Text Contents1, Contents2, Contents3, Contents4, Contents5, Contents6;
	public Text Income1, Income2, Income3, Income4, Income5, Income6;
	public Text Outcome1, Outcome2, Outcome3, Outcome4, Outcome5, Outcome6;
	public Text Remainder1, Remainder2, Remainder3, Remainder4, Remainder5, Remainder6;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		WriteCashBook ();
		Remainder.text = money.ToString();
	}

	void WriteCashBook(){
		if (MoneyIn) {
			DownLine ();
			Contents1.text = ContentsName;
			Income1.text = income.ToString();
			Outcome1.text = "";
			Remainder1.text = remainder.ToString();
			MoneyIn = false;

		} else if (MoneyOut) {
			DownLine ();
			Contents1.text = ContentsName;
			Income1.text = "";
			Outcome1.text = outcome.ToString();
			Remainder1.text = remainder.ToString();
			MoneyOut = false;
		}
	}

	void DownLine(){
		//어레이로 만들어서 for문을...
		Swap(Contents1,Contents2);
		Swap(Contents1,Contents3);
		Swap(Contents1,Contents4);
		Swap(Contents1,Contents5);
		Swap(Contents1,Contents6);

		Swap(Income1,Income2);
		Swap(Income1,Income3);
		Swap(Income1,Income4);
		Swap(Income1,Income5);
		Swap(Income1,Income6);

		Swap(Outcome1,Outcome2);
		Swap(Outcome1,Outcome3);
		Swap(Outcome1,Outcome4);
		Swap(Outcome1,Outcome5);
		Swap(Outcome1,Outcome6);

		Swap(Remainder1,Remainder2);
		Swap(Remainder1,Remainder3);
		Swap(Remainder1,Remainder4);
		Swap(Remainder1,Remainder5);
		Swap(Remainder1,Remainder6);

	}

	void Swap(Text a, Text b){
		string temp = b.text;
		b.text = a.text;
		a.text = temp;
	}
}
