using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class songPanel : MonoBehaviour {

	public string title;
	public string desc;
	public string artist;
	public string bpm;
	public List<int> diffs;
	public Image diff_bubble_prefab;

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

		// Add diff gauges
		Sprite[] diff_bubbles = Resources.LoadAll <Sprite>("Sprites/diff_bubble");
		for (int i = 0; i < diffs.Count; i++) {
			float lvl_offset = i * 256;
			for (int j = 0; j < diffs [i]; j++) {
				float bubble_offset = j * 17.4f;
				Image img = (Image)Instantiate (diff_bubble_prefab);
				img.transform.SetParent(gameObject.transform);
				img.sprite = diff_bubbles[i];
				img.transform.localPosition = new Vector3 (-334.3f + bubble_offset + lvl_offset, -37, 0);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
