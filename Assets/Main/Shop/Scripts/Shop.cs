using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Shop : MonoBehaviour {
	public GameObject[] ShopPages;
	public GameObject NextButton, PrevButton;
	int ThisPage;

	void Start () {
		ThisPage = 1;
	}

	void Update () {
	
	}

	public void next(){
		//if (ThisPage < ShopPages.Length) {
			// case!!!!
			if (ThisPage == ShopPages.Length - 1)
				NextButton.SetActive (false);
			if (ThisPage == 1)
				PrevButton.SetActive (true);
			
			ShopPages [ThisPage - 1].SetActive (false);
			ShopPages [ThisPage].SetActive (true);
			ThisPage++;
		//}
	}

	public void prev(){
		//if (ThisPage < ShopPages.Length) {
			if (ThisPage == ShopPages.Length)
				NextButton.SetActive (true);
			if (ThisPage == 2)
				PrevButton.SetActive (false);
			ShopPages [ThisPage - 1].SetActive (false);
			ShopPages [ThisPage - 2].SetActive (true);
			ThisPage--;
		//}
	}
}
