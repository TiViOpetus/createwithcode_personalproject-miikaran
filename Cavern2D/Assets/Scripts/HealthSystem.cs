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
            Debug.Break();
        }
    }

    public void TakeDamage(int d)
    {
        if (health >= 1)
        {
            health -= d;
            //Destroy(heart[health].gameObject);
            heart[health].gameObject.SetActive(false);
        }

        if (health < 1)
        {
            dead = true;
            deathText.enabled = true;
        }
    }

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
            TakeDamage(3);
        }        
    }


    public void HealthBoost()
    {

        if(health < maxHealth && dead == false)
        {
            heart[health].gameObject.SetActive(true);
            health += 1;
      
        }
    }
}

