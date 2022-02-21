using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    private float currentTime = 0f;
    private float startingTime = 45f;
    private Animation anim;

    [SerializeField] Text countDownText;
    [SerializeField] Text GameOverText;

    void Start()
    {

        currentTime = startingTime;
        GameOverText.enabled = false;
     


    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDownText.text = currentTime.ToString ("0.0");

       if (currentTime <= 0)
        {
            countDownText.color = Color.red;
            currentTime = 0;
            GameOverText.enabled = true;
            
            Debug.Break();

        }
        
    }

}
