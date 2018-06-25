using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainCross : MonoBehaviour {


	public bool start, end;
	public GameObject[] Pole = new GameObject[1];

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(start)
		{
			Pole [0].GetComponent<Animation> ().Play ("LeftPoleDown");
			Pole [1].GetComponent<Animation> ().Play ("RightPoleDown");
		}
			if (end) {
			Pole [0].GetComponent<Animation> ().Play ("LeftPoleUp");
				Pole [1].GetComponent<Animation> ().Play ("RightPoleUp");	
			}
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "TrainEnd") {
			if (gameObject.name == "End") {
				end = true;
			}
		}
		if (col.gameObject.tag == "TrainStart") {
			if (gameObject.name == "Start") {
				start = true;
			}
		}
	}
	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "TrainStart") {
			if (gameObject.name == "Start") {
				start = false;
			}
		}
		if (col.gameObject.tag == "TrainEnd") {
			if (gameObject.name == "End") {
				end = false;
		}
	}
}
}