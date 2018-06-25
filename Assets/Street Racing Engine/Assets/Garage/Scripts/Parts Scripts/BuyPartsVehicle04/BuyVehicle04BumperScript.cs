using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BuyVehicle04BumperScript : MonoBehaviour {

	int b01, b02;
	public Button bumper;
	public GameObject v;
	
	// Update is called once per frame
	void Update () {
		if (v.activeInHierarchy == true) {
			if (Vehicle04BodyScript.bs == 0) {
				buy ();
			}
			b01 = PlayerPrefs.GetInt ("V04B01");
			if (Vehicle04BodyScript.bs == 1 && b01 == 1) {
				buy ();
			}
			b02 = PlayerPrefs.GetInt ("V04B02");
			if (Vehicle04BodyScript.bs == 2 && b02 == 1) {
				buy ();
			}
		}
	}
	public void PressedB()
	{	
		if (v.activeInHierarchy == true) {
			if (Vehicle04BodyScript.bs == 1 && b01 == 0) {
				b01 = 1;
				PlayerPrefs.SetInt ("V04B01", 1);
			}
			if (Vehicle04BodyScript.bs == 2 && b02 == 0) {
				b02 = 1;
				PlayerPrefs.SetInt ("V04B02", 1);
			}
		}
}
	void buy()
	{
		gameObject.GetComponent<Image> ().enabled = false;
		bumper.enabled = true;
	}
}
