using UnityEngine;
using System.Collections;

public class OwlEp : MonoBehaviour
{
    public GameObject DialogWindow, Dialog, player, playersad, owl, owlsad;

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
        if (Dialog.GetComponent<Dialog>().LineNumber == 4)
        {
            owl.SetActive(false);
            player.SetActive(false);
            owlsad.SetActive(true);
            playersad.SetActive(true);
        }
        else if (Dialog.GetComponent<Dialog>().LineNumber == 16)
        {
            owl.SetActive(true);
            owlsad.SetActive(false);
        }
    }
}

