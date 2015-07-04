using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private static GameController _instance;
	public static GameController get() {
		return _instance;
	}
	
	void Awake() {
		if (_instance == null) {
			_instance = this;
		} else {
			Destroy(this);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onExit ()
	{
		int i = Application.loadedLevel;
		Application.LoadLevel(i + 1);
	}
}
