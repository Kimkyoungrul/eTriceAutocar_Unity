﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P2Finish : MonoBehaviour {

	Transform statistic;
	public static bool finish;

	// Use this for initialization
	void Start () {
		statistic = GameObject.FindGameObjectWithTag("Statistic").GetComponent<Transform>();
		statistic.localScale = new Vector3(0,0.7f,1);
	}
	
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "P2") {
			P2Timer.count = false;
			finish = true;
			P2vehicleController.move = false;
			if (P1vehicleController.move == false) {
				statistic.localScale = new Vector3 (0.5f, 0.7f, 1);
			}

		}
	}
}