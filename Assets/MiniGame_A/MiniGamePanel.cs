using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MiniGamePanel : MonoBehaviour
{ 
    public void BackToMain()
    {
		Debug.Log ("end");
        SceneManager.LoadScene("Main");
    }
}
