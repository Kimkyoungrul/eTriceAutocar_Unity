using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P2Countdown : MonoBehaviour {

	Text count;
	Behaviour move;
	private int n;

	// Use this for initialization
	void Start () {
		count = gameObject.GetComponent<Text> ();
		P2vehicleController.move = false;
		StartCoroutine (Counting ());
		n = 3;
		count.text = n.ToString();
	}
	
			IEnumerator Counting() {
		yield return new WaitForSeconds (1);
		n--;
		count.text = n.ToString();
		if (n > 0) {
			StartCoroutine (Counting ());
		} else {
			gameObject.SetActive (false);
			P2vehicleController.move = true;
			P2Timer.count = true;
		}
	}
}
