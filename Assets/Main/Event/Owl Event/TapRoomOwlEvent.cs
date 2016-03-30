using UnityEngine;
using System.Collections;

public class TapRoomOwlEvent : MonoBehaviour
{
    public GameObject button;

    void OnMouseUp()
    {
        switch (OwlEventText.ClickedTime_OwlEvent)
        {
            case 14:
                OwlEventText.ClickedTime_OwlEvent = 15;
                button.SetActive(true);
                break;
            case 18:
                OwlEventText.ClickedTime_OwlEvent = 19;
                button.SetActive(true);
                break;
            case 19:
                OwlEventText.ClickedTime_OwlEvent = 20;
                button.SetActive(true);
                break;
            case 20:
                OwlEventText.ClickedTime_OwlEvent = 21;
                button.SetActive(true);
                break;
            case 22:
                OwlEventText.ClickedTime_OwlEvent = 23;
                button.SetActive(true);
                break;
            case 25:
                OwlEventText.ClickedTime_OwlEvent = 26;
                button.SetActive(true);
                break;
            case 26:
                OwlEventText.ClickedTime_OwlEvent = 27;
                button.SetActive(true);
                break;
            default:
                break;
        }
    }
}
