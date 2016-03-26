using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    public void TransferToMain()
    {
        if (PlayerPrefs.GetInt("SeeRealEnding") == 1 || PlayerPrefs.GetInt("SeeRealEnding") == 2)
            SceneManager.LoadScene("AfterRealEnding");
        else SceneManager.LoadScene("Main");
    }
}