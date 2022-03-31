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


    //When you pickup timer item it adds time to timer and activates other effects.

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            currentTime += 5;
            countDownText.text = currentTime.ToString("0.0");
            PickupEffect();
            pickUpSound.Play();
            Destroy(gameObject);         
        }
    }

    //Item pickup effect instatiates at the position of the item.
    private void PickupEffect()
    {
        GameObject.Instantiate(pickupEffect, transform.position, Quaternion.identity);
    }
}