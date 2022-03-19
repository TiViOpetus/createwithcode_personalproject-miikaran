using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

	public Transform firePoint;
	public GameObject bulletPrefab;

	private Animator animator;

	public AudioSource shootAudio;


    void Start()
    {
		animator = GetComponent<Animator>();
    }

    // Update is called once per frame
	// If you press mousebutton, it shoots a
    void Update()
	{

		if (Input.GetMouseButtonDown(0))
		{
			Shoot();
			shootAudio.Play();
		}

        if (Input.GetMouseButtonUp(0))
        {
			animator.SetBool("Shoot", false);
        }
	}
	
	//When shoot it spawns bulletPrab to the position of firepoint, and runs the shooting anim
	void Shoot()
	{
		Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
		animator.SetBool("Shoot", true);

	}
}