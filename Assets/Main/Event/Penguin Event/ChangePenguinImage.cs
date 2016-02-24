using UnityEngine;
using System.Collections;

public class ChangePenguinImage : MonoBehaviour
{
    public Sprite PenguinDrunk;

    void Update()
    {
        if(PenguinEventText.ClickedTime_PenguinEvent >3)
        {
            GetComponent<SpriteRenderer>().sprite = PenguinDrunk;
        }
    }
}
