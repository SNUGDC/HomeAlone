using UnityEngine;
using System.Collections;

public class ChoiceManager : MonoBehaviour
{
    public static bool SayYes;
    public GameObject button;

    public void SayYestoChoice()
    {
        button.SetActive(true);
        OwlEventText.ClickedTime_OwlEvent = 11;
    }

    public void SayNotoFirstChoice()
    {
        button.SetActive(true);
        OwlEventText.ClickedTime_OwlEvent = 7;
    }

    public void SayNotoSecondChoice()
    {
        button.SetActive(true);
        OwlEventText.ClickedTime_OwlEvent = 9;
    }
}
