using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndOrbCollider : MonoBehaviour
{

    [SerializeField] Text winText;
    [SerializeField] Text scoreText;

    private void Start()
    {
        winText.enabled = false;
        scoreText.enabled = false;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
 
            Destroy(gameObject);
            winText.enabled = true;
            scoreText.enabled = true;
            Debug.Break();
  

        }
    }
}