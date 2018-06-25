using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BuyVehicle06SpoilerScript : MonoBehaviour {

	int s01, s02;
	public Button spoiler;
	public GameObject v;

	// Update is called once per frame
	void Update () {
		if (v.activeInHierarchy == true) {
		if (Vehicle06BodyScript.ss == 0) {
			buy ();
		}
		s01 = PlayerPrefs.GetInt ("V06S01");
		if (Vehicle06BodyScript.ss == 1 && s01 == 1) {
			buy ();
		}
		s02 = PlayerPrefs.GetInt ("V06S02");
		if (Vehicle06BodyScript.ss == 2 && s02 == 1) {
			buy ();
		}
		}
	}
	public void PressedS()
	{	
			if (v.activeInHierarchy == true) {
		if (Vehicle06BodyScript.ss == 1 &&  s01 == 0) {
			s01 = 1;
			PlayerPrefs.SetInt ("V06S01", 1);
		}
		if (Vehicle06BodyScript.ss == 2 && s02 == 0) {
			s02 = 1;
			PlayerPrefs.SetInt ("V06S02", 1);
		}
		}
}
	void buy()
	{
		gameObject.GetComponent<Image> ().enabled = false;
		spoiler.enabled = true;
	}
}
