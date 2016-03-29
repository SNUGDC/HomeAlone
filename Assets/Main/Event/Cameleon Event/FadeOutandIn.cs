using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class FadeOutandIn : MonoBehaviour
{
    public Button DialogueButton;

    int ClickedTime;

    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Vector4(1, 1, 1, 0);
        DialogueButton.interactable = false;
    }

    void Update()
    {
        ClickedTime = CameleonDialogueText.ClickedTime_CamEv;

        if(ClickedTime == 0)
        {
            GetComponent<SpriteRenderer>().color = new Vector4(GetComponent<SpriteRenderer>().color.r, GetComponent<SpriteRenderer>().color.g, GetComponent<SpriteRenderer>().color.b, GetComponent<SpriteRenderer>().color.a + 0.02f);
            if(GetComponent<SpriteRenderer>().color.a > 1)
            {
                DialogueButton.interactable = true;
            }
        }

        else if(ClickedTime ==5)
        {
            DialogueButton.interactable = false;
            GetComponent<SpriteRenderer>().color = new Vector4(GetComponent<SpriteRenderer>().color.r, GetComponent<SpriteRenderer>().color.g, GetComponent<SpriteRenderer>().color.b, GetComponent<SpriteRenderer>().color.a - 0.02f);
            if (GetComponent<SpriteRenderer>().color.a < 0)
            {
                DialogueButton.interactable = true;
            }
        }
    }
}
