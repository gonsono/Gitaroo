using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class song : MonoBehaviour {

	// Use this for initialization
	void Start () {

		List<DefBlockTrigger> defBlocks = new List<DefBlockTrigger> ();
		defBlocks.Add (new DefBlockTrigger ("up",1.00f));
		defBlocks.Add (new DefBlockTrigger ("up",2.00f));
		defBlocks.Add (new DefBlockTrigger ("down",3.00f));
		defBlocks.Add (new DefBlockTrigger ("down",3.50f));
		defBlocks.Add (new DefBlockTrigger ("left",4.00f));
		defBlocks.Add (new DefBlockTrigger ("right",4.25f));
		defBlocks.Add (new DefBlockTrigger ("right",5.00f));


	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	void FixedUpdate () {

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
