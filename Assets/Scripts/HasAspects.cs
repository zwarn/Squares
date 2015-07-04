using UnityEngine;
using System.Collections;

public class HasAspects : MonoBehaviour {

	public string[] aspects;

	void Start () {
		ObjectCreator objectCreator = ObjectCreator.get ();
		objectCreator.createAspects (this.gameObject, aspects);
	}
	

}
