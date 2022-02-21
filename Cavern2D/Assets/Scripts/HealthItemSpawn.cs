using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItemSpawn : MonoBehaviour
{

    [SerializeField]
    private GameObject healthItem;

    [SerializeField]
    private float itemInterval = 2f;


    // Start is called before the first frame update

    // Coroutine method makes the game wait specific time before running it again.

    void Start()
    {
        StartCoroutine(SpawnItem(itemInterval, healthItem));
    }

    private IEnumerator SpawnItem(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(50f, 100f), Random.Range(15, 60f), 0), Quaternion.identity);

    }
}
