using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject EnemySpritePrefab;

    [SerializeField]
    private float EnemyInterval = 4f;


    // Start is called before the first frame update
    // Coroutine method makes the game wait specific time before running it again.

    void Start()
    {
        StartCoroutine(spawnEnemy(EnemyInterval, EnemySpritePrefab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(50f, 150f), Random.Range(50, 75f), 0), Quaternion.identity);
   
    }
}
