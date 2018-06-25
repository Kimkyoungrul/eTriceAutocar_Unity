using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeInOut : MonoBehaviour {

	public static bool fade = false;
	public static int scene;

	void Start()
	{
		gameObject.GetComponent<Animation> ().Play ("FadeOut");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (fade) {
			gameObject.GetComponent<Animation> ().Play ("FadeIn");
			fade = false;
		}
	}
	public void ChangeMap()
	{
		SceneManager.LoadScene(scene);
	}
}
