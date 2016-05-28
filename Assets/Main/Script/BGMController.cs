using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BGMController : MonoBehaviour
{
    public Sprite BGMOff;
    public GameObject Room;
    public GameObject BGMButton;

    string Temp_String;
    Image ButtonImage;

    void Start()
    {
        ButtonImage = BGMButton.GetComponent<Image>();
        if (PlayerPrefs.GetString("BGM") == "OFF")
        {
            ButtonImage.sprite = BGMOff;
            ButtonImage.color = new Vector4(ButtonImage.color.r, ButtonImage.color.g, ButtonImage.color.b, 1);
        }
        else
        {
            ButtonImage.sprite = null;
            ButtonImage.color = new Vector4(ButtonImage.color.r, ButtonImage.color.g, ButtonImage.color.b, 0);
        }
    }

    void Update()
    {
        if (Temp_String != PlayerPrefs.GetString("BGM"))
        {
            if (PlayerPrefs.GetString("BGM") == "OFF")
            {
                ButtonImage.sprite = BGMOff;
                ButtonImage.color = new Vector4(ButtonImage.color.r, ButtonImage.color.g, ButtonImage.color.b, 1);
                Room.GetComponent<AudioSource>().Stop();
            }
            else
            {
                ButtonImage.sprite = null;
                ButtonImage.color = new Vector4(ButtonImage.color.r, ButtonImage.color.g, ButtonImage.color.b, 0);
                Room.GetComponent<AudioSource>().Play();
            }
        }

        Temp_String = PlayerPrefs.GetString("BGM");
    }

    public void ChangeBGMState()
    {
        if (PlayerPrefs.GetString("BGM") == "ON")
            PlayerPrefs.SetString("BGM", "OFF");
        else
            PlayerPrefs.SetString("BGM", "ON");
    }
}
