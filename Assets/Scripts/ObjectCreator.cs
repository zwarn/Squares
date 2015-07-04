using UnityEngine;
using System.Collections;

public class ObjectCreator : MonoBehaviour {

	private static ObjectCreator _instance;
	public static ObjectCreator get() {
		return _instance;
	}

	public string assetFolder = "";

	void Awake() {
		if (_instance == null) {
			_instance = this;
		} else {
			Destroy (this);
		}
	}

	// Use this for initialization
	void Start () {

	}

	public void createAspects (GameObject parent, string[] aspects) {
		if (parent.GetComponent<HasAspects> () != null) {
			string name = parent.name;
			foreach (string aspect in aspects) {
				GameObject block = Resources.Load (assetFolder + aspect + "/" + name) as GameObject;
				block = (GameObject) Instantiate(block, parent.transform.position, Quaternion.identity);
				block.name = aspect;
				block.transform.parent = parent.transform;
			}
		}
	}

	public void addAspects (GameObject parent, string[] aspects) {
		HasAspects hasAspects = parent.AddComponent<HasAspects>();
		hasAspects.aspects = aspects;
	}

	public GameObject createObject(string name, Vector3 position) {
		return createObject (name, position, null);
	}

	public GameObject createObject(string name, Vector3 position, GameObject parent) {
		GameObject basis = Resources.Load (assetFolder + name) as GameObject;
		if (basis == null) {
			Debug.Log("couldn't create object " + name + ". Path : " + assetFolder + name);
		}
		basis = (GameObject) Instantiate(basis, position, Quaternion.identity);
		basis.name = name;

		if (parent != null) {
			basis.transform.parent = parent.transform;
		}
		return basis;
	}

}
