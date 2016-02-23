using UnityEngine;
using System.Collections;

public class MenuArrowController : MonoBehaviour
{
    public GameObject MenuArrow;
    public GameObject button;

    void Update()
    {
        MenuArrow.SetActive(false);
        TutorialText.ClickedTime = 9;
    }
}
