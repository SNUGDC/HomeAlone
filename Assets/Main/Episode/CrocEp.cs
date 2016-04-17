using UnityEngine;
using System.Collections;

public class CrocEp : MonoBehaviour
{
    public GameObject DialogWindow, Dialog, player, playersad, croc, crocsad;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ImageChange()
    {
        if (Dialog.GetComponent<Dialog>().LineNumber == 2)
        {
            croc.SetActive(false);
            player.SetActive(false);
            crocsad.SetActive(true);
            playersad.SetActive(true);
        }
    }
}
