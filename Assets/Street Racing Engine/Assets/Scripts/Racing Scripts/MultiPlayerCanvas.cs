using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiPlayerCanvas : MonoBehaviour {

	public GameObject Racing;
	public static bool multiplayer=false;
	public GameObject[] car;
	public static int n=0, player1, player2;
	bool s = false;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 10; i++) {
			car [i].SetActive (false);
		}
		car [n].SetActive(true);
	}

	public void Right()
	{
		if (n < car.Length-1) {
			car [n].SetActive (false);
			car [n + 1].SetActive (true);
			n++;
		}
	}

	public void Left()
	{
		if (n > 0) {
			car [n].SetActive (false);
			car [n - 1].SetActive (true);
			n--;
		}
	}

	public void Choose()
	{
		if (!s) {
			player1 = n;
			car [n].SetActive (false);
			n = 0;
			car [n].SetActive (true);
			s = true;
		}	else {
			player2 = n;
			Racing.SetActive (true);
			gameObject.SetActive (false);
			multiplayer = true;
			s = false;
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
