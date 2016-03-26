using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class GoToCredit : MonoBehaviour
{
    public void TransferToCredit()
    {
        SceneManager.LoadScene("Credit");
    }
}
