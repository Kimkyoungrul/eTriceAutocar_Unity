using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidePlayer : MonoBehaviour {

	private bool collide;
	private bool traffic;
	private Behaviour disableTraffic;

	public static int carInt;
	public string carName;

	// Use this for initialization
	void Start () {
		collide = false;
		traffic = false;
		disableTraffic = transform.parent.gameObject.GetComponent<MoveOnPath> ();

		if (GameManager.disableTrafficOp)
			disableTraffic.enabled = false;
	}
	
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") {
			carName = transform.parent.gameObject.name;
			carName = carName.Substring (carName.Length - 2);
			carInt = int.Parse (carName) - 1;
			MoveOnPath.col [carInt] = true;
			collide = false;
		}
		if (col.gameObject.tag == "TrafficDisable" && GameManager.disableTrafficOp)
			disableTraffic.enabled = true;
	}
    /*void OnTriggerStay(Collider col)
	{
		if (col.gameObject.tag == "TrafficDisable" && GameManager.disableTrafficOp)
			disableTraffic.enabled = true;
	}
*/
	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Player") {

			if (!traffic) {
				collide = true;
				StartCoroutine (Collide ());
			}
		}
		if (col.gameObject.tag == "TrafficDisable" && GameManager.disableTrafficOp)
			disableTraffic.enabled = false;
	}



	IEnumerator Collide() {
		yield return new WaitForSeconds(2);
		if (collide) {
			carName = transform.parent.gameObject.name;
			carName = carName.Substring (carName.Length - 2);
			carInt = int.Parse (carName) - 1;
			MoveOnPath.col[carInt] = false;
		}
	}
}
