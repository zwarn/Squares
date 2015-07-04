using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

public class Level {
	public Vector2 size { get; set; }
	public Dictionary<Vector2, List<Thing>> objectMap { get; set; }
}
