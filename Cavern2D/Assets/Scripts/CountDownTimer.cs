using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    static private float currentTime = 0f;
    private float startingTime = 62f;

    [SerializeField] Text countDownText;
    [SerializeField] Text GameOverText;

    public GameObject restartScreen;

    void Start()
    {     
        currentTime = startingTime;
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
            GameOverText.gameObject.SetActive(true);
            Time.timeScale = 0;
            restartScreen.gameObject.SetActive(true);
        }
    }


    //Adds time to timer when you pickup a specific item.
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            currentTime += 5;
            Destroy(gameObject);
        }
    }
}