using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DayNightTime : MonoBehaviour {

	private Text time;
	public static float currentHour;
	public static float currentMinute;

	void Start() {
		time = gameObject.GetComponent<Text> ();
		if (GameManager.mobileOn || GameManager.canvasOp)
			gameObject.SetActive (false);
	}

	void Update() {
		currentHour = 24 * Sun.currentTimeOfDay;
		currentMinute = 60 * (currentHour - Mathf.Floor(currentHour));

		int shour = (int)Mathf.Floor(currentHour);
		int smin = (int)Mathf.Floor(currentMinute);
			if (currentHour < 10 && currentMinute < 10) {
				time.text = "0" + shour.ToString () + ":0" + smin.ToString ();
			} else if (currentHour < 10 && currentMinute >= 10) {
				time.text = "0" + shour.ToString () + ":" + smin.ToString ();
			} else if (currentHour >= 10 && currentMinute < 10) {
				time.text = shour.ToString () + ":0" + smin.ToString ();
			} else if (currentHour >= 10 && currentMinute >= 10) {
				time.text = shour.ToString () + ":" + smin.ToString ();
		}
	}
}
