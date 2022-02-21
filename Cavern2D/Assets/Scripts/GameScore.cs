using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{

    public Text scoreText;
    private int scoreNumber;

 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")

        {
            scoreNumber += 10;
            scoreText.text = "Score: " + scoreNumber;

        }
 



    
  


    }

}


