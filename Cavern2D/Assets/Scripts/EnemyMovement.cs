using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float speed = 7f;

    [SerializeField]
    private GameObject player;

    public AudioSource enemyKill;

    public ParticleSystem enemyExplosion;

    // Start is called before the first frame update
    void Start()
    {
       player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Enemy();
    }

    //Moves to position where player is real time.
    private void Enemy()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }


    //When enemy collides with bullet, it runs kill audio + EnemyDeath function.

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Bullet")
        {
            enemyKill.Play();
            EnemyDeath();
        }       
    }

    // Activates particle explosion at the position of enemy.
    private void EnemyDeath()
    {
        GameObject.Instantiate(enemyExplosion, transform.position, Quaternion.identity);
    }
}

