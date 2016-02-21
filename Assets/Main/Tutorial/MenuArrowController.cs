using UnityEngine;
using System.Collections;

public class MenuArrowController : MonoBehaviour
{
    public GameObject MenuArrow;
    public GameObject button;

    void Update()
    {
        MenuArrow.SetActive(false);
        button.SetActive(true);
        TutorialText.ClickedTime = 8;
    }
}
