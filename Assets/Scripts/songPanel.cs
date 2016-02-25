using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class songPanel : MonoBehaviour {

	public string title;
	public string desc;
	public string artist;
	public string bpm;
	public string cover;
	public List<int> diffs;
	public Image diff_bubble_prefab;
	public WWW img_www;

	// Use this for initialization
	IEnumerator Start () {

		// Set text fields
		GameObject title_obj = transform.Find ("t_title").gameObject;
		title_obj.GetComponent<Text>().text = title;
		GameObject desc_obj = transform.Find ("t_desc").gameObject;
		desc_obj.GetComponent<Text>().text = desc;
		GameObject artist_obj = transform.Find ("t_artist").gameObject;
		artist_obj.GetComponent<Text>().text = artist;
		GameObject bpm_obj = transform.Find ("t_bpm").gameObject;
		bpm_obj.GetComponent<Text>().text = bpm;

		// Load cover
		string img_path = "file://c:/" + Application.persistentDataPath + "/songs/" + cover;
		img_www = new WWW (img_path);
		yield return img_www;
		GameObject cover_obj = transform.Find ("i_cover").gameObject;
		if (cover == "") {
			cover_obj.GetComponent<Image> ().enabled = false;
		} else {
			Rect rec = new Rect(0, 0, img_www.texture.width, img_www.texture.height);
			Sprite img_sprite = Sprite.Create (img_www.texture, rec,new Vector2(0.5f, 0.5f),100);
			cover_obj.GetComponent<Image> ().sprite = img_sprite;
		}

		// Add diff gauges
		Sprite[] diff_bubbles = Resources.LoadAll <Sprite>("Sprites/diff_bubble");
		for (int i = 0; i < diffs.Count; i++) {
			float lvl_offset = i * 240;
			for (int j = 0; j < diffs [i]; j++) {
				float bubble_offset = j * 17.4f;
				Image img = (Image)Instantiate (diff_bubble_prefab);
				img.transform.SetParent(gameObject.transform);
				img.sprite = diff_bubbles[i];
				img.transform.localPosition = new Vector3 (-374.4f + bubble_offset + lvl_offset, -37, 0);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {

	}

}
