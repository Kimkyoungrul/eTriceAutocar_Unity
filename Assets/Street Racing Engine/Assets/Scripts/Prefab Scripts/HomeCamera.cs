using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeCamera : MonoBehaviour {

	Transform player;

	// Use this for initialization
	void Awake () {
	}
	void Start()
	{
		if (GameManager.mobileOn && gameObject.name == "HomeCamera" || GameManager.cameraOp && gameObject.name == "HomeCamera" ) {
			gameObject.SetActive (false);
		}
		else if (GameManager.mobileOn == false && gameObject.name == "HomeCameraMobile" && GameManager.cameraOp == false && gameObject.name == "HomeCameraMobile") {
			gameObject.SetActive (false);
		}
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (player);
	}
}
