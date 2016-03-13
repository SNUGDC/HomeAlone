using UnityEngine;
using System.Collections;

public class MiniGameManager : MonoBehaviour
{
    public GameObject Enemy;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    private float MiniGameSec;
    private float CollisionCount;
    public GameObject Panel;

    void Start ()
    {
        Panel.SetActive(false);
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
                Instantiate(Enemy, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
      
    }

    void GameOver()
    {
        if (MiniGameSec >= 10)
        {
            Debug.Log("Game Over");
            Panel.SetActive(true);
        }
    }
}
