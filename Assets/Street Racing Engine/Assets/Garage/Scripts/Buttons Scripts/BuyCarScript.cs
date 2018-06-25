using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BuyCarScript : MonoBehaviour {

	public static int V01A, V02A, V03A, V04A, V05A, V06A, V07A, V08A, V09A, V10A;
	public Image buy, choose;
	public Button bumper, spoiler, exhaust;
	public Vehicle V;

	void Awake()
	{
		V01A = PlayerPrefs.GetInt("V01A");
		V02A = PlayerPrefs.GetInt("V02A");
		V03A = PlayerPrefs.GetInt("V03A");
		V04A = PlayerPrefs.GetInt("V04A");
		V05A = PlayerPrefs.GetInt("V05A");
		V06A = PlayerPrefs.GetInt("V06A");
		V07A = PlayerPrefs.GetInt("V07A");
		V08A = PlayerPrefs.GetInt("V08A");
		V09A = PlayerPrefs.GetInt("V09A");
		V10A = PlayerPrefs.GetInt("V10A");
	}

	void Start()
	{
		if (V01A == 0)
			PlayerPrefs.SetInt ("V01A", 2);
	}

	// Update is called once per frame
	void Update () {
		V01A = PlayerPrefs.GetInt("V01A");
		V02A = PlayerPrefs.GetInt("V02A");
		V03A = PlayerPrefs.GetInt("V03A");
		V04A = PlayerPrefs.GetInt("V04A");
		V05A = PlayerPrefs.GetInt("V05A");
		V06A = PlayerPrefs.GetInt("V06A");
		V07A = PlayerPrefs.GetInt("V07A");
		V08A = PlayerPrefs.GetInt("V08A");
		V09A = PlayerPrefs.GetInt("V09A");
		V10A = PlayerPrefs.GetInt("V10A");

		if (V.V1.activeInHierarchy == true && V01A == 0) NotBuy(); else if (V.V1.activeInHierarchy == true && V01A == 1)	Buy ();	else if (V.V1.activeInHierarchy == true && V01A == 2)	Choose ();
		if (V.V2.activeInHierarchy == true && V02A == 0) NotBuy(); else if (V.V2.activeInHierarchy == true && V02A == 1)	Buy ();	else if (V.V2.activeInHierarchy == true && V02A == 2)	Choose ();
		if (V.V3.activeInHierarchy == true && V03A == 0) NotBuy(); else if (V.V3.activeInHierarchy == true && V03A == 1)	Buy ();	else if (V.V3.activeInHierarchy == true && V03A == 2)	Choose ();
		if (V.V4.activeInHierarchy == true && V04A == 0) NotBuy(); else if (V.V4.activeInHierarchy == true && V04A == 1)	Buy ();	else if (V.V4.activeInHierarchy == true && V04A == 2)	Choose ();
		if (V.V5.activeInHierarchy == true && V05A == 0) NotBuy(); else if (V.V5.activeInHierarchy == true && V05A == 1)	Buy ();	else if (V.V5.activeInHierarchy == true && V05A == 2)	Choose ();
		if (V.V6.activeInHierarchy == true && V06A == 0) NotBuy(); else if (V.V6.activeInHierarchy == true && V06A == 1)	Buy ();	else if (V.V6.activeInHierarchy == true && V06A == 2)	Choose ();
		if (V.V7.activeInHierarchy == true && V07A == 0) NotBuy(); else if (V.V7.activeInHierarchy == true && V07A == 1)	Buy ();	else if (V.V7.activeInHierarchy == true && V07A == 2)	Choose ();
		if (V.V8.activeInHierarchy == true && V08A == 0) NotBuy(); else if (V.V8.activeInHierarchy == true && V08A == 1)	Buy ();	else if (V.V8.activeInHierarchy == true && V08A == 2)	Choose ();
		if (V.V9.activeInHierarchy == true && V09A == 0) NotBuy(); else if (V.V9.activeInHierarchy == true && V09A == 1)	Buy ();	else if (V.V9.activeInHierarchy == true && V09A == 2)	Choose ();
		if (V.V10.activeInHierarchy == true && V10A == 0) NotBuy(); else if (V.V10.activeInHierarchy == true && V10A == 1)	Buy ();	else if (V.V10.activeInHierarchy == true && V10A == 2)	Choose ();
	}
	public void PressedBuy ()
	{
		if (V.V1.activeInHierarchy == true) {
			Buy ();		PlayerPrefs.SetInt("V01A", 1);
		}
		if (V.V2.activeInHierarchy == true) {
			Buy ();		PlayerPrefs.SetInt("V02A", 1);
		}
		if (V.V3.activeInHierarchy == true) {
			Buy ();		PlayerPrefs.SetInt("V03A", 1);
		}
		if (V.V4.activeInHierarchy == true) {
			Buy ();		PlayerPrefs.SetInt("V04A", 1);
		}
		if (V.V5.activeInHierarchy == true) {
			Buy ();		PlayerPrefs.SetInt("V05A", 1);
		}
		if (V.V6.activeInHierarchy == true) {
			Buy ();		PlayerPrefs.SetInt("V06A", 1);
		}
		if (V.V7.activeInHierarchy == true) {
			Buy ();		PlayerPrefs.SetInt("V07A", 1);
		}
		if (V.V8.activeInHierarchy == true) {
			Buy ();		PlayerPrefs.SetInt("V08A", 1);
		}
		if (V.V9.activeInHierarchy == true) {
			Buy ();		PlayerPrefs.SetInt("V09A", 1);
		}
		if (V.V10.activeInHierarchy == true) {
			Buy ();		PlayerPrefs.SetInt("V10A", 1);
		}
	}
	public void PressedChoose()
	{
		if (V.V1.activeInHierarchy == true) {
			Choose();		
			PlayerPrefs.SetInt("V01A", 2);	
			if(V02A == 2) PlayerPrefs.SetInt("V02A", 1);		
			if(V03A == 2) PlayerPrefs.SetInt("V03A", 1);		
			if(V04A == 2) PlayerPrefs.SetInt("V04A", 1);		
			if(V05A == 2) PlayerPrefs.SetInt("V05A", 1);		
			if(V06A == 2) PlayerPrefs.SetInt("V06A", 1);		
			if(V07A == 2) PlayerPrefs.SetInt("V07A", 1);		
			if(V08A == 2) PlayerPrefs.SetInt("V08A", 1);		
			if(V09A == 2) PlayerPrefs.SetInt("V09A", 1);		
			if(V10A == 2) PlayerPrefs.SetInt("V10A", 1);
		}
		if (V.V2.activeInHierarchy == true) {
			Choose();		
			PlayerPrefs.SetInt("V02A", 2);	
			if(V01A == 2) PlayerPrefs.SetInt("V01A", 1);		
			if(V03A == 2) PlayerPrefs.SetInt("V03A", 1);		
			if(V04A == 2) PlayerPrefs.SetInt("V04A", 1);		
			if(V05A == 2) PlayerPrefs.SetInt("V05A", 1);		
			if(V06A == 2) PlayerPrefs.SetInt("V06A", 1);		
			if(V07A == 2) PlayerPrefs.SetInt("V07A", 1);		
			if(V08A == 2) PlayerPrefs.SetInt("V08A", 1);		
			if(V09A == 2) PlayerPrefs.SetInt("V09A", 1);		
			if(V10A == 2) PlayerPrefs.SetInt("V10A", 1);
		}
		if (V.V3.activeInHierarchy == true) {
			Choose();		
			PlayerPrefs.SetInt("V03A", 2);	
			if(V02A == 2) PlayerPrefs.SetInt("V02A", 1);		
			if(V01A == 2) PlayerPrefs.SetInt("V01A", 1);		
			if(V04A == 2) PlayerPrefs.SetInt("V04A", 1);		
			if(V05A == 2) PlayerPrefs.SetInt("V05A", 1);		
			if(V06A == 2) PlayerPrefs.SetInt("V06A", 1);		
			if(V07A == 2) PlayerPrefs.SetInt("V07A", 1);		
			if(V08A == 2) PlayerPrefs.SetInt("V08A", 1);		
			if(V09A == 2) PlayerPrefs.SetInt("V09A", 1);		
			if(V10A == 2) PlayerPrefs.SetInt("V10A", 1);
		}
		if (V.V4.activeInHierarchy == true) {
			Choose();		
			PlayerPrefs.SetInt("V04A", 2);	
			if(V01A == 2) PlayerPrefs.SetInt("V01A", 1);		
			if(V03A == 2) PlayerPrefs.SetInt("V03A", 1);		
			if(V02A == 2) PlayerPrefs.SetInt("V02A", 1);		
			if(V05A == 2) PlayerPrefs.SetInt("V05A", 1);		
			if(V06A == 2) PlayerPrefs.SetInt("V06A", 1);		
			if(V07A == 2) PlayerPrefs.SetInt("V07A", 1);		
			if(V08A == 2) PlayerPrefs.SetInt("V08A", 1);		
			if(V09A == 2) PlayerPrefs.SetInt("V09A", 1);		
			if(V10A == 2) PlayerPrefs.SetInt("V10A", 1);
		}
		if (V.V5.activeInHierarchy == true) {
			Choose();		
			PlayerPrefs.SetInt("V05A", 2);	
			if(V02A == 2) PlayerPrefs.SetInt("V02A", 1);		
			if(V03A == 2) PlayerPrefs.SetInt("V03A", 1);		
			if(V04A == 2) PlayerPrefs.SetInt("V04A", 1);		
			if(V01A == 2) PlayerPrefs.SetInt("V01A", 1);		
			if(V06A == 2) PlayerPrefs.SetInt("V06A", 1);		
			if(V07A == 2) PlayerPrefs.SetInt("V07A", 1);		
			if(V08A == 2) PlayerPrefs.SetInt("V08A", 1);		
			if(V09A == 2) PlayerPrefs.SetInt("V09A", 1);		
			if(V10A == 2) PlayerPrefs.SetInt("V10A", 1);
		}
		if (V.V6.activeInHierarchy == true) {
			Choose();		
			PlayerPrefs.SetInt("V06A", 2);	
			if(V01A == 2) PlayerPrefs.SetInt("V01A", 1);		
			if(V03A == 2) PlayerPrefs.SetInt("V03A", 1);		
			if(V04A == 2) PlayerPrefs.SetInt("V04A", 1);		
			if(V05A == 2) PlayerPrefs.SetInt("V05A", 1);		
			if(V02A == 2) PlayerPrefs.SetInt("V02A", 1);		
			if(V07A == 2) PlayerPrefs.SetInt("V07A", 1);		
			if(V08A == 2) PlayerPrefs.SetInt("V08A", 1);		
			if(V09A == 2) PlayerPrefs.SetInt("V09A", 1);		
			if(V10A == 2) PlayerPrefs.SetInt("V10A", 1);
		}
		if (V.V7.activeInHierarchy == true) {
			Choose();		
			PlayerPrefs.SetInt("V07A", 2);	
			if(V02A == 2) PlayerPrefs.SetInt("V02A", 1);		
			if(V03A == 2) PlayerPrefs.SetInt("V03A", 1);		
			if(V04A == 2) PlayerPrefs.SetInt("V04A", 1);		
			if(V05A == 2) PlayerPrefs.SetInt("V05A", 1);		
			if(V06A == 2) PlayerPrefs.SetInt("V06A", 1);		
			if(V01A == 2) PlayerPrefs.SetInt("V01A", 1);		
			if(V08A == 2) PlayerPrefs.SetInt("V08A", 1);		
			if(V09A == 2) PlayerPrefs.SetInt("V09A", 1);		
			if(V10A == 2) PlayerPrefs.SetInt("V10A", 1);
		}
		if (V.V8.activeInHierarchy == true) {
			Choose();		
			PlayerPrefs.SetInt("V08A", 2);	
			if(V01A == 2) PlayerPrefs.SetInt("V01A", 1);		
			if(V03A == 2) PlayerPrefs.SetInt("V03A", 1);		
			if(V04A == 2) PlayerPrefs.SetInt("V04A", 1);		
			if(V05A == 2) PlayerPrefs.SetInt("V05A", 1);		
			if(V06A == 2) PlayerPrefs.SetInt("V06A", 1);		
			if(V07A == 2) PlayerPrefs.SetInt("V07A", 1);		
			if(V02A == 2) PlayerPrefs.SetInt("V02A", 1);		
			if(V09A == 2) PlayerPrefs.SetInt("V09A", 1);		
			if(V10A == 2) PlayerPrefs.SetInt("V10A", 1);
		}
		if (V.V9.activeInHierarchy == true) {
			Choose();		
			PlayerPrefs.SetInt("V09A", 2);	
			if(V02A == 2) PlayerPrefs.SetInt("V02A", 1);		
			if(V03A == 2) PlayerPrefs.SetInt("V03A", 1);		
			if(V04A == 2) PlayerPrefs.SetInt("V04A", 1);		
			if(V05A == 2) PlayerPrefs.SetInt("V05A", 1);		
			if(V06A == 2) PlayerPrefs.SetInt("V06A", 1);		
			if(V07A == 2) PlayerPrefs.SetInt("V07A", 1);		
			if(V08A == 2) PlayerPrefs.SetInt("V08A", 1);		
			if(V01A == 2) PlayerPrefs.SetInt("V01A", 1);		
			if(V10A == 2) PlayerPrefs.SetInt("V10A", 1);
		}
		if (V.V10.activeInHierarchy == true) {
			Choose();		
			PlayerPrefs.SetInt("V10A", 2);	
			if(V01A == 2) PlayerPrefs.SetInt("V01A", 1);		
			if(V03A == 2) PlayerPrefs.SetInt("V03A", 1);		
			if(V04A == 2) PlayerPrefs.SetInt("V04A", 1);		
			if(V05A == 2) PlayerPrefs.SetInt("V05A", 1);		
			if(V06A == 2) PlayerPrefs.SetInt("V06A", 1);		
			if(V07A == 2) PlayerPrefs.SetInt("V07A", 1);		
			if(V08A == 2) PlayerPrefs.SetInt("V08A", 1);		
			if(V09A == 2) PlayerPrefs.SetInt("V09A", 1);		
			if(V02A == 2) PlayerPrefs.SetInt("V02A", 1);
		}
	}

	void NotBuy()
	{
		buy.enabled = true;
		choose.enabled = false;
		bumper.enabled = false;
		spoiler.enabled = false;
		exhaust.enabled = false;
	}
	void Buy()
	{
		buy.enabled = false;
		choose.enabled = true;
		bumper.enabled = false;
		spoiler.enabled = false;
		exhaust.enabled = false;
	}
	void Choose()
	{
		choose.enabled = false;
		buy.enabled = false;
		bumper.enabled = true;
		spoiler.enabled = true;
		exhaust.enabled = true;
	}
}
