using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClickChickForChick5 : MonoBehaviour
{
    public GameObject DialogueBox;
    public AudioClip CowSound;
    public AudioClip ChickSound;

    void OnMouseUp()
    {
        GetComponent<AudioSource>().PlayOneShot(CowSound);
        DialogueBox.SetActive(true);
    }

    public void PlaySoundChick1()
    {
        GetComponent<AudioSource>().PlayOneShot(ChickSound);
    }
}
