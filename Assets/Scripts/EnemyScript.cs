using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour {

	private float speed = 1f;             //Floating point variable to store the player's movement speed.
	private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
	public GameObject object1;
	public List<GameObject> objects1 = new List<GameObject>();
	public int scoreToGive;
	private ScoreManager theScoreManager;

	// Use this for initialization
	void Start()
	{
		//Get and store a reference to the Rigidbody2D component so that we can access it.
		rb2d = GetComponent<Rigidbody2D> ();
		objects1 = GameObject.FindGameObjectsWithTag("Player").ToList();
		FindTarget();
		theScoreManager = FindObjectOfType<ScoreManager> ();
	}

	void Update(){
		if (object1 != null){
			transform.position = Vector3.MoveTowards(transform.position, object1.transform.position, speed);
			transform.rotation = Quaternion.LookRotation(Vector3.RotateTowards(transform.position, object1.transform.position, 360f, 360f));
		}
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "Bullet") {
            gameObject.tag = "Player";
            Destroy (gameObject);
            theScoreManager.AddScore (scoreToGive);
        }
        if (col.tag=="Player"){
            objects1.Remove(col.gameObject);
            Destroy(col.gameObject);
            FindTarget();
            Application.LoadLevel (3);
        }
	}
	void FindTarget(){
		float lowestDist = Mathf.Infinity;
		for(int i=0; i<objects1.Count; i++){
			float dist = Vector3.Distance(objects1[i].transform.position, transform.position);
			if (dist<lowestDist){
				lowestDist = dist;
				object1 = objects1[i];
			}
		}
 	}		
}
