using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AfterSeeRealEnding : MonoBehaviour
{
    public GameObject Panel;
    public Sprite BrokenStartImage;
    public AudioClip StartCrack;

    bool Clicked;

    void Start()
    {
        Clicked = false;
        if (PlayerPrefs.GetInt("SeeRealEnding") == 2)
        {
            GetComponent<Image>().sprite = BrokenStartImage;
            Destroy(Panel);
        }
    }

    void Update()
    {
        if(PlayerPrefs.GetInt("SeeRealEnding") == 1)
        {
            if (Clicked)
            {
                Destroy(Panel);
                GetComponent<Image>().sprite = BrokenStartImage;
                GetComponent<AudioSource>().PlayOneShot(StartCrack);
                StartCrack = null;
                PlayerPrefs.SetInt("SeeRealEnding", 2);
            }
        }
    }

    public void IsClicked()
    {
        Clicked = true;
    }
}
