using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void Resume()
	{
		gameObject.transform.parent.gameObject.SetActive (false);
		vehicleController.move = true;
		P1vehicleController.move = true;
		P2vehicleController.move = true;
	}

	public void Menu()
	{
		FadeInOut.fade = true;
		FadeInOut.scene = 0;
	}

	public void Exit()
	{
		Application.Quit ();
	}

}
