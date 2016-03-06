using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PanelManager : MonoBehaviour
{

    public GameObject Panel;
	// Use this for initialization
	void Start ()
    {
        Panel.SetActive(false);
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
