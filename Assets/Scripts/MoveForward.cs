using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour {

	public float speed = 10f;
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		Vector3 velocity = new Vector3 (0f, speed * Time.deltaTime, 0);
		pos += transform.rotation * velocity;
		transform.position = pos;
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "Enemy") {
			Destroy (gameObject);
		}
	}
}
