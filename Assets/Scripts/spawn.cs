using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {

	public float speed = 2f;
	public Rigidbody2D def_pref;
	public string button = "Fire1";

	// Use this for initialization
	void Start () {
	}

	public void Spawn () {
		//Rigidbody2D Block = (Rigidbody2D) Instantiate(def_pref, transform.position, transform.rotation);
		Instantiate(def_pref, transform.position, transform.rotation);
	}

	// Update is called once per frame
	void Update () {

//		if (Input.GetButtonDown(button)) {
//		Spawn();
//		}
	}
}
