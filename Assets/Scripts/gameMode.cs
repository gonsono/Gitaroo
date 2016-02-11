using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameMode : MonoBehaviour {

	public string currentGameMode;
	private SpotController SpotControllerScript;

	// Use this for initialization
	void Start () {
		GameObject SpotController = GameObject.Find("ControlSpot");
		SpotControllerScript = SpotController.GetComponent<SpotController>();

	}
	
	// Update is called once per frame
	void Update () {
		currentGameMode = SpotControllerScript.gameMode;
		Text gameModeText = GetComponent<Text>();
		gameModeText.text = currentGameMode;
	}
}
