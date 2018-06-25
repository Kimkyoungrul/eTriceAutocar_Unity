using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTraffic : MonoBehaviour {

	public static int VehicleCount;
	public static int MaxVehicle;

	public List<GameObject> TrafficList = new List<GameObject>();	

	// Use this for initialization
	void Start () {
		VehicleCount = 0;
		if (GameManager.mobileOn || GameManager.trafficOp) {
			foreach (GameObject carPref in Resources.LoadAll("TransportMobile", typeof(GameObject))) {
				TrafficList.Add (carPref);
			}
		} else {
				foreach (GameObject carPref in Resources.LoadAll("Transport", typeof(GameObject))) {
					TrafficList.Add (carPref);
			}
		}
	}
	void Update()
	{
		if (VehicleCount < MaxVehicle) {
			int random = UnityEngine.Random.Range (0, 3);
			if (random == 1) {
				VehicleCount++;
				int prefabIndex = UnityEngine.Random.Range (0, TrafficList.Count);		
				GameObject Transport = Instantiate (TrafficList [prefabIndex], new Vector3 (transform.position.x, transform.position.y, transform.position.z), transform.rotation) as GameObject;
				if (VehicleCount < 10) {
					Transport.name = "Car0" + VehicleCount;
				} else {
					Transport.name = "Car" + VehicleCount;
				}
			}
		} else {
			gameObject.GetComponent<SpawnTraffic> ().enabled = false;
		}
	}
}
