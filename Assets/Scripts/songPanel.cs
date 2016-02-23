using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class songPanel : MonoBehaviour {

	public string title;
	public string desc;
	public string artist;
	public string bpm;

	// Use this for initialization
	void Start () {
		GameObject title_obj = transform.Find ("t_title").gameObject;
		title_obj.GetComponent<Text>().text = title;
		GameObject desc_obj = transform.Find ("t_desc").gameObject;
		desc_obj.GetComponent<Text>().text = desc;
		GameObject artist_obj = transform.Find ("t_artist").gameObject;
		artist_obj.GetComponent<Text>().text = artist;
		GameObject bpm_obj = transform.Find ("t_bpm").gameObject;
		bpm_obj.GetComponent<Text>().text = bpm;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
