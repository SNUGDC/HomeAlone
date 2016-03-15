using UnityEngine;
using System.Collections;

public class FinishCleanDust : MonoBehaviour
{
    public GameObject Button;

    GameObject IsThereDust;

    void Update()
    {
        IsThereDust = GameObject.Find("Tut_Dust");
        if(IsThereDust == null && TutorialText.ClickedTime == 8)
        {
            TutorialText.ClickedTime = 9;
            Button.SetActive(true);
        }
    }
}
