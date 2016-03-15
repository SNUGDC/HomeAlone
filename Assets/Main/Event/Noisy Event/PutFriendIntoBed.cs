using UnityEngine;
using System.Collections;

public class PutFriendIntoBed : MonoBehaviour
{
    public static bool ReadyToPutFriend;
    public static int HowManyFriendsAreInBed = 0;

    void Start()
    {
        ReadyToPutFriend = false;
    }

    void OnMouseOver()
    {
        if (DragAndDrop.GotFriend && HowManyFriendsAreInBed < 3)
        {
            ReadyToPutFriend = true;
        }
        else ReadyToPutFriend = false;
    }
}
