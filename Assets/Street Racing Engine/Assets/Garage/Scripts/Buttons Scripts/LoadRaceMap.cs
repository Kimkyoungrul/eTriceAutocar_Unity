using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadRaceMap : MonoBehaviour {

	public static bool race;

	// Use this for initialization
	void Start () {
		
	}

	public void LoadMap()
	{
		if (MultiPlayerCanvas.multiplayer) {
			FadeInOut.fade = true;
			FadeInOut.scene = 2;
			race = true;
		} else {
			FadeInOut.fade = true;
			FadeInOut.scene = 2;
			race = true;
		}
		gameObject.transform.parent.gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
