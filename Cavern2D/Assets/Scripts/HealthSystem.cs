using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

            dead = true;

        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
 
        if (other.tag == "Bullet")
        {
            TakeDamage(1);
       
        }

        if (other.tag == "Enemy")
        {
            TakeDamage(1);
        }
        
        else if (other.tag == "RoofSpikes")
        {
            TakeDamage(3);
        }
        
    }

}

