using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTrafficPath : MonoBehaviour {

	public TrafficPathFollow[] allPaths;
	public static List<TrafficPathFollow> cPath = new List<TrafficPathFollow>();
	public static int carInt;
	public string carName;
	public static bool start;

	// Use this for initialization
	void Start () {
		
		int num = Random.Range (0, allPaths.Length);    //0부터 allPaths.Length중에 랜덤값
		transform.position = allPaths [num].transform.position; 
		cPath.Add (allPaths [num]);
		start = false;

	}


	// Update is called once per frame
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "SideCollider") {//도로의 끝의 boxcollider와 차의 sideCollider가 부딪쳤을때
			var carObj = col.gameObject;
			carName = carObj.transform.parent.gameObject.name;
			if (carName.Length == 5) {
				carName = carName.Substring (carName.Length - 2);
				carInt = int.Parse(carName)-1;
			} else {
				carName = carName.Substring (carName.Length - 3);
				carInt = int.Parse(carName);
			}
			start = true;
			int num = Random.Range (0, allPaths.Length);
			transform.position = allPaths [num].transform.position; 
			cPath[carInt] = allPaths [num];
        
			}
		}
	}
