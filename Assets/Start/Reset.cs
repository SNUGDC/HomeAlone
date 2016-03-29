using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour
{
    public void ResetAllKeys()
    {
        PlayerPrefs.DeleteAll();
    }
}
