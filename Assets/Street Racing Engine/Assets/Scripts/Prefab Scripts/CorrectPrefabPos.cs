using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CorrectPrefabPos : MonoBehaviour {

	private float x, z;
	public static bool corPos;

	#if UNITY_EDITOR
	void Update () {
		Transform model = gameObject.transform.Find ("Model").gameObject.GetComponent<Transform> ();
		x = Mathf.Round (gameObject.transform.position.x) * 75;
		z = Mathf.Round (gameObject.transform.position.z) * 75;
		model.position = new Vector3 (x, model.position.y, z);
//		gameObject.transform.position = new Vector3 (Mathf.Round (gameObject.transform.position.x), gameObject.transform.transform.position.y, Mathf.Round (gameObject.transform.transform.position.z));
	}
	#endif
}
