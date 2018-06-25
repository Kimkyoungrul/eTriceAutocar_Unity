using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceMap : MonoBehaviour {

	public static int route;

	// Use this for initialization
	void Start () {
		string routeName = gameObject.name;
		routeName = routeName.Substring (routeName.Length - 2);
		route = int.Parse(routeName);
	}


	
	// Update is called once per frame
	void Update () {
		
	}
}
