using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MoveToRealEnding : MonoBehaviour
{
    public void MoveToRealEnd()
    {
        SceneManager.LoadScene("RealEnding");
    }
}
