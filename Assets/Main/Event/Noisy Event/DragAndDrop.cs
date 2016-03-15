using UnityEngine;
using System.Collections;

public class DragAndDrop : MonoBehaviour
{
    public static bool GotFriend;

    public Camera Cam;
    public string FriendName;
    public string Position;

    Vector3 MousePos;
    Vector3 StartPos;

    void Start()
    {
        StartPos = transform.position;
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
        GotFriend = true;
    }

    void OnMouseUp()
    {
        if (PutFriendIntoCloset.ReadyToPutFriend == false)
        {
            GetComponent<Transform>().position = StartPos;
            GotFriend = false;
        }
        else
        {
            Destroy(gameObject);
            PutFriendIntoCloset.HowManyFriendsAreInCloset += 1;
        }
    }
}
