using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statistics : MonoBehaviour {


	public int P1Minutes;
	public float P1Seconds;

	[Space(10)]

	public int P2Minutes;
	public float P2Seconds;

	[Space(10)]

	public int P3Minutes;
	public float P3Seconds;

	[Space(10)]

	public int P4Minutes;
	public float P4Seconds;

	[Space(10)]

	public int P5Minutes;
	public float P5Seconds;

	Text P1, P2, P3, P4, P5;

	public static bool finish;




	// Use this for initialization
	void Start () {

		Timer.seconds = 0;

		P1 = GameObject.Find ("FirstTime").GetComponent<Text> ();
		P2 = GameObject.Find ("SecondTime").GetComponent<Text> ();
		P3 = GameObject.Find ("ThirdTime").GetComponent<Text> ();
		P4 = GameObject.Find ("FourthTime").GetComponent<Text> ();
		P5 = GameObject.Find ("FifthTime").GetComponent<Text> ();

		if (P1Seconds > 10){
			P1.text = "1. COMPUTER - 0" + P1Minutes.ToString () + "." + P1Seconds.ToString ();
		}	else	P1.text = "1. COMPUTER - 0" + P1Minutes.ToString () + ".0" + P1Seconds.ToString ();

		if (P2Seconds > 10){
			P2.text = "2. COMPUTER - 0" + P2Minutes.ToString () + "." + P2Seconds.ToString ();
		}	else	P2.text = "2. COMPUTER - 0" + P2Minutes.ToString () + ".0" + P2Seconds.ToString ();

		if (P3Seconds > 10){
			P3.text = "3. COMPUTER - 0" + P3Minutes.ToString () + "." + P3Seconds.ToString ();
		}	else	P3.text = "3. COMPUTER - 0" + P3Minutes.ToString () + ".0" + P3Seconds.ToString ();

		if (P4Seconds > 10){
			P4.text = "4. COMPUTER - 0" + P4Minutes.ToString () + "." + P4Seconds.ToString ();
		}	else	P4.text = "4. COMPUTER - 0" + P4Minutes.ToString () + ".0" + P4Seconds.ToString ();

		if (P5Seconds > 10){
			P5.text = "5. COMPUTER - 0" + P5Minutes.ToString () + "." + P5Seconds.ToString ();
		}	else	P5.text = "5. COMPUTER - 0" + P5Minutes.ToString () + ".0" + P5Seconds.ToString ();


	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (finish) {
			NewStatistics ();
			finish = false;
		}
	}

	void NewStatistics()
	{
			if (Timer.minutes <= P1Minutes && Timer.seconds < P1Seconds) {
				if (Timer.seconds > 10) {
					P1.text = "1. PLAYER - 0" + Timer.minutes.ToString () + "." + Timer.seconds.ToString ("F2");
				} else
					P1.text = "1. PLAYER - 0" + Timer.minutes.ToString () + ".0" + Timer.seconds.ToString ("F2");
				if (P1Seconds > 10) {
					P2.text = "1. COMPUTER - 0" + P1Minutes.ToString () + "." + P1Seconds.ToString ();
				} else
					P2.text = "1. COMPUTER - 0" + P1Minutes.ToString () + ".0" + P1Seconds.ToString ();

				if (P2Seconds > 10) {
					P3.text = "3. COMPUTER - 0" + P2Minutes.ToString () + "." + P2Seconds.ToString ();
				} else
					P3.text = "3. COMPUTER - 0" + P2Minutes.ToString () + ".0" + P2Seconds.ToString ();

				if (P3Seconds > 10) {
					P4.text = "4. COMPUTER - 0" + P3Minutes.ToString () + "." + P3Seconds.ToString ();
				} else
					P4.text = "4. COMPUTER - 0" + P3Minutes.ToString () + ".0" + P3Seconds.ToString ();

				if (P4Seconds > 10) {
					P5.text = "5. COMPUTER - 0" + P4Minutes.ToString () + "." + P4Seconds.ToString ();
				} else
					P5.text = "5. COMPUTER - 0" + P4Minutes.ToString () + ".0" + P4Seconds.ToString ();

			} else if (Timer.minutes <= P2Minutes && Timer.seconds < P2Seconds) {

				if (Timer.seconds > 10) {
					P2.text = "2. PLAYER - 0" + Timer.minutes.ToString () + "." + Timer.seconds.ToString ("F2");
				} else
					P2.text = "2. PLAYER - 0" + Timer.minutes.ToString () + ".0" + Timer.seconds.ToString ("F2");

				if (P1Seconds > 10) {
					P1.text = "1. COMPUTER - 0" + P1Minutes.ToString () + "." + P1Seconds.ToString ();
				} else
					P1.text = "1. COMPUTER - 0" + P1Minutes.ToString () + ".0" + P1Seconds.ToString ();

				if (P2Seconds > 10) {
					P3.text = "3. COMPUTER - 0" + P2Minutes.ToString () + "." + P2Seconds.ToString ();
				} else
					P3.text = "3. COMPUTER - 0" + P2Minutes.ToString () + ".0" + P2Seconds.ToString ();

				if (P3Seconds > 10) {
					P4.text = "4. COMPUTER - 0" + P3Minutes.ToString () + "." + P3Seconds.ToString ();
				} else
					P4.text = "4. COMPUTER - 0" + P3Minutes.ToString () + ".0" + P3Seconds.ToString ();

				if (P4Seconds > 10) {
					P5.text = "5. COMPUTER - 0" + P4Minutes.ToString () + "." + P4Seconds.ToString ();
				} else
					P5.text = "5. COMPUTER - 0" + P4Minutes.ToString () + ".0" + P4Seconds.ToString ();

			} else if (Timer.minutes <= P3Minutes && Timer.seconds < P3Seconds) {

				if (Timer.seconds > 10) {
					P3.text = "3. PLAYER - 0" + Timer.minutes.ToString () + "." + Timer.seconds.ToString ("F2");
				} else
					P3.text = "3. PLAYER - 0" + Timer.minutes.ToString () + ".0" + Timer.seconds.ToString ("F2");

				if (P1Seconds > 10) {
					P1.text = "1. COMPUTER - 0" + P1Minutes.ToString () + "." + P1Seconds.ToString ();
				} else
					P1.text = "1. COMPUTER - 0" + P1Minutes.ToString () + ".0" + P1Seconds.ToString ();

				if (P2Seconds > 10) {
					P2.text = "2. COMPUTER - 0" + P2Minutes.ToString () + "." + P2Seconds.ToString ();
				} else
					P2.text = "2. COMPUTER - 0" + P2Minutes.ToString () + ".0" + P2Seconds.ToString ();

				if (P3Seconds > 10) {
					P4.text = "4. COMPUTER - 0" + P3Minutes.ToString () + "." + P3Seconds.ToString ();
				} else
					P4.text = "4. COMPUTER - 0" + P3Minutes.ToString () + ".0" + P3Seconds.ToString ();

				if (P4Seconds > 10) {
					P5.text = "5. COMPUTER - 0" + P4Minutes.ToString () + "." + P4Seconds.ToString ();
				} else
					P5.text = "5. COMPUTER - 0" + P4Minutes.ToString () + ".0" + P4Seconds.ToString ();
			} else if (Timer.minutes <= P4Minutes && Timer.seconds < P4Seconds) {

				if (Timer.seconds > 10) {
					P4.text = "4. PLAYER - 0" + Timer.minutes.ToString () + "." + Timer.seconds.ToString ("F2");
				} else
					P4.text = "4. PLAYER - 0" + Timer.minutes.ToString () + ".0" + Timer.seconds.ToString ("F2");

				if (P1Seconds > 10) {
					P1.text = "1. COMPUTER - 0" + P1Minutes.ToString () + "." + P1Seconds.ToString ();
				} else
					P1.text = "1. COMPUTER - 0" + P1Minutes.ToString () + ".0" + P1Seconds.ToString ();

				if (P2Seconds > 10) {
					P2.text = "2. COMPUTER - 0" + P2Minutes.ToString () + "." + P2Seconds.ToString ();
				} else
					P2.text = "2. COMPUTER - 0" + P2Minutes.ToString () + ".0" + P2Seconds.ToString ();

				if (P3Seconds > 10) {
					P3.text = "3. COMPUTER - 0" + P3Minutes.ToString () + "." + P3Seconds.ToString ();
				} else
					P3.text = "3. COMPUTER - 0" + P3Minutes.ToString () + ".0" + P3Seconds.ToString ();

				if (P4Seconds > 10) {
					P5.text = "5. COMPUTER - 0" + P4Minutes.ToString () + "." + P4Seconds.ToString ();
				} else
					P5.text = "5. COMPUTER - 0" + P4Minutes.ToString () + ".0" + P4Seconds.ToString ();
			} else {

				if (Timer.seconds > 10) {
					P5.text = "5. PLAYER - 0" + Timer.minutes.ToString () + "." + Timer.seconds.ToString ("F2");
				} else
					P5.text = "5. PLAYER - 0" + Timer.minutes.ToString () + ".0" + Timer.seconds.ToString ("F2");

				if (P1Seconds > 10) {
					P1.text = "1. COMPUTER - 0" + P1Minutes.ToString () + "." + P1Seconds.ToString ();
				} else
					P1.text = "1. COMPUTER - 0" + P1Minutes.ToString () + ".0" + P1Seconds.ToString ();

				if (P2Seconds > 10) {
					P2.text = "2. COMPUTER - 0" + P2Minutes.ToString () + "." + P2Seconds.ToString ();
				} else
					P2.text = "2. COMPUTER - 0" + P2Minutes.ToString () + ".0" + P2Seconds.ToString ();

				if (P3Seconds > 10) {
					P3.text = "3. COMPUTER - 0" + P3Minutes.ToString () + "." + P3Seconds.ToString ();
				} else
					P3.text = "3. COMPUTER - 0" + P3Minutes.ToString () + ".0" + P3Seconds.ToString ();

				if (P4Seconds > 10) {
					P4.text = "4. COMPUTER - 0" + P4Minutes.ToString () + "." + P4Seconds.ToString ();
				} else
					P4.text = "4. COMPUTER - 0" + P4Minutes.ToString () + ".0" + P4Seconds.ToString ();

		}
	}
}
