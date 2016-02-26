using UnityEngine;
using System.Collections;

public class Sound_PenEven : MonoBehaviour
{
    public AudioClip ToiletDoorKnock;

    void Update()
    {
        if(PenguinEventText.ClickedTime_PenguinEvent == 13 && ToiletDoorTap.IsSuccess == false)
        {
            GetComponent<AudioSource>().PlayOneShot(ToiletDoorKnock);
            PenguinEventText.ClickedTime_PenguinEvent = 14;
        }
        else if(PenguinEventText.ClickedTime_PenguinEvent == 15 && ToiletDoorTap.IsSuccess == false)
        {
            GetComponent<AudioSource>().PlayOneShot(ToiletDoorKnock);
            PenguinEventText.ClickedTime_PenguinEvent = 16;
        }
    }
}
