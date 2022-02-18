using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public GameObject[] heart;
    private int health;
    private bool dead;


    private void Start()
    {
        health = heart.Length;
    }


    // Update is called once per frame
    void Update()
    {
        if (dead == true)
        {
            Debug.Break();
        }

    }

    public void TakeDamage(int d)
    {
        if (health >= 1)
        {
            health -= d;
            Destroy(heart[health].gameObject);

        }

        if (health < 1)
        {
            Debug.Break();
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
 
        if (other.tag == "Enemy")
        {
            TakeDamage(1);
       
        }
    }

}

