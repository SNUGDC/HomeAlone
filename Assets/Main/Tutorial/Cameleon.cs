using UnityEngine;
using System.Collections;

public class Cameleon : MonoBehaviour
{
    public Sprite CameleonSprite;

    int ClickedTime;

    void Update()
    {
        ClickedTime = TutorialText.ClickedTime;

        if(ClickedTime == 2)
        {
            GetComponent<SpriteRenderer>().sprite = CameleonSprite;
        }
    }
}
