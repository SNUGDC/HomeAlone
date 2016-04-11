using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayCowSound : MonoBehaviour
{
    public AudioClip CowSound;
    public AudioClip ChickSound;
    public GameObject DialogueBox;
    public Text DialogueText;
    public string ChickText;

    int k;
    float delay = 0;

    void Update()
    {
        Debug.Log(k);

        if (GetComponent<AudioSource>().isPlaying && k == 0)
        {
            k = 1;
        }
        if(!(GetComponent<AudioSource>().isPlaying) && k == 1)
        {
            DialogueBox.SetActive(true);
            DialogueText.text = ChickText;
            delay += Time.deltaTime;

            if (delay > 2)
            {
                DialogueBox.SetActive(false);
                GetComponent<AudioSource>().PlayOneShot(ChickSound);
                delay = 0;
                k = 2;
            }
        }
    }

    void OnMouseUp()
    {
        k = 0;
        GetComponent<AudioSource>().PlayOneShot(CowSound);
    }
}
