using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class block : MonoBehaviour {

	public Vector3 initPos;
	public float initDist;
	public float speed;
	public float movement;

	// Use this for initialization
	void Start () {
		GameObject song = GameObject.Find("song_pref(Clone)");
		song songScript = song.GetComponent<song>();
		speed = songScript.speed;
		initPos = transform.position;
		initDist = Mathf.Abs(initPos.x + initPos.y);
	}

	// Update is called once per frame
	void Update () {
		
		float distFromSpawn = Vector3.Distance (transform.position, initPos);

		if (distFromSpawn >= (initDist)) {

			GameObject timer = GameObject.Find("timer");
			timer timerScript = timer.GetComponent<timer>();

			GameObject timeCheck = GameObject.Find("time_check");
			Text timeCheckText = timeCheck.GetComponent<Text>();
			timeCheckText.text += " " + timerScript.currentTime.ToString("F2");

			Destroy(gameObject);
		}
	}

	void FixedUpdate(){
		Vector3 move = Vector3.zero - initPos;
		movement = (move.magnitude / initDist) * speed;
		transform.Translate ((move/initDist) * speed );
	}
}
