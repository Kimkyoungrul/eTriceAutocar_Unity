using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1VehicleColliderScript : MonoBehaviour {

	private AudioSource Engine;

	GameObject home, cam;


	void Start()
	{
			Engine = GameObject.Find ("P1EngineSound").GetComponent<AudioSource> ();
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Road") {
			Engine.pitch = 0.9f;
		}
	}
}

