using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndOrbCollider : MonoBehaviour
{

    [SerializeField] Text winText;

    private void Start()
    {
        winText.enabled = false;
    }

    //When orb collides with player you win.

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
 
            Destroy(gameObject);
            winText.enabled = true;
            Debug.Break();
  

        }
    }
}