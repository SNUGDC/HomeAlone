using UnityEngine;
using System.Collections;

public class BackToMainScene : MonoBehaviour
{
    public void GoToMain(string sceneToChangeTo)
    {
        Application.LoadLevel(sceneToChangeTo);
    }
}
