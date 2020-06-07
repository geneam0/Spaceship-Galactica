using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class SpawnEnemy : MonoBehaviour {

	public GameObject respawnPrefab;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	void Start()
	{
		StartCoroutine (SpawnWaves ());
	}
	IEnumerator SpawnWaves(){
		yield return new WaitForSeconds (startWait);
		while (true) {
			for (int i = 0; i < hazardCount; i++) {
				Instantiate(respawnPrefab, transform.position, transform.rotation);
				yield return new WaitForSeconds(spawnWait);
			}
			yield return new WaitForSeconds(waveWait);
		}
	}
}
