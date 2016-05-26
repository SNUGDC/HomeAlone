using UnityEngine;
using System.Collections;

public class SheepEp : MonoBehaviour
{
    public GameObject DialogWindow, Dialog, player, playersad, sheep, sheepdoubt, sheepblank;

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
        if (Dialog.GetComponent<Dialog>().LineNumber == 1)
        {
            sheep.SetActive(false);
            sheepdoubt.SetActive(true);
        }
        else if (Dialog.GetComponent<Dialog>().LineNumber == 6)
        {
            sheepblank.SetActive(true);
            sheepdoubt.SetActive(false);
            player.SetActive(false);
            playersad.SetActive(true);
        }
    }
}


