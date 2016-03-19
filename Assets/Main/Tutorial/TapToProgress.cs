using UnityEngine;
using System.Collections;

public class TapToProgress : MonoBehaviour
{
    public GameObject button;
    public GameObject TapToProgressButton;

    void Update()
    {
        if(TutorialText.ClickedTime == 3)
        {
            TapToProgressButton.SetActive(true);
        }
    }

    public void OnMouseUp()
    {
        if(TutorialText.ClickedTime == 3)
        {
            button.SetActive(true);
            TutorialText.ClickedTime = 4;
        }

        if (TutorialText.ClickedTime == 10)
        {
            TutorialText.ClickedTime = 11;
        }
    }
}
