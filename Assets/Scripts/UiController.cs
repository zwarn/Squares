using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UiController : MonoBehaviour {

	private static UiController _instance;
	public static UiController get() {
		return _instance;
	}

	public GameObject textField;
	private Text text;

	private float timeTillFade = 2;
	private float timeFading = 2;
	private float setTextTimestamp = -1;
	private Color fromColor = Color.white;
	private Color toColor;
	
	void Awake() {
		if (_instance == null) {
			_instance = this;
			init();
		} else {
			Destroy (this);
		}
	}

	// Use this for initialization
	void init () {
		text = textField.GetComponent<Text> ();
	}

	void Start() {
		toColor = Color.white;
		toColor.a = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (setTextTimestamp);
		if (setTextTimestamp != -1) {
			float delta = Time.time - setTextTimestamp;
			if (delta > timeTillFade) {
				text.color = Color.Lerp(fromColor, toColor, (delta - timeTillFade) / timeFading);
			}
			if (delta > timeTillFade + timeFading) {
				setTextTimestamp = -1;
				text.color = toColor;
			}
		}
	}

	public void showText(string message) {
		setTextTimestamp = Time.time;
		text.text = message;
		text.color = fromColor;
	}
}
