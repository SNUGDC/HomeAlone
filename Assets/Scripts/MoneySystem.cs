﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoneySystem : MonoBehaviour {
	public Text Remainder;

	public static int money;

	public static bool MoneyIn;
	public static bool MoneyOut;

	public static string ContentsName;
	public static int income;
	public static int outcome;
	public static int remainder;

	// Use this for initialization
	void Start () {
		money = 0;
		MoneyIn = false;
		MoneyOut = false;
		income = 0;
		outcome = 0;
		remainder = money;
	}
	
	// Update is called once per frame
	void Update () {
		Remainder.text = money.ToString();
	}

	public void Deposit () {
		ContentsName = "allowance";
		money += 100000;
		MoneyIn = true;
		income = +100000;
		remainder = money;
	}
		
}