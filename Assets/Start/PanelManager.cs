using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PanelManager : MonoBehaviour
{

    public GameObject Panel;

    public void CallPanel()
    {
        Panel.SetActive(true);
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
