using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {

	private static InputController _instance;
	public static InputController get() {
		return _instance;
	}

	private PlayerController player;

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

	}
	
	private void init() {

	}
	
	// Update is called once per frame
	void Update () {
		player = PlayerController.get ();

		float x = Input.GetAxis ("Horizontal");
		float y = Input.GetAxis ("Vertical");
		player.move(new Vector2(x,y));
	}

	//TODO : fix
	private Vector2 scale(float x, float y) {
		float max = Mathf.Max (x, y);
		if (max == 0)
			return Vector2.zero;
		float factor = (new Vector2 (x, y) * 1 / max).magnitude;
		return (new Vector2(x,y)).normalized * factor;
	}
}
