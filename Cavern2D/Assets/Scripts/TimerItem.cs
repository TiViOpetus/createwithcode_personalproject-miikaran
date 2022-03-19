using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerItem : MonoBehaviour
{
    static private float currentTime = 0f;

    [SerializeField] Text countDownText;
    [SerializeField] Text GameOverText;

    public AudioSource pickUpSound;

    public ParticleSystem pickupEffect;


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            pickUpSound.Play();
            currentTime += 5;
            countDownText.text = currentTime.ToString("0.0");
            PickupEffect();
            Destroy(gameObject);
          
        }
    }

    private void PickupEffect()
    {
        GameObject.Instantiate(pickupEffect, transform.position, Quaternion.identity);
    }
}