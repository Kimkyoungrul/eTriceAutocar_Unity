using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

	Text count;
	Behaviour move;
	private int n;
	public GameObject sound;

	// Use this for initialization
	void Start () {
		count = gameObject.GetComponent<Text> ();
		Timer.count = false;
		vehicleController.move = false;
		StartCoroutine (Counting ());
		n = 3;
		count.text = n.ToString();
	}
	
			IEnumerator Counting() {
		sound.SetActive (true);
		yield return new WaitForSeconds (1);
		n--;
		count.text = n.ToString();
		if (n > 0) {
			StartCoroutine (Counting ());
		} else {
			gameObject.SetActive (false);
			vehicleController.move = true;
			Timer.count = true;
		}
	}
}
