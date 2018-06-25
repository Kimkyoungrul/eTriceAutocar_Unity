using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BuyVehicle06ExhaustScript : MonoBehaviour {

	int e01, e02;
	public Button exhaust;
	public GameObject v;

	// Update is called once per frame
	void Update () {
		if (v.activeInHierarchy == true) {
			if (Vehicle06BodyScript.es == 0) {
				buy ();
			}
			e01 = PlayerPrefs.GetInt ("V06E01");
			if (Vehicle06BodyScript.es == 1 && e01 == 1) {
				buy ();
			}
			e02 = PlayerPrefs.GetInt ("V06E02");
			if (Vehicle06BodyScript.es == 2 && e02 == 1) {
				buy ();
			}
		}
	}
	public void PressedE()
	{	
		if (v.activeInHierarchy == true) {
			if (Vehicle06BodyScript.es == 1 && e01 == 0) {
				e01 = 1;
				PlayerPrefs.SetInt ("V06E01", 1);
			}
			if (Vehicle06BodyScript.es == 2 && e02 == 0) {
				e02 = 1;
				PlayerPrefs.SetInt ("V06E02", 1);
			}
		}
}
	void buy()
	{
		gameObject.GetComponent<Image> ().enabled = false;
		exhaust.enabled = true;
	}
}
