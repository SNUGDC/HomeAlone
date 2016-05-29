using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeOutCam_OnWall_Smile : MonoBehaviour
{
    public Button DialogueButton;

    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Vector4(1, 1, 1, 1);
        DialogueButton.interactable = false;
    }

    void Update()
    {
        DialogueButton.interactable = false;
        GetComponent<SpriteRenderer>().color = new Vector4(GetComponent<SpriteRenderer>().color.r, GetComponent<SpriteRenderer>().color.g, GetComponent<SpriteRenderer>().color.b, GetComponent<SpriteRenderer>().color.a - 0.02f);
        if (GetComponent<SpriteRenderer>().color.a < 0)
        {
            DialogueButton.interactable = true;
        }
    }
}
