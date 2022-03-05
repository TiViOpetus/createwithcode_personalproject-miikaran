using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    static private float currentTime = 0f;
    private float startingTime = 45f;
    private Animation anim;

    [SerializeField] Text countDownText;
    [SerializeField] Text GameOverText;

    void Start()
    {
        currentTime = startingTime;
        GameOverText.enabled = false;
    }


    //Timer decreases by seconds and updates time from currentTime to countDownText.
    //Game ends when time is 0.

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDownText.text = currentTime.ToString("0.0");


        if (currentTime <= 0)
        {
            countDownText.color = Color.red;
            currentTime = 0;
            GameOverText.enabled = true;

            Debug.Break();
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            currentTime += 5;
            countDownText.text = currentTime.ToString("0.0");
            Destroy(gameObject);

        }

    }


}