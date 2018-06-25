using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class Vehicle09BodyRacingScript : MonoBehaviour {

	public BodyParts BodyPartsGameobjects;
	public static int bs, ss, es, cs;
	public Material body;

	void Awake()
	{
		bs = PlayerPrefs.GetInt ("V09B");
		ss = PlayerPrefs.GetInt ("V09S");
		es = PlayerPrefs.GetInt ("V09E");
		cs = PlayerPrefs.GetInt ("V09C");

		vehicleController.spd = 150;
		vehicleController.std = 2;
		vehicleController.nid = 0;

		if(bs == 0)
		{
			BodyPartsGameobjects.bumper01.SetActive (true);	BodyPartsGameobjects.bumper02.SetActive (false); BodyPartsGameobjects.bumper03.SetActive (false); vehicleController.speedb = 200;
		}
		if(bs == 1)
		{
			BodyPartsGameobjects.bumper01.SetActive (false);	BodyPartsGameobjects.bumper02.SetActive (true); BodyPartsGameobjects.bumper03.SetActive (false); vehicleController.nitrob = 1;
		}
		if(bs == 2)
		{
			BodyPartsGameobjects.bumper01.SetActive (false);	BodyPartsGameobjects.bumper02.SetActive (false); BodyPartsGameobjects.bumper03.SetActive (true); vehicleController.steerb = 10;
		}
		if(ss == 0)
		{
			BodyPartsGameobjects.spoiler01.SetActive (true);	BodyPartsGameobjects.spoiler02.SetActive (false); BodyPartsGameobjects.spoiler03.SetActive (false); vehicleController.nitros = 1;
		}
		if(ss == 1)
		{
			BodyPartsGameobjects.spoiler01.SetActive (false);	BodyPartsGameobjects.spoiler02.SetActive (true); BodyPartsGameobjects.spoiler03.SetActive (false);vehicleController.speeds = 200;
		}
		if(ss == 2)
		{
			BodyPartsGameobjects.spoiler01.SetActive (false);	BodyPartsGameobjects.spoiler02.SetActive (false); BodyPartsGameobjects.spoiler03.SetActive (true);vehicleController.steers = 10;
		}
		if(es == 0)
		{
			BodyPartsGameobjects.exhaust01.SetActive (true);	BodyPartsGameobjects.exhaust02.SetActive (false); BodyPartsGameobjects.exhaust03.SetActive (false);vehicleController.speede = 200;
		}
		if(es == 1)
		{
			BodyPartsGameobjects.exhaust01.SetActive (false);	BodyPartsGameobjects.exhaust02.SetActive (true); BodyPartsGameobjects.exhaust03.SetActive (false);vehicleController.steere = 10;
		}
		if(es == 2)
		{
			BodyPartsGameobjects.exhaust01.SetActive (false);	BodyPartsGameobjects.exhaust02.SetActive (false); BodyPartsGameobjects.exhaust03.SetActive (true); vehicleController.nitroe = 1;
		}
		if (cs == 0) {
			body.color = new Color(0.918f, 0.667f, 0.012f);
		}
		if (cs == 1) {
			body.color = new Color(0.8f, 0.059f, 0.059f);
		}
		if (cs == 2) {
			body.color = new Color(0.208f, 0.659f, 0.094f);
		}
		if (cs == 3) {
			body.color = new Color(0.047f, 0.729f, 0.827f);
		}
		if (cs == 4) {
			body.color = new Color(0.129f, 0.278f, 0.776f);
		}
		if (cs == 5) {
			body.color = new Color(0.561f, 0.18f, 0.667f);
		}

		PlayerPrefs.SetInt ("V09B", bs);
		PlayerPrefs.SetInt ("V09E", es);
		PlayerPrefs.SetInt ("V09S", ss);
		PlayerPrefs.SetInt ("V09C", cs);
	}
}
