using UnityEngine;
using System.Collections;

namespace PUNTutorial
{
	public class SpawnPoint : MonoBehaviour {

		void Awake () {
			gameObject.SetActive(false);
		}
	}
}