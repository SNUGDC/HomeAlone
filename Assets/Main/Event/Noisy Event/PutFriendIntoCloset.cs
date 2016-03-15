using UnityEngine;
using System.Collections;

public class PutFriendIntoCloset : MonoBehaviour
{
    public static bool ReadyToPutFriend;
    public static int HowManyFriendsAreInCloset = 0;

    void Start()
    {
        ReadyToPutFriend = false;
    }

    void OnMouseOver()
    {
        if (DragAndDrop.GotFriend && HowManyFriendsAreInCloset < 3)
        {
            ReadyToPutFriend = true;
        }
        else ReadyToPutFriend = false;
    }
}
