using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{

	public float speed = 20f;
	public Rigidbody2D rb;


	// Use this for initialization
	void Start()
	{
		rb.velocity = transform.right * speed;
	}

	//When bullet collides with enemy, enemy dies and bullet gone.

	void OnTriggerEnter2D(Collider2D other)
	{


		if (other.tag == "Enemy")
        {
			Destroy(other.gameObject);
			Destroy(gameObject);

		}
		else
		{
			Destroy(gameObject);
			
		}		
	}
}