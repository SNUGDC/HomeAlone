using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HappyEndingLetter : MonoBehaviour
{
    void Start()
    {
        int NumberOfNegativeChoice = PlayerPrefs.GetInt("NumberOfNegativeChoice");
        bool SnakeAnswer = (PlayerPrefs.GetString("SnakeAnswer") != "False");

        if (PlayerPrefs.GetString("IsEnding") == "True")
        {
            if (SnakeAnswer || (NumberOfNegativeChoice < 2))
                return;
            else Destroy(gameObject);
        }
        else Destroy(gameObject);
    }

    void OnMouseUp()
    {
        SceneManager.LoadScene("HappyEnding");
    }
}
