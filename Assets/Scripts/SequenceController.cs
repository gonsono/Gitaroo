using UnityEngine;
using System.Collections;

public class SequenceController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void FixedUpdate () {
		transform.Translate (1, 0, 0);
	}

}
