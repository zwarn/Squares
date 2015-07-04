using UnityEngine;
using System.Collections;

public class ExitScript : MonoBehaviour {

	GameController gameController;

	// Use this for initialization
	void Start () {
		gameController = GameController.get ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log ("Collision");
		if (coll.gameObject.name == "Player") {
			gameController.onExit();
		}
	}
}
