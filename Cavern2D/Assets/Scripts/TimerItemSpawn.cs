using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerItemSpawn : MonoBehaviour
{

    [SerializeField]
    private GameObject timerItem;

    [SerializeField]
    private float itemInterval = 4f;


    // Start is called before the first frame update

    // Coroutine method makes the game wait specific time before running it again.

    void Start()
    {
        StartCoroutine(SpawnItem(itemInterval, timerItem));
    }

    private IEnumerator SpawnItem(float interval, GameObject timerItem)
    {
        yield return new WaitForSeconds(interval);
        GameObject newItem = Instantiate(timerItem, new Vector3(Random.Range(50f, 100f), Random.Range(15, 60f), 0), Quaternion.identity);

    }
}
