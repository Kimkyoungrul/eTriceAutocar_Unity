using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class Vehicle02BodyRacingScript : MonoBehaviour {

	public BodyParts BodyPartsGameobjects;
	public static int bs, ss, es, cs;
	public Material body;

	void Awake()
	{
		bs = PlayerPrefs.GetInt ("V02B");
		ss = PlayerPrefs.GetInt ("V02S");
		es = PlayerPrefs.GetInt ("V02E");
		cs = PlayerPrefs.GetInt ("V02C");

		vehicleController.spd = 100;
		vehicleController.std = 10;
		vehicleController.nid = 1;

		if(bs == 0)
		{
			BodyPartsGameobjects.bumper01.SetActive (true);	BodyPartsGameobjects.bumper02.SetActive (false); BodyPartsGameobjects.bumper03.SetActive (false); vehicleController.speedb = 200;
		}
		if(bs == 1)
		{
			BodyPartsGameobjects.bumper01.SetActive (false);	BodyPartsGameobjects.bumper02.SetActive (true); BodyPartsGameobjects.bumper03.SetActive (false);vehicleController.nitrob = 1;
		}
		if(bs == 2)
		{
			BodyPartsGameobjects.bumper01.SetActive (false);	BodyPartsGameobjects.bumper02.SetActive (false); BodyPartsGameobjects.bumper03.SetActive (true); vehicleController.steerb = 15;
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
			BodyPartsGameobjects.spoiler01.SetActive (false);	BodyPartsGameobjects.spoiler02.SetActive (false); BodyPartsGameobjects.spoiler03.SetActive (true);vehicleController.steers = 15;
		}
		if(es == 0)
		{
			BodyPartsGameobjects.exhaust01.SetActive (true);	BodyPartsGameobjects.exhaust02.SetActive (false); BodyPartsGameobjects.exhaust03.SetActive (false);vehicleController.speede = 200;
		}
		if(es == 1)
		{
			BodyPartsGameobjects.exhaust01.SetActive (false);	BodyPartsGameobjects.exhaust02.SetActive (true); BodyPartsGameobjects.exhaust03.SetActive (false);vehicleController.steere = 15;
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

		PlayerPrefs.SetInt ("V02B", bs);
		PlayerPrefs.SetInt ("V02E", es);
		PlayerPrefs.SetInt ("V02S", ss);
		PlayerPrefs.SetInt ("V02C", cs);
	}
}
