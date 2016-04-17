using UnityEngine;
using System.Collections;

public class BGMManager : MonoBehaviour {

    public AudioClip bgm;
    public int numberOfLoop;
    public float introDelay;
    void Start()
    {
        StartCoroutine(PlayAudio (numberOfLoop));
    }
    
    IEnumerator PlayAudio(int times)
    {
        yield return new WaitForSeconds(introDelay);
        for(int i=0; i<times; i++)
        {
            GetComponent<AudioSource>().PlayOneShot(bgm, introDelay);
            yield return new WaitForSeconds(bgm.length);
        }
    }

}
