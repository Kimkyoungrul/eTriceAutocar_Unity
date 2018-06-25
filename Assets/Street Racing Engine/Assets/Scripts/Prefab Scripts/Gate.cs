using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gate : MonoBehaviour {

	public static bool up, down;

	// Use this for initialization
	void Start () {
		up = true;
		down = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (up) {
			transform.position = Vector3.Lerp (transform.position, new Vector3 (transform.position.x, 15, transform.position.z), Time.deltaTime);
		}
		if (down) {
			transform.position = Vector3.Lerp (transform.position, new Vector3 (transform.position.x, 0, transform.position.z), Time.deltaTime);
		}
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "GateClosed") {
			if (down) {
				SceneManager.LoadSceneAsync(0);
			}
		}
	}
}
