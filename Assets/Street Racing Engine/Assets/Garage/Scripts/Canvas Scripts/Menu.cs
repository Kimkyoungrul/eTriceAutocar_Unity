using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

	public bool MobileSettings;

	public GameObject B1,B2,B3,B4,B5;

	[Space(10)]

	public GameObject bodyShop, racing, multiplayer;

	int n=1;

	// Use this for initialization
	void Start () {

	}

	void LateUpdate()
	{
		if (LeftRightCarScript.car) {
			bodyShop.SetActive (false);
			LeftRightCarScript.car = false;
		}
	}

	public void Right()
	{
		if (MobileSettings) {
			if (n == 1) {
				B1.SetActive (false);
				B2.SetActive (true);
				n++;
			} else if (n == 2) {
				B2.SetActive (false);
				B4.SetActive (true);
				n+=2;
			} else if (n == 4) {
				B4.SetActive (false);
				B5.SetActive (true);
				n++;
			}
		} else {
			if (n == 1) {
				B1.SetActive (false);
				B2.SetActive (true);
				n++;
			} else if (n == 2) {
				B2.SetActive (false);
				B3.SetActive (true);
				n++;
			} else if (n == 3) {
				B3.SetActive (false);
				B4.SetActive (true);
				n++;
			} else if (n == 4) {
				B4.SetActive (false);
				B5.SetActive (true);
				n++;
			}
		}
	}

	public void Left()
	{
		if (MobileSettings) {
				if (n == 5) {
					B5.SetActive (false);
					B4.SetActive (true);
					n--;
				} else if (n == 4) {
					B4.SetActive (false);
					B2.SetActive (true);
					n-=2;
				} else if (n == 2) {
					B2.SetActive (false);
					B1.SetActive (true);
					n--;
				}
			}	else {
				if (n == 5) {
				B5.SetActive (false);
				B4.SetActive (true);
				n--;
			} else if (n == 4) {
				B4.SetActive (false);
				B3.SetActive (true);
				n--;
			} else if (n == 3) {
				B3.SetActive (false);
				B2.SetActive (true);
				n--;
			} else if (n == 2) {
				B2.SetActive (false);
				B1.SetActive (true);
				n--;
				}
			}
		}
	

	public void Freeroam()
	{
		FadeInOut.fade = true;
		FadeInOut.scene = 1;
	}

	public void Racing()
	{
		racing.SetActive (true);
		gameObject.transform.parent.gameObject.SetActive (false);
	}

	public void Multiplayer()
	{
		multiplayer.SetActive (true);
		gameObject.transform.parent.gameObject.SetActive (false);
	}

	public void Bodyshop()
	{
		bodyShop.SetActive (true);
		gameObject.transform.parent.gameObject.SetActive (false);
	}

	public void Exit()
	{
		Application.Quit ();
	}

	public void Back()
	{
		bodyShop.SetActive (false);
		gameObject.transform.parent.gameObject.SetActive (true);
	}

	public void BackRacing()
	{
		racing.SetActive (false);
		gameObject.transform.parent.gameObject.SetActive (true);
	}

	public void BackMultiplayer()
	{
		multiplayer.SetActive (false);
		gameObject.transform.parent.gameObject.SetActive (true);
	}
}
