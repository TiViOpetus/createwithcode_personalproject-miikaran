using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public GameObject[] heart;
    public int health;
    private int maxHealth;
    private bool dead;
    [SerializeField] Text deathText;

    public AudioSource deathAudio;


    private void Start()
    {
        health = 3;
        maxHealth = health;
        deathText.enabled = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (dead == true)
        {
            deathText.enabled = true;
            Debug.Break();

        }
    }

    public void TakeDamage(int d)
    {
        if (health >= 1)
        {
            health -= d;
     
            heart[health].gameObject.SetActive(false);
        }

        if (health < 1)
        {      
            dead = true;          
        }
    }


    // If player collides with bullet, enemy or roofspikes health decreases by 1.
    //When collide with healthboost health increases by 1. 

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Bullet")
        {
            TakeDamage(1);
        }
        else if (other.tag == "Enemy")
        {
            TakeDamage(1);
        }
        else if (other.tag == "HealthBoost")
        {
            HealthBoost();
            Destroy(other.gameObject);
        }
        else if (other.tag == "RoofSpikes")
        {
            TakeDamage(1);
            TakeDamage(1);
            TakeDamage(1);
            dead = true;
        }        
    }


    //Healthboost adds health by 1.

    public void HealthBoost()
    {

        if(health < maxHealth && dead == false)
        {
            heart[health].gameObject.SetActive(true);
            health += 1;
      
        }
    }
}

