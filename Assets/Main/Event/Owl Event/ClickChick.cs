using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClickChick : MonoBehaviour
{
    public GameObject DialogueBox;
    public AudioClip ChickSound;
    public Text DialogueText;
    public string ChickText;
    public bool TurnOnDialogueBox;

    void OnMouseUp()
    {
        GetComponent<AudioSource>().PlayOneShot(ChickSound);
        DialogueBox.SetActive(TurnOnDialogueBox);
        DialogueText.text = ChickText;
    }
}
