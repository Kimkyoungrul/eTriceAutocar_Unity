using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2VehicleColliderScript : MonoBehaviour {

	private AudioSource Engine;

	GameObject home, cam;


	void Start()
	{
		Engine = GameObject.Find ("P2EngineSound").GetComponent<AudioSource> ();
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Road") {
			Engine.pitch = 0.9f;
		}
	}
}

