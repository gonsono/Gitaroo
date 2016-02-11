using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timer : MonoBehaviour {

	public float currentTime = 0.00f;
	// Use this for initialization
	void Start () {
		currentTime = 0.00f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		currentTime += Time.fixedDeltaTime;
		Text timerText = GetComponent<Text>();
		timerText.text = currentTime.ToString("F2");
	}

	public void ResetTimer (){
		currentTime = 0;
	}
}
