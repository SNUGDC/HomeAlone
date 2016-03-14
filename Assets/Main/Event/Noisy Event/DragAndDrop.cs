using UnityEngine;
using System.Collections;

public class DragAndDrop : MonoBehaviour
{
    public static bool GotFriend;

    public Camera Cam;

    Vector3 MousePos;
    Vector3 StartPos;

    void Start()
    {
        StartPos = transform.position;
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
