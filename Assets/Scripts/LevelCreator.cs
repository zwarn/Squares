using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelCreator : MonoBehaviour {

	private static LevelCreator _instance;
	public static LevelCreator get() {
		return _instance;
	}

	public string message;

	private ObjectCreator objectCreator;

	void Awake() {
		if (_instance == null) {
			_instance = this;
		} else {
			Destroy (this);
		}
	}

	// Use this for initialization
	void Start () {
		UiController.get ().showText (message);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
