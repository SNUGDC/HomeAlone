using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour
{
    public AudioClip DoorBellRing;
    public AudioClip Dooropen;

    int ClickedTime;

    void Start()
    {
        GetComponent<AudioSource>().PlayOneShot(DoorBellRing);
    }

    void Update()
    {
        ClickedTime = TutorialText.ClickedTime;

        switch(ClickedTime)
        {
            case 2:
                GetComponent<AudioSource>().PlayOneShot(Dooropen);
                TutorialText.ClickedTime = 3;
                break;
        }
    }
}
