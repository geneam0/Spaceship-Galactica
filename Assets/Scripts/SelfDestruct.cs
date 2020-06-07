using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour {

	public float timer = 10f;
	
	// Update is called once per frame
	void Start () {
		Destroy (gameObject,timer);
	}
}
