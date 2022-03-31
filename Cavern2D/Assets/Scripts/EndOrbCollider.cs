using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndOrbCollider : MonoBehaviour
{

    [SerializeField] Text winText;
    public GameObject restartScreen;

    private void Start()
    {
 
    }

    //When orb collides with player you win.

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            Destroy(gameObject);
            winText.gameObject.SetActive(true);
            restartScreen.gameObject.SetActive(true);
            Time.timeScale = 0;

        }
    }
}