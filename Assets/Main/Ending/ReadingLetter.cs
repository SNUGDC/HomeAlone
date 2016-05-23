using UnityEngine;
using System.Collections;

public class ReadingLetter : MonoBehaviour
{
    public GameObject DialogueBox;
    public GameObject Player_Start;
    public GameObject Player;
    public AudioClip LetterDrop;

    void Start()
    {
        DialogueBox.SetActive(false);
        Player_Start.SetActive(true);
        Player.SetActive(false);
    }

    void Update()
    {
        if (GetComponent<Transform>().position.x > 0.45)
        {
            GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x - 0.4f, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z);
        }
        else
        {
            GetComponent<AudioSource>().PlayOneShot(LetterDrop);
            LetterDrop = null;
        }
    }

    void OnMouseUp()
    {
        DialogueBox.SetActive(true);
        Destroy(Player_Start);
        Player.SetActive(true);
        Destroy(gameObject);
    }
}
