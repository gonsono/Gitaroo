using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class song : MonoBehaviour {

	public List<DefBlockTrigger> defBlocks = new List<DefBlockTrigger> ();
	public float dist;
	public float speed;
	public float timeSpeed;
	public float spawnDelay;
	public List<DefBlockTrigger> spawnList;
	public timer timerScript;


	// Use this for initialization
	void Start () {

		speed = 0.5f;
		dist = 30.0f;
		timeSpeed = Time.fixedDeltaTime;
		spawnDelay = (dist / speed) * timeSpeed;
		
		defBlocks.Add (new DefBlockTrigger ("left",4.00f));
		defBlocks.Add (new DefBlockTrigger ("right",4.25f));
		defBlocks.Add (new DefBlockTrigger ("right",5.00f));
		defBlocks.Add (new DefBlockTrigger ("up",6.00f));
		defBlocks.Add (new DefBlockTrigger ("up",6.20f));
		defBlocks.Add (new DefBlockTrigger ("down",6.50f));
		defBlocks.Add (new DefBlockTrigger ("down",7.00f));

		spawnList = GetSpawnList (defBlocks);

		GameObject timer = GameObject.Find("timer");
		timerScript = timer.GetComponent<timer>();
		timerScript.ResetTimer ();

	}
	
	// Update is called once per frame
	void Update () {

	}
		
	void FixedUpdate () {
		foreach(DefBlockTrigger d in spawnList) {
			if (Mathf.Abs(timerScript.currentTime - d.timeStamp) < 0.01f) {
				GameObject spawn = GameObject.Find(d.block + "_spawn");
				spawn spawnScript = spawn.GetComponent<spawn> ();
				spawnScript.Spawn ();
			}
		}
	}

	private List<DefBlockTrigger> GetSpawnList (List<DefBlockTrigger> defBlocks) {

		List<DefBlockTrigger> spawnList = new List<DefBlockTrigger> ();

		foreach (DefBlockTrigger d in defBlocks) {
			spawnList.Add(new DefBlockTrigger (d.block,d.timeStamp - spawnDelay));
		}
		return spawnList;
	}

	public class DefBlockTrigger {
		public string block;
		public float timeStamp;

		public DefBlockTrigger(string newBlock, float newTimeStamp)
		{
			block = newBlock;
			timeStamp = newTimeStamp;
		}
	}

}
