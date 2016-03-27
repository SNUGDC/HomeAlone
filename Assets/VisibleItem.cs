using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class VisibleItem : MonoBehaviour {
	// List order: penguin - sheep - bear - croco - ammo - owl - lion - snake
	public GameObject ThisPosition, desk, bed;
	public GameObject[] FriendList;
	public List<GameObject> VisitingFriend = new List<GameObject>();

	private GameObject VisibleFriend;

	void Start () {
		
	}

	void Update () {
		ListUpdate (VisitingFriend);
		ImageChange (VisitingFriend);
		BackCheck ();
		desk.SetActive (true);
		bed.SetActive (true);
	}

	//static?? 
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
			list [n - 1].GetComponent<VisitFriend> ().itemVisible = true;
			ThisPosition.GetComponent<Image>().enabled = true;
			VisibleFriend = list [n - 1];

			// choose item: list[n-1].GetComponent<VisitFriend>().VisitItem[k]
			int k = 0;
			for (int i = 0; i < list [n - 1].GetComponent<VisitFriend> ().VisitItem.Length; i++) {
				if (list [n - 1].GetComponent<VisitFriend> ().VisitItem [k].GetComponent<Item> ().haveItem ()) {
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
