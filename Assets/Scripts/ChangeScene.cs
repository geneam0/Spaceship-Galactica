using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public void Change(int level){
		Debug.Log ("Button");
		SceneManager.LoadScene(level);
	}
}
