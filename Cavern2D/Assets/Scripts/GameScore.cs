using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{

    public Text scoreText;
    public Text restartScreenScore;
    static private int scoreNumber;



    //Adds score when bullet collides with enemies.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")

        {
            scoreNumber += 10;
            scoreText.text = "Score: " + scoreNumber;
        }

        //Updates score for restart screen.

        if (other.tag == "Bullet")

        {
            scoreNumber += 0;
            restartScreenScore.text = "Your score was: " + scoreNumber;
        }
    }
}


