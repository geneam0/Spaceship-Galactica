using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	public GameObject bulletPrefab;
	public float fireDelay = .25f;
	public float cooldownTimer = 0;
	public AudioClip[] audio;

	// Update is called once per frame
	void Update () {
		cooldownTimer -= Time.deltaTime;
		if(Input.GetKeyDown(KeyCode.Space)&& cooldownTimer<=0){
			Debug.Log ("Pew");
			AudioSource.PlayClipAtPoint (audio [0], transform.position);
			cooldownTimer = fireDelay;
			Vector3 offset = transform.rotation * new Vector3 (0f, 0f, 0f);
			Instantiate (bulletPrefab, transform.position + offset, transform.rotation);
		}
	}
}
