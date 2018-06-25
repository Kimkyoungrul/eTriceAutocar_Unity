using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class P1Timer : MonoBehaviour {
	
	public static int minutes;
	public static float seconds;
	Text timerTxt;
	public static bool count;

	void Start()
	{
		timerTxt = gameObject.GetComponent<Text> ();
	}
	void FixedUpdate()
	{
		if (count) {
			seconds += Time.deltaTime;
			if (seconds >= 60) {
				seconds = 0;
				minutes++;
			}
		}

		if (seconds < 10) {
			timerTxt.text = "0" + minutes.ToString () + ".0" + seconds.ToString ("F2");
		}	else timerTxt.text = "0" + minutes.ToString () + "." + seconds.ToString ("F2");
	}

}