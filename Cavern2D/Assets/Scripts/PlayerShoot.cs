using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

	public Transform firePoint;
	public GameObject bulletPrefab;

	public AudioSource shootAudio;

	// Update is called once per frame
	void Update()
	{

		if (Input.GetMouseButtonDown(0))
		{
			Shoot();
			shootAudio.Play();
		}
	}
	
	//When shoot it spawns bulletPrab to the position of firepoint.
	void Shoot()
	{
		Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
	}
}