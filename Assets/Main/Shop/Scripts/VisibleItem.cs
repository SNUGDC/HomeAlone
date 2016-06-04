using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class VisibleItem : MonoBehaviour {
	// List order: penguin - sheep - bear - croco - ammo - owl - lion - snake
	public GameObject ThisPosition, desk, lion, bed;
	public GameObject[] FriendList;

	//현재 방문해 있는 친구들을 저장하는 리스트
	private List<GameObject> VisitingFriend = new List<GameObject>();
	private bool OK; /*예외상황일 때는 동작하지 않게 하기 위함*/

	private GameObject VisibleFriend;

	void Start () {
		OK = true;
	}

	void Update () {
		OK = true;
		ListUpdate (VisitingFriend); /*현재 방문해있는 친구들 목록 업데이트*/
		ImageChange (VisitingFriend); /*방문중인 친구들 중 랜덤으로 골라 좋아하는 음식들 중 현재 보유중인 것을 보여준다*/

		if (OK) {
			//친구가 떠났을 경우 음식을 다시 안보이게
			BackCheck ();
			desk.SetActive (true);
			lion.SetActive (true);
			bed.SetActive (true);
		}
	}

	private void ListUpdate(List<GameObject> list){
		for (int i = 0; i < FriendList.Length; i++) {
			if (FriendList [i].GetComponent<Image>().enabled && !FriendList [i].GetComponent<VisitFriend>().itemVisible && !list.Contains(FriendList[i]))
				list.Add (FriendList [i]);
			else if((!FriendList[i].GetComponent<Image>().enabled || FriendList [i].GetComponent<VisitFriend>().itemVisible) && list.Contains(FriendList[i]))
				list.Remove (FriendList [i]);
		}
	}

	private void ImageChange(List<GameObject> list){
		if (list.Count > 0 && !ThisPosition.GetComponent<Image>().enabled) {
			RandomChoice (list);
			//choose one friend and change image, set bool
		}
	}

	private void RandomChoice(List<GameObject> list){
		// choose friend: list[n-1]
		int n = UnityEngine.Random.Range (1, list.Count);
		if (list [n - 1] != null && !list [n - 1].GetComponent<VisitFriend> ().itemVisible) {
			if (list [n - 1].GetComponent<VisitFriend> ().FriendNameVisit == "crocodileVisit" && !list [n - 1].GetComponent<VisitFriend> ().crocobed.activeSelf) {
				//exception
				OK = false;
			}

			if (OK) {
				list [n - 1].GetComponent<VisitFriend> ().itemVisible = true;
				ThisPosition.GetComponent<Image> ().enabled = true;
				VisibleFriend = list [n - 1];

				// choosed item: list[n-1].GetComponent<VisitFriend>().VisitItem[k]
				int k = 0;
				for (int i = 0; i < list [n - 1].GetComponent<VisitFriend> ().VisitItem.Length; i++) {
					if (list [n - 1].GetComponent<VisitFriend> ().VisitItem [i].GetComponent<Item> ().haveItem ()) {
						k = i;
						break;
					}
				}

				GameObject item = list [n - 1].GetComponent<VisitFriend> ().VisitItem [k].GetComponent<Item> ().SetActiveObject2; 
				ThisPosition.GetComponent<Image> ().sprite = item.GetComponent<Image> ().sprite;
				RectTransform rt = item.GetComponent<RectTransform> ();
				ThisPosition.GetComponent<RectTransform> ().sizeDelta = new Vector2 (rt.rect.width, rt.rect.height);
			}
		}
	}

	private void BackCheck(){
		if (VisibleFriend != null) {
			if (ThisPosition.GetComponent<Image> ().enabled && !VisibleFriend.GetComponent<Image> ().enabled) {
				ThisPosition.GetComponent<Image> ().enabled = false;
				VisibleFriend.GetComponent<VisitFriend> ().itemVisible = false;
				VisibleFriend = null;
			}
		}
	}

}
