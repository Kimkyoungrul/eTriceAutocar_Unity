using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1Finish : MonoBehaviour {

	Transform statistic;
	public static bool finish;

	// Use this for initialization
	void Start () {
		statistic = GameObject.FindGameObjectWithTag("Statistic").GetComponent<Transform>();
		statistic.localScale = new Vector3(0,0.7f,1);
	}
	
	void OnTriggerEnter(Collider col)
	{

		if (col.gameObject.tag == "P1") {
			P1Timer.count = false;
			P1vehicleController.move = false;
			finish = true;
			if (P2vehicleController.move == false) {
				statistic.localScale = new Vector3 (0.5f, 0.7f, 1);
			}
		}
	}
}
