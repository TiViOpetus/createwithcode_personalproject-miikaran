using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    public GameObject[] heart;
    public int health;
    private int maxHealth;
    private bool dead;
    public GameObject restartScreen;
    [SerializeField] Text deathText;

    public AudioSource pickUpSound;
    public AudioSource hitSound;

    public ParticleSystem pickupEffect;
    private void Start()
    {
        health = 5;
        maxHealth = health;
        Time.timeScale = 1;
    }


    // Update is called once per frame
    void Update()
    {

        if (dead == true)
        {
            deathText.enabled = true;
            Time.timeScale = 0;
            restartScreen.gameObject.SetActive(true);
            deathText.gameObject.SetActive(true);
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
            hitSound.Play();
        }
        else if (other.tag == "Enemy")
        {
            TakeDamage(1);
            hitSound.Play();
        }
        else if (other.tag == "HealthBoost")
        {
            HealthBoost();
            Destroy(other.gameObject);
            PickupEffect();
            pickUpSound.Play();
        }
        else if (other.tag == "RoofSpikes")
        {
        
            TakeDamage(1);
            TakeDamage(1);
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

    //Instantiates particle effect to the position of the item.
    private void PickupEffect()
    {
        GameObject.Instantiate(pickupEffect, transform.position, Quaternion.identity);
    }

    //When this function is called, it restarts the whole scene.
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}





