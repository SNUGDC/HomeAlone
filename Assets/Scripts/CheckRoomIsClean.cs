using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CheckRoomIsClean : MonoBehaviour
{
    public GameObject ObjectInteraction;
    public Image[] Friend;

    int FriendNumber;

    void Update()
    {
        if (PlayerPrefs.GetInt("HairballAmount") == -1 && PlayerPrefs.GetInt("DustAmount") == -1 && PlayerPrefs.GetInt("BigDustAmount") == 0)
        {
            if (!(GameObject.Find("Stocking_Ivory 1")) && !(GameObject.Find("Stocking_Ivory 2")))
            {
                if (!(GameObject.Find("Stocking_Black 1")) && !(GameObject.Find("Stocking_Black 2")))
                {
                    if (!(GameObject.Find("T-ShirtDog")) && !(GameObject.Find("Towel 1")) && !(GameObject.Find("Towel 2")))
                    {
                        if (!(GameObject.Find("RedGompang 1")) && !(GameObject.Find("RedGompang 1")) && !(GameObject.Find("RedGompang 1")))
                        {
                            if (!(GameObject.Find("BlueGompang 1")) && !(GameObject.Find("BlueGompang 1")) && !(GameObject.Find("BlueGompang 1")))
                            {
                                if (!(GameObject.Find("Dish1")) && !(GameObject.Find("Dish2")) && !(GameObject.Find("Dish3")))
                                {
                                    if (!(CheckIsThereFriend() > 0))
                                    {
                                        Debug.Log(CheckIsThereFriend());
                                        ObjectInteraction.SetActive(true);
                                    }
                                    else
                                        ObjectInteraction.SetActive(false);
                                }
                                else
                                    ObjectInteraction.SetActive(false);
                            }
                            else
                                ObjectInteraction.SetActive(false);
                        }
                        else
                            ObjectInteraction.SetActive(false);
                    }
                    else
                        ObjectInteraction.SetActive(false);
                }
                else
                    ObjectInteraction.SetActive(false);
            }
            else
                ObjectInteraction.SetActive(false);
        }
        else
            ObjectInteraction.SetActive(false);
    }

    int CheckIsThereFriend()
    {
        FriendNumber = 0;
        for (int i = 0; i < Friend.Length; i++)
        {
            if (Friend[i].GetComponent<Image>().enabled == true)
                FriendNumber++;
        }

        return FriendNumber;
    }
}
