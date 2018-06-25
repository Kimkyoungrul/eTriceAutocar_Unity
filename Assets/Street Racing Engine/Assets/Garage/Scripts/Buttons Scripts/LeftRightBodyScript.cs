using UnityEngine;
using System.Collections;

public class LeftRightBodyScript : MonoBehaviour {

	public GameObject B, S, E, C;


	// Use this for initialization
	void Start () {
		B.SetActive (true);
		S.SetActive (false);
		E.SetActive (false);
		C.SetActive (false);
	}
	
	// Update is called once per frame
	public void Right () {
		if (B.activeInHierarchy == true) {
			B.SetActive (false);
			S.SetActive (true);
			E.SetActive (false);
			C.SetActive (false);
		} else
		if (S.activeInHierarchy == true) {
			B.SetActive (false);
			S.SetActive (false);
			E.SetActive (true);
			C.SetActive (false);
			}else
		if (E.activeInHierarchy == true) {
			B.SetActive (false);
			S.SetActive (false);
			E.SetActive (false);
			C.SetActive (true);
		}
	}
	public void Left () {
		if (C.activeInHierarchy == true) {
			B.SetActive (false);
			S.SetActive (false);
			E.SetActive (true);
			C.SetActive (false);
		} else
		if (E.activeInHierarchy == true) {
			B.SetActive (false);
			S.SetActive (true);
			E.SetActive (false);
			C.SetActive (false);
			} else
		if (S.activeInHierarchy == true) {
			B.SetActive (true);
			S.SetActive (false);
			E.SetActive (false);
			C.SetActive (false);
		}
	}
}
