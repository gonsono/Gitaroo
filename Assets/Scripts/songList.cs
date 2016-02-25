using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using SimpleJson;
using System.Text;

public class songList : MonoBehaviour {
	
	private songMetaData songJson;
	public songPanel song_panel_prefab;

	void Start () {

		// Rect localRect = GetComponent<Rect>();

		string songsPath = Application.persistentDataPath + "/songs/";
		List<string> allSongPaths = new List<string>(Directory.GetFiles(songsPath));
		for (int i = 0; i < allSongPaths.Count; i++) {
			string songFile;
			using (StreamReader streamReader = new StreamReader (allSongPaths[i], Encoding.UTF8)) {
				songFile = streamReader.ReadToEnd ();
			}
			songJson = JsonUtility.FromJson<songMetaData> (songFile);

			songPanel song_panel = (songPanel)Instantiate (song_panel_prefab);
			// 40 * -470
			int offset = i * 120;
			song_panel.transform.SetParent(gameObject.transform);
			song_panel.transform.localPosition = new Vector3 (50, 200 - offset, 0);
			song_panel.title = songJson.title;
			song_panel.artist = songJson.artist;
			song_panel.desc = songJson.description;
			song_panel.bpm = songJson.bpm + " bpm";
			song_panel.diffs = songJson.difficulties;
			song_panel.cover = songJson.image;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}

[Serializable]
public class allSongs
{
	public List<songMetaData> songs;
}

[Serializable]
public class songMetaData
{
	public string title;
	public string artist;
	public string description;
	public string genre;
	public string group;
	public string duration;
	public string bpm;
	public string image;
	public List<int> difficulties;
	public string url;
	public string theme;
}
