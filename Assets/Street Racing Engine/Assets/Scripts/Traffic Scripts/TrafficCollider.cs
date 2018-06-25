using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficCollider : MonoBehaviour {

	private bool collide;
	private bool traffic;



	public static int carInt;
	public string carName;

	void Start()
	{
		collide = false;
		traffic = false;
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") {
			carName = transform.parent.gameObject.name;
			if (carName.Length == 5) {
				carName = carName.Substring (carName.Length - 2);
				carInt = int.Parse(carName)-1;
			} else {
				carName = carName.Substring (carName.Length - 3);
				carInt = int.Parse(carName);
			}
			MoveOnPath.col[carInt] = true;
			collide = true;
		}
		if (col.gameObject.tag == "Col") {
			carName = transform.parent.gameObject.name;
			if (carName.Length == 5) {
				carName = carName.Substring (carName.Length - 2);
				carInt = int.Parse(carName)-1;
			} else {
				carName = carName.Substring (carName.Length - 3);
				carInt = int.Parse(carName);
			}
			MoveOnPath.col[carInt] = true;
			traffic = false;
		}
		if (col.gameObject.tag == "SideCollider") {
			carName = transform.parent.gameObject.name;
			if (carName.Length == 5) {
				carName = carName.Substring (carName.Length - 2);
				carInt = int.Parse(carName)-1;
			} else {
				carName = carName.Substring (carName.Length - 3);
				carInt = int.Parse(carName);
			}
			MoveOnPath.col[carInt] = true;
			traffic = true;
		}
	}

	void OnTriggerStay(Collider col)
	{
		if (col.gameObject.tag == "Player") {
			carName = transform.parent.gameObject.name;
			if (carName.Length == 5) {
				carName = carName.Substring (carName.Length - 2);
				carInt = int.Parse(carName)-1;
			} else {
				carName = carName.Substring (carName.Length - 3);
				carInt = int.Parse(carName);
			}
			MoveOnPath.col[carInt] = true;
			collide = true;
		}
		if (col.gameObject.tag == "Col") {
			carName = transform.parent.gameObject.name;
			if (carName.Length == 5) {
				carName = carName.Substring (carName.Length - 2);
				carInt = int.Parse(carName)-1;
			} else {
				carName = carName.Substring (carName.Length - 3);
				carInt = int.Parse(carName);
			}
			MoveOnPath.col[carInt] = true;
			traffic = true;
		}
		if (col.gameObject.tag == "SideCollider") {
			carName = transform.parent.gameObject.name;
			if (carName.Length == 5) {
				carName = carName.Substring (carName.Length - 2);
				carInt = int.Parse(carName)-1;
			} else {
				carName = carName.Substring (carName.Length - 3);
				carInt = int.Parse(carName);
			}
			MoveOnPath.col[carInt] = true;
			traffic = true;
		}
	}

	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Player") {
			
			if (!traffic) {
				collide = true;
				StartCoroutine (CollidePlayer ());
			}
		}
		if (col.gameObject.tag == "Col") {
			{
				collide = true;
				traffic = false;
				StartCoroutine (CollideTraffic ());
			}
		}
		if (col.gameObject.tag == "SideCollider") {
			collide = true;
			traffic = false;
			StartCoroutine (CollideTraffic ());
		}
	}

	IEnumerator CollideTraffic() {
		yield return new WaitForSeconds(0);
		if (collide) {
			carName = transform.parent.gameObject.name;
			if (carName.Length == 5) {
				carName = carName.Substring (carName.Length - 2);
				carInt = int.Parse(carName)-1;
			} else {
				carName = carName.Substring (carName.Length - 3);
				carInt = int.Parse(carName);
			}
			MoveOnPath.col [carInt] = false;
		}
	}

	IEnumerator CollidePlayer() {
		yield return new WaitForSeconds(2);
		if (collide) {
			carName = transform.parent.gameObject.name;
			if (carName.Length == 5) {
				carName = carName.Substring (carName.Length - 2);
				carInt = int.Parse(carName)-1;
			} else {
				carName = carName.Substring (carName.Length - 3);
				carInt = int.Parse(carName);
			}
			MoveOnPath.col[carInt] = false;
		}
	}
}
