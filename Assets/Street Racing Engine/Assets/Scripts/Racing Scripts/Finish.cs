using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour {

	Transform statistic;

	// Use this for initialization
	void Start () {
		statistic = GameObject.FindGameObjectWithTag("Statistic").GetComponent<Transform>();
		statistic.localScale = new Vector3(0,0.7f,1);
	}
	
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") {
			Timer.count = false;
			Statistics.finish = true;
			statistic.localScale = new Vector3 (0.5f, 0.7f, 1);
			vehicleController.move = false;
		}
	}
}
