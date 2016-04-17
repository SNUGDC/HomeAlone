using UnityEngine;
using System.Collections;

public class BGMManager : MonoBehaviour {

    public AudioClip bgm;
    public int numberOfLoop;
    void Start()
    {
        StartCoroutine(PlayAudio (numberOfLoop));
    }
    
    IEnumerator PlayAudio(int times)
    {
        for(int i=0; i<times; i++)
        {
            GetComponent<AudioSource>().PlayOneShot(bgm, 0.7F);
            yield return new WaitForSeconds(bgm.length);
        }
    }

}
