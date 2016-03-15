using UnityEngine;
using System.Collections;

public class DragAndDrop : MonoBehaviour
{
    public static bool GotFriend;

    public Camera Cam;
    public string FriendName;
    public string Position;

    int StartSortingOrder;
    Vector3 MousePos;
    Vector3 StartPos;

    void Start()
    {
        StartPos = transform.position;
        StartSortingOrder = GetComponent<SpriteRenderer>().sortingOrder;
        Debug.Log(FriendName + PlayerPrefs.GetString(FriendName + "VisitmyPos"));
        if (Position != PlayerPrefs.GetString(FriendName + "VisitmyPos"))
            Destroy(gameObject);
    }

    void Update()
    {
        MousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Cam.transform.position.z);
    }

    void OnMouseDrag()
    {
        GetComponent<Transform>().position = Cam.ScreenToWorldPoint(MousePos);
        GetComponent<SpriteRenderer>().sortingOrder = 1;
        GotFriend = true;
        Debug.Log("PutFriendIntoBed.ReadyToPutFriend" + PutFriendIntoBed.ReadyToPutFriend);
    }

    void OnMouseUp()
    {
        if (PutFriendIntoBed.ReadyToPutFriend == true)
        {
            PutFriendIntoBed.HowManyFriendsAreInBed += 1;
            Destroy(gameObject);
        }
        if (PutFriendIntoCloset.ReadyToPutFriend == true)
        {
            PutFriendIntoCloset.HowManyFriendsAreInCloset += 1;
            Destroy(gameObject);
        }
        if (PutFriendIntoCloset.ReadyToPutFriend == false)
        {
            GetComponent<Transform>().position = StartPos;
            GotFriend = false;
            GetComponent<SpriteRenderer>().sortingOrder = StartSortingOrder;
        }
        if (PutFriendIntoBed.ReadyToPutFriend == false)
        {
            GetComponent<Transform>().position = StartPos;
            GotFriend = false;
            GetComponent<SpriteRenderer>().sortingOrder = StartSortingOrder;
        }
    }
}
