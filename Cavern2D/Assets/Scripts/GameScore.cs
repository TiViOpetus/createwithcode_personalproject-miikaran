using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{

    public Text scoreText;
    private int scoreNumber;


    // Start is called before the first frame update
    void Start()
    {
        scoreNumber = 0;
        scoreText.text = "Score: " + scoreNumber;

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")

        {
            scoreNumber += 10;
        }

    }

}


