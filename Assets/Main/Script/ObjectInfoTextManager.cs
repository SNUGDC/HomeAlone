using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ObjectInfoTextManager : MonoBehaviour
{
    public Text InfoText;
    public string[] Text;

    int i;

    public void InfoNumber()
    {
        i = Random.Range(0, 5);
        InfoText.text = Text[i];
    }
}
