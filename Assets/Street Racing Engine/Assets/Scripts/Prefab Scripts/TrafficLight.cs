using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour {

	public bool redlight;
	public GameObject red, yellow, green;
	public GameObject col;
	private float timer;

	// Use this for initialization
	void Start (){
		if (redlight == true) {
			StartCoroutine (RedLight ());
		}	else StartCoroutine (GreenLight ());
		}
	
	// Update is called once per frame
	void Update () {
	}
	IEnumerator RedLight() {
		red.SetActive (true);
		yield return new WaitForSeconds(9);
		yellow.SetActive (true);		yield return new WaitForSeconds(1);
		col.transform.position = new Vector3 (col.transform.position.x, col.transform.position.y - 5, col.transform.position.z);
		yellow.SetActive (false);
		red.SetActive (false);
		StartCoroutine (GreenLight ());
	}
	IEnumerator GreenLight() {
		green.SetActive (true);
		yield return new WaitForSeconds(4);
		col.transform.position = new Vector3 (col.transform.position.x, col.transform.position.y + 5, col.transform.position.z);
		StartCoroutine (RedLight ());
		green.SetActive (false);

	}
}
