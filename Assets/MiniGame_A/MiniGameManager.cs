using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MiniGameManager : MonoBehaviour
{
    public List<GameObject> Enemies = new List<GameObject>();
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    private float MiniGameSec;
    public GameObject WinPanel;

    void Start ()
    {
        WinPanel.SetActive(false);
        StartCoroutine(SpawnWaves());
    }

    void Update ()
    {
        MiniGameSec += Time.deltaTime;
        GameOver();
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);

        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = new Quaternion();
                Instantiate(Enemies[Random.Range(0,10)], spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }

    void GameOver()
    {
        if (MiniGameSec >= 30)
        {
            if (WinPanel == null)
                return;
            Debug.Log("Game Over");
            WinPanel.SetActive(true);
        }
    }
}
