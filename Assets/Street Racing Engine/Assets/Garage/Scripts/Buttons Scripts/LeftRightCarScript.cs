using UnityEngine;
using System.Collections;

public class LeftRightCarScript : MonoBehaviour {

	public GameObject V1, V2, V3, V4, V5, V6, V7, V8, V9, V10;
	public static bool car;


	// Use this for initialization
	void Start () {
		if (BuyCarScript.V01A == 0) {
			BuyCarScript.V01A = 2;
		}
		if (BuyCarScript.V01A == 2) 	V1.SetActive (true);
		if (BuyCarScript.V02A == 2) 	V2.SetActive (true);
		if (BuyCarScript.V03A == 2) 	V3.SetActive (true);
		if (BuyCarScript.V04A == 2) 	V4.SetActive (true);
		if (BuyCarScript.V05A == 2) 	V5.SetActive (true);
		if (BuyCarScript.V06A == 2) 	V6.SetActive (true);
		if (BuyCarScript.V07A == 2) 	V7.SetActive (true);
		if (BuyCarScript.V08A == 2) 	V8.SetActive (true);
		if (BuyCarScript.V09A == 2) 	V9.SetActive (true);
		if (BuyCarScript.V10A == 2) 	V10.SetActive (true);
		car = true;
	}
	
	// Update is called once per frame
	public void Right () {
		if (V1.activeInHierarchy == true) {
			V1.SetActive (false);	V2.SetActive (true);	V3.SetActive (false);	V4.SetActive (false);	V5.SetActive (false);	V6.SetActive (false);	V7.SetActive (false);	V8.SetActive (false);	V9.SetActive (false);	V10.SetActive (false);
		} else if (V2.activeInHierarchy == true) {
			V1.SetActive (false);	V2.SetActive (false);	V3.SetActive (true);	V4.SetActive (false);	V5.SetActive (false);	V6.SetActive (false);	V7.SetActive (false);	V8.SetActive (false);	V9.SetActive (false);	V10.SetActive (false);
		} else if (V3.activeInHierarchy == true) {
			V1.SetActive (false);	V2.SetActive (false);	V3.SetActive (false);	V4.SetActive (true);	V5.SetActive (false);	V6.SetActive (false);	V7.SetActive (false);	V8.SetActive (false);	V9.SetActive (false);	V10.SetActive (false);
		} 	else if (V4.activeInHierarchy == true) {
			V1.SetActive (false);	V2.SetActive (false);	V3.SetActive (false);	V4.SetActive (false);	V5.SetActive (true);	V6.SetActive (false);	V7.SetActive (false);	V8.SetActive (false);	V9.SetActive (false);	V10.SetActive (false);
		} 	else if (V5.activeInHierarchy == true) {
			V1.SetActive (false);	V2.SetActive (false);	V3.SetActive (false);	V4.SetActive (false);	V5.SetActive (false);	V6.SetActive (true);	V7.SetActive (false);	V8.SetActive (false);	V9.SetActive (false);	V10.SetActive (false);
		} 	else if (V6.activeInHierarchy == true) {
			V1.SetActive (false);	V2.SetActive (false);	V3.SetActive (false);	V4.SetActive (false);	V5.SetActive (false);	V6.SetActive (false);	V7.SetActive (true);	V8.SetActive (false);	V9.SetActive (false);	V10.SetActive (false);
		} 	else if (V7.activeInHierarchy == true) {
			V1.SetActive (false);	V2.SetActive (false);	V3.SetActive (false);	V4.SetActive (false);	V5.SetActive (false);	V6.SetActive (false);	V7.SetActive (false);	V8.SetActive (true);	V9.SetActive (false);	V10.SetActive (false);
		} 	else if (V8.activeInHierarchy == true) {
			V1.SetActive (false);	V2.SetActive (false);	V3.SetActive (false);	V4.SetActive (false);	V5.SetActive (false);	V6.SetActive (false);	V7.SetActive (false);	V8.SetActive (false);	V9.SetActive (true);	V10.SetActive (false);
		} else if (V9.activeInHierarchy == true) {
			V1.SetActive (false);	V2.SetActive (false);	V3.SetActive (false);	V4.SetActive (false);	V5.SetActive (false);	V6.SetActive (false);	V7.SetActive (false);	V8.SetActive (false);	V9.SetActive (false);	V10.SetActive (true);
		}  
	}
	public void Left () {
			if (V2.activeInHierarchy == true) {
				V1.SetActive (true);	V2.SetActive (false);	V3.SetActive (false);	V4.SetActive (false);	V5.SetActive (false);	V6.SetActive (false);	V7.SetActive (false);	V8.SetActive (false);	V9.SetActive (false);	V10.SetActive (false);
			} else if (V3.activeInHierarchy == true) {
				V1.SetActive (false);	V2.SetActive (true);	V3.SetActive (false);	V4.SetActive (false);	V5.SetActive (false);	V6.SetActive (false);	V7.SetActive (false);	V8.SetActive (false);	V9.SetActive (false);	V10.SetActive (false);
			} else if (V4.activeInHierarchy == true) {
				V1.SetActive (false);	V2.SetActive (false);	V3.SetActive (true);	V4.SetActive (false);	V5.SetActive (false);	V6.SetActive (false);	V7.SetActive (false);	V8.SetActive (false);	V9.SetActive (false);	V10.SetActive (false);
			} 	else if (V5.activeInHierarchy == true) {
				V1.SetActive (false);	V2.SetActive (false);	V3.SetActive (false);	V4.SetActive (true);	V5.SetActive (false);	V6.SetActive (false);	V7.SetActive (false);	V8.SetActive (false);	V9.SetActive (false);	V10.SetActive (false);
			} 	else if (V6.activeInHierarchy == true) {
				V1.SetActive (false);	V2.SetActive (false);	V3.SetActive (false);	V4.SetActive (false);	V5.SetActive (true);	V6.SetActive (false);	V7.SetActive (false);	V8.SetActive (false);	V9.SetActive (false);	V10.SetActive (false);
			} 	else if (V7.activeInHierarchy == true) {
				V1.SetActive (false);	V2.SetActive (false);	V3.SetActive (false);	V4.SetActive (false);	V5.SetActive (false);	V6.SetActive (true);	V7.SetActive (false);	V8.SetActive (false);	V9.SetActive (false);	V10.SetActive (false);
			} 	else if (V8.activeInHierarchy == true) {
				V1.SetActive (false);	V2.SetActive (false);	V3.SetActive (false);	V4.SetActive (false);	V5.SetActive (false);	V6.SetActive (false);	V7.SetActive (true);	V8.SetActive (false);	V9.SetActive (false);	V10.SetActive (false);
			} 	else if (V9.activeInHierarchy == true) {
				V1.SetActive (false);	V2.SetActive (false);	V3.SetActive (false);	V4.SetActive (false);	V5.SetActive (false);	V6.SetActive (false);	V7.SetActive (false);	V8.SetActive (true);	V9.SetActive (false);	V10.SetActive (false);
			} else if (V10.activeInHierarchy == true) {
				V1.SetActive (false);	V2.SetActive (false);	V3.SetActive (false);	V4.SetActive (false);	V5.SetActive (false);	V6.SetActive (false);	V7.SetActive (false);	V8.SetActive (false);	V9.SetActive (true);	V10.SetActive (false);
	
			}  
	}
}
