using UnityEngine;
using System.Collections;

public class block : MonoBehaviour {

	public Vector3 initPos;
	public float initDist;

	// Use this for initialization
	void Start () {
		initPos = transform.position;
	}

	// Update is called once per frame
	void Update () {
		
		float distFromSpawn = Vector3.Distance (transform.position, initPos);
		initDist = Mathf.Abs(initPos.x + initPos.y);

		if (distFromSpawn >= initDist) {
			Destroy(gameObject);
		}
	}
}
