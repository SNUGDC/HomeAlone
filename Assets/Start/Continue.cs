using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    public GameObject CannotContinuePanel;

    void Start()
    {
        CannotContinuePanel.SetActive(false);
    }

    public void TransferToMain()
    {
        if (PlayerPrefs.HasKey("Is Tutorial Finish"))
        {
            if (PlayerPrefs.GetInt("SeeRealEnding") == 1 || PlayerPrefs.GetInt("SeeRealEnding") == 2)
                SceneManager.LoadScene("AfterRealEnding");
            else
            {
                if (PlayerPrefs.HasKey("HowMuchTimePass") && PlayerPrefs.GetInt("HowMuchTimePass") <= 10)
                    SceneManager.LoadScene("Owl Event");
                else
                    SceneManager.LoadScene("Main");
            }
        }
        else CannotContinuePanel.SetActive(true);
    }
}