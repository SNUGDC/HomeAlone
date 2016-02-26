using UnityEngine;
using System.Collections;

public class Cameleon : MonoBehaviour
{
    public Sprite ChameleonSprite;
    public Sprite ChameleonMalk;

    int ClickedTime;

    void Update()
    {
        ClickedTime = TutorialText.ClickedTime;

        if(ClickedTime == 3)
        {
            GetComponent<SpriteRenderer>().sprite = ChameleonSprite;
        }
        if(ClickedTime == 9)
        {
            GetComponent<SpriteRenderer>().sprite = ChameleonMalk;
        }
    }
}
