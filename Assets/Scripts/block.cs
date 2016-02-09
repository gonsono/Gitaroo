using UnityEngine;
using System.Collections;

public class block : MonoBehaviour {

	public Vector3 initPos;
	public float initDist;
	public float speed = 0.5f;
	public float counter = 0f;

	// Use this for initialization
	void Start () {
		initPos = transform.position;
		initDist = Mathf.Abs(initPos.x + initPos.y);
		speed = 0.5f;
		counter = 0f;
	}

	// Update is called once per frame
	void Update () {
		
		float distFromSpawn = Vector3.Distance (transform.position, initPos);

		if (distFromSpawn >= initDist) {
			Destroy(gameObject);
		}
	}

	void FixedUpdate(){
		Vector3 move = Vector3.zero - initPos;
		transform.Translate (move * (speed * (1/initDist)));
		counter += 1;
	}
}
