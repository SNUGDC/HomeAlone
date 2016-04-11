using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PanelManager : MonoBehaviour
{

    public GameObject Panel;

    public void CallPanel()
    {
        if(PlayerPrefs.HasKey("Is Tutorial Finish"))
            Panel.SetActive(true);
        else
        {
            SceneManager.LoadScene("Tutorial");
            PlayerPrefs.DeleteAll();
        }
    }

    public void ResetGame()
    {
        PlayerPrefs.DeleteAll();

        SceneManager.LoadScene("Tutorial");
    }
    public void BackToStartScene()
    {
        Panel.SetActive(false);
    }

}
