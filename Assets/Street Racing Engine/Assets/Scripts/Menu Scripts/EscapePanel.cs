using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapePanel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			transform.Find ("EscapePanel").gameObject.SetActive (true);
			vehicleController.move = false;
			P1vehicleController.move = false;
			P2vehicleController.move = false;
		}
	}
}
