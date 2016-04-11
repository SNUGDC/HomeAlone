using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuestionBoxTextController : MonoBehaviour
{
    public GameObject[] Animal;
    public int CondtionNumber;
    public string[] ChangableText_BeforeChange;
    public string[] ChangableText_AfterChange;
    public string[] FixText;

    void Start()
    {
        if(CondtionNumber == 1)
        {
            if (Animal[0].GetComponent<Friend>().HowFriendly() >= 1)
            {
                GetComponent<Text>().text = ChangableText_AfterChange[0] + FixText[0];
            }
            else GetComponent<Text>().text = ChangableText_BeforeChange[0] + FixText[0];
        }
        else if (CondtionNumber == 2)
        {
            if (Animal[0].GetComponent<Friend>().HowFriendly() >= 1 && Animal[1].GetComponent<Friend>().HowFriendly() >= 1)
            {
                GetComponent<Text>().text = ChangableText_AfterChange[0] + FixText[0] + "\n" + ChangableText_AfterChange[1] + FixText[1];
            }
            else GetComponent<Text>().text = ChangableText_BeforeChange[0] + FixText[0] + "\n" + ChangableText_BeforeChange[1] + FixText[1];
        }
    }
}
