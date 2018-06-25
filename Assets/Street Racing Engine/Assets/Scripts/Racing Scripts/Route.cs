using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Route : MonoBehaviour {

	public GameObject[] route;
	public static int n=0;

	// Use this for initialization
	void Start () {
		route [n].SetActive(true);
	}

	public void Right()
	{
		if (n < route.Length-1) {
			route [n].SetActive (false);
			route [n + 1].SetActive (true);
			n++;
		}
	}

	public void Left()
	{
		if (n > 0) {
			route [n].SetActive (false);
			route [n - 1].SetActive (true);
			n--;
		}
	}

}
