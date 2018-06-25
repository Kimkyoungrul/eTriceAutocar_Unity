using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BuyVehicle09BumperScript : MonoBehaviour {

	int b01, b02;
	public Button bumper;
	public GameObject v;
	
	// Update is called once per frame
	void Update () {
		if (v.activeInHierarchy == true) {
			if (Vehicle09BodyScript.bs == 0) {
				buy ();
			}
			b01 = PlayerPrefs.GetInt ("V09B01");
			if (Vehicle09BodyScript.bs == 1 && b01 == 1) {
				buy ();
			}
			b02 = PlayerPrefs.GetInt ("V09B02");
			if (Vehicle09BodyScript.bs == 2 && b02 == 1) {
				buy ();
			}
		}
	}
	public void PressedB()
	{	
		if (v.activeInHierarchy == true) {
			if (Vehicle09BodyScript.bs == 1 && b01 == 0) {
				b01 = 1;
				PlayerPrefs.SetInt ("V09B01", 1);
			}
			if (Vehicle09BodyScript.bs == 2 && b02 == 0) {
				b02 = 1;
				PlayerPrefs.SetInt ("V09B02", 1);
			}
		}
}
	void buy()
	{
		gameObject.GetComponent<Image> ().enabled = false;
		bumper.enabled = true;
	}
}
