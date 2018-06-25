using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour {

	private Light lights;

	// Use this for initialization
	void Start () {
		lights = gameObject.GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Mathf.Round(DayNightTime.currentHour) == 20 || Mathf.Round(DayNightTime.currentHour) == 0 ) {
			lights.enabled = true;
		}	else if(Mathf.Round(DayNightTime.currentHour) == 7 || Mathf.Round(DayNightTime.currentHour) == 12) {
			lights.enabled = false;
	}
}
}
