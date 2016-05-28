using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ObjectInfoTextManager : MonoBehaviour
{
    public Text InfoText;
    public string[] Text;

    int i;
    void Start()
    {
        InfoText.supportRichText = true;
    }
    public void InfoNumber()
    {
        i = Random.Range(0, Text.Length);
        InfoText.text = Text[i];
    }
}
