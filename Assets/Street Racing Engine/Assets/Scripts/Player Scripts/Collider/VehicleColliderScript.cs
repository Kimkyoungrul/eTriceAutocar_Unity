using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleColliderScript : MonoBehaviour {

	private AudioSource Engine;

	GameObject home, cam;
    public static int carInt;
    public string carName;

    void Start()
	{
		Engine = GameObject.Find ("EngineSound").GetComponent<AudioSource> ();
		home = GameObject.FindGameObjectWithTag ("HomeCam");
		cam = GameObject.FindGameObjectWithTag("PlayerCam");
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "HomeCollider")
        {
            home.SetActive(true);
            cam.SetActive(false);
        }
        if (col.gameObject.tag == "GarageCollider")
        {
            vehicleController.move = false;
            Gate.down = true;
            Gate.up = false;
        }
        if (col.gameObject.tag == "Road")
        {
            Engine.pitch = 0.9f;
        }
      /*  if (col.gameObject.tag == "TrafficCar")
        {
            Engine.pitch = 0.9f;//seulki
        }*/
    }
	void OnTriggerExit(Collider col)
	{
			if (col.gameObject.tag == "HomeCollider") {
				home.SetActive (false);
				cam.SetActive (true);
		}
	}
}
