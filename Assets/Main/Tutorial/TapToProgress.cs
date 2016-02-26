using UnityEngine;
using System.Collections;

public class TapToProgress : MonoBehaviour
{
    public GameObject button;

    void OnMouseUp()
    {
        if(TutorialText.ClickedTime == 3)
        {
            GetComponent<BoxCollider2D>().enabled = false;
            button.SetActive(true);
            TutorialText.ClickedTime = 4;
        }
    }
}
