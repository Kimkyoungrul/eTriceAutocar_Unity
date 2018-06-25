using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class Vehicle07BodyScript : MonoBehaviour {

	public BodyParts BodyPartsGameobjects;
	public static int bs, ss, es, cs;
	private Slider speed, steer, nitro;
	private float sp1, sp2, sp3, st1, st2, st3,ni1, ni2, ni3;
	public Material body;
	public static int onNew;

	void Awake()
	{
		bs = PlayerPrefs.GetInt ("V07B");
		ss = PlayerPrefs.GetInt ("V07S");
		es = PlayerPrefs.GetInt ("V07E");
		cs = PlayerPrefs.GetInt ("V07C");
	}

	void Start()
	{

		onNew = PlayerPrefs.GetInt ("V07N");
		if (onNew == 0) {
			cs = 5;
			PlayerPrefs.SetInt ("V07N", 1);
		}


		speed = GameObject.Find ("Speed").GetComponent<Slider> ();
		steer = GameObject.Find ("Steer").GetComponent<Slider> ();
		nitro = GameObject.Find ("Nitro").GetComponent<Slider> ();
	}

	void FixedUpdate()
	{

		speed.value = 1500 + sp1 + sp2 + sp3;
		steer.value = 50 + st1 + st2 + st3;
		nitro.value = 0 + ni1 + ni2 + ni3;


		if(bs == 0)
		{
			BodyPartsGameobjects.bumper01.SetActive (true);	BodyPartsGameobjects.bumper02.SetActive (false); BodyPartsGameobjects.bumper03.SetActive (false);sp1 = 160;
		}	else sp1 = 0;
		if(bs == 1)
		{
			BodyPartsGameobjects.bumper01.SetActive (false);	BodyPartsGameobjects.bumper02.SetActive (true); BodyPartsGameobjects.bumper03.SetActive (false); ni1 = 1;
		}	else ni1 = 0;
		if(bs == 2)
		{
			BodyPartsGameobjects.bumper01.SetActive (false);	BodyPartsGameobjects.bumper02.SetActive (false); BodyPartsGameobjects.bumper03.SetActive (true);st1 = 15;
		}	else  st1 = 0;
		if(ss == 0)
		{
			BodyPartsGameobjects.spoiler01.SetActive (true);	BodyPartsGameobjects.spoiler02.SetActive (false); BodyPartsGameobjects.spoiler03.SetActive (false); ni2 = 1;
		}	else ni2 = 0;
		if(ss == 1)
		{
			BodyPartsGameobjects.spoiler01.SetActive (false);	BodyPartsGameobjects.spoiler02.SetActive (true); BodyPartsGameobjects.spoiler03.SetActive (false);sp2 = 160;
		}	else sp2 = 0;
		if(ss == 2)
		{
			BodyPartsGameobjects.spoiler01.SetActive (false);	BodyPartsGameobjects.spoiler02.SetActive (false); BodyPartsGameobjects.spoiler03.SetActive (true);st2 = 15;
		}	else  st2 = 0;
		if(es == 0)
		{
			BodyPartsGameobjects.exhaust01.SetActive (true);	BodyPartsGameobjects.exhaust02.SetActive (false); BodyPartsGameobjects.exhaust03.SetActive (false);sp3 = 160;
		}	else sp3 = 0;
		if(es == 1)
		{
			BodyPartsGameobjects.exhaust01.SetActive (false);	BodyPartsGameobjects.exhaust02.SetActive (true); BodyPartsGameobjects.exhaust03.SetActive (false);st3 = 15;
		}	else  st3 = 0;
		if(es == 2)
		{
			BodyPartsGameobjects.exhaust01.SetActive (false);	BodyPartsGameobjects.exhaust02.SetActive (false); BodyPartsGameobjects.exhaust03.SetActive (true); ni3 = 1;
		}	else ni3 = 0;
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

		PlayerPrefs.SetInt ("V07B", bs);
		PlayerPrefs.SetInt ("V07E", es);
		PlayerPrefs.SetInt ("V07S", ss);
		PlayerPrefs.SetInt ("V07C", cs);

	}
}
