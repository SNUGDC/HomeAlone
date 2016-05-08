using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MiniPhotoController : MonoBehaviour
{
    public GameObject PhotoButton;

    void Start()
    {
        if (PlayerPrefs.HasKey("MiniPhotoOn"))
        {
            if (PlayerPrefs.GetInt("MiniPhotoOn") == 1)
                gameObject.SetActive(true);
            else gameObject.SetActive(false);
        }
        else gameObject.SetActive(false);
    }

    void OnMouseUp()
    {
        PhotoButton.SetActive(true);
    }
}
