using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private static PlayerController _instance;
	public static PlayerController get() {
		return _instance;
	}

	public float speed = 10;

	private Rigidbody2D rigidBody;

	void Awake() {
		if (_instance == null) {
			_instance = this;
			init ();
		} else {
			Destroy(this);
		}
	}

	// Use this for initialization
	void Start () {
		init ();
	}

	private void init() {
		rigidBody = GetComponent<Rigidbody2D> ();
	}

	public void move(Vector2 direction) {
		rigidBody.velocity = direction * speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
