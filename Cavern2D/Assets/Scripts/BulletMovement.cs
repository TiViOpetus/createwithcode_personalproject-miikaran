using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{

	public float speed = 40f;
	public Rigidbody2D rb;


	// Use this for initialization
	void Start()
	{	
		rb.velocity = transform.right * speed;
	}

	//When bullet collides with enemy, enemy dies and bullet gone.
	//And when bullet collides with items it goes trought, but when it collides with objects
	//, like roofs, etc, it just destroys the bullet

	void OnTriggerEnter2D(Collider2D other)
	{

		if (other.tag == "Enemy")
        {
			Destroy(other.gameObject);
			Destroy(gameObject);

		}
		else if(other.tag == "TimerBoost")
        {

        }
		else if (other.tag == "HealthBoost")
        {

        }
        else
        {
			Destroy(gameObject);
        }
	}
}