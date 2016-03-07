using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    public void TransferToMain()
    {
        SceneManager.LoadScene("Main");
    }
}
