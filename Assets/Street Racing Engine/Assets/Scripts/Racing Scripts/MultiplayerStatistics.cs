using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiplayerStatistics : MonoBehaviour {


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

	int n1 = 0, n2=0;




	// Use this for initialization
	void Start () {

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


	void Update()
	{
		if (P1Finish.finish) {
				RefreshP1 ();
		}
		if (P2Finish.finish) {
				RefreshP2 ();
		}
	}
	
	// Update is called once per frame
	void RefreshP1() {
		if (P1Timer.minutes <= P1Minutes && P1Timer.seconds < P1Seconds) {
			if (P1Timer.seconds > 10) {
				P1.text = "1. PLAYER.1 - 0" + P1Timer.minutes.ToString () + "." + P1Timer.seconds.ToString ("F2");
			} else
				P1.text = "1. PLAYER.1 - 0" + P1Timer.minutes.ToString () + ".0" + P1Timer.seconds.ToString ("F2");

			if (P1Seconds > 10) {
				P2.text = "2. COMPUTER - 0" + P1Minutes.ToString () + "." + P1Seconds.ToString ();
			} else
				P2.text = "2. COMPUTER - 0" + P1Minutes.ToString () + ".0" + P1Seconds.ToString ();

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

			P1Minutes = P1Timer.minutes;
			P1Seconds = P1Timer.seconds;
			n1 = 1;

			if (n2 == 1) {
				if (P1Seconds > 10) {
					P2.text = "2. PLAYER.2 - 0" + P1Minutes.ToString () + "." + P1Seconds.ToString ("F2");
				} else
					P2.text = "2. PLAYER.2 - 0" + P1Minutes.ToString () + ".0" + P1Seconds.ToString ("F2");
			}

			if (n2 == 2) {
				if (P2Seconds > 10) {
					P3.text = "3. PLAYER.2 - 0" + P2Minutes.ToString () + "." + P2Seconds.ToString ("F2");
				} else
					P3.text = "3. PLAYER.2 - 0" + P2Minutes.ToString () + ".0" + P2Seconds.ToString ("F2");
			}

			if (n2 == 3) {
				if (P3Seconds > 10) {
					P4.text = "4. PLAYER.2 - 0" + P3Minutes.ToString () + "." + P3Seconds.ToString ("F2");
				} else
					P4.text = "4. PLAYER.2 - 0" + P3Minutes.ToString () + ".0" + P3Seconds.ToString ("F2");
			}
			
			if (n2 == 4) {
				if (P4Seconds > 10) {
					P5.text = "5. PLAYER.2 - 0" + P4Minutes.ToString () + "." + P4Seconds.ToString ("F2");
				} else
					P5.text = "5. PLAYER.2 - 0" + P4Minutes.ToString () + ".0" + P4Seconds.ToString ("F2");
			}

			
		} else if (P1Timer.minutes >= P1Minutes && P1Timer.seconds > P1Seconds && P1Timer.minutes <= P2Minutes && P1Timer.seconds < P2Seconds) {

			if (P1Timer.seconds > 10) {
				P2.text = "2. PLAYER.1 - 0" + P1Timer.minutes.ToString () + "." + P1Timer.seconds.ToString ("F2");
			} else
				P2.text = "2. PLAYER.1 - 0" + P1Timer.minutes.ToString () + ".0" + P1Timer.seconds.ToString ("F2");

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

			P2Minutes = P1Timer.minutes;
			P2Seconds = P1Timer.seconds;
			n1 = 2;

			if (n2 == 1) {
				if (P1Seconds > 10) {
					P1.text = "1. PLAYER.2 - 0" + P1Minutes.ToString () + "." + P1Seconds.ToString ("F2");
				} else
					P1.text = "1. PLAYER.2 - 0" + P1Minutes.ToString () + ".0" + P1Seconds.ToString ("F2");
			}

			if (n2 == 2) {
				if (P2Seconds > 10) {
					P3.text = "3. PLAYER.2 - 0" + P2Minutes.ToString () + "." + P2Seconds.ToString ("F2");
				} else
					P3.text = "3. PLAYER.2 - 0" + P2Minutes.ToString () + ".0" + P2Seconds.ToString ("F2");
			}

			if (n2 == 3) {
				if (P3Seconds > 10) {
					P4.text = "4. PLAYER.2 - 0" + P3Minutes.ToString () + "." + P3Seconds.ToString ("F2");
				} else
					P4.text = "4. PLAYER.2 - 0" + P3Minutes.ToString () + ".0" + P3Seconds.ToString ("F2");
			}

			if (n2 == 4) {
				if (P4Seconds > 10) {
					P5.text = "5. PLAYER.2 - 0" + P4Minutes.ToString () + "." + P4Seconds.ToString ("F2");
				} else
					P5.text = "5. PLAYER.2 - 0" + P4Minutes.ToString () + ".0" + P4Seconds.ToString ("F2");
			}

		} else if (P1Timer.minutes >= P2Minutes && P1Timer.seconds > P2Seconds && P1Timer.minutes <= P3Minutes && P1Timer.seconds < P3Seconds) {

			if (P1Timer.seconds > 10) {
				P3.text = "3. PLAYER.1 - 0" + P1Timer.minutes.ToString () + "." + P1Timer.seconds.ToString ("F2");
			} else
				P3.text = "3. PLAYER.1 - 0" + P1Timer.minutes.ToString () + ".0" + P1Timer.seconds.ToString ("F2");

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
		
			P3Minutes = P1Timer.minutes;
			P3Seconds = P1Timer.seconds;
			n1 = 3;

			if (n2 == 1) {
				if (P1Seconds > 10) {
					P1.text = "1. PLAYER.2 - 0" + P1Minutes.ToString () + "." + P1Seconds.ToString ("F2");
				} else
					P1.text = "1. PLAYER.2 - 0" + P1Minutes.ToString () + ".0" + P1Seconds.ToString ("F2");
			}

			if (n2 == 2) {
				if (P2Seconds > 10) {
					P2.text = "2. PLAYER.2 - 0" + P2Minutes.ToString () + "." + P2Seconds.ToString ("F2");
				} else
					P2.text = "2. PLAYER.2 - 0" + P2Minutes.ToString () + ".0" + P2Seconds.ToString ("F2");
			}

			if (n2 == 3) {
				if (P3Seconds > 10) {
					P4.text = "4. PLAYER.2 - 0" + P3Minutes.ToString () + "." + P3Seconds.ToString ("F2");
				} else
					P4.text = "4. PLAYER.2 - 0" + P3Minutes.ToString () + ".0" + P3Seconds.ToString ("F2");
			}

			if (n2 == 4) {
				if (P4Seconds > 10) {
					P5.text = "5. PLAYER.2 - 0" + P4Minutes.ToString () + "." + P4Seconds.ToString ("F2");
				} else
					P5.text = "5. PLAYER.2 - 0" + P4Minutes.ToString () + ".0" + P4Seconds.ToString ("F2");
			}
		
		} else if (P1Timer.minutes >= P3Minutes && P1Timer.seconds > P3Seconds && P1Timer.minutes <= P4Minutes && P1Timer.seconds < P4Seconds) {

			if (P1Timer.seconds > 10) {
				P4.text = "4. PLAYER.1 - 0" + P1Timer.minutes.ToString () + "." + P1Timer.seconds.ToString ("F2");
			} else
				P4.text = "4. PLAYER.1 - 0" + P1Timer.minutes.ToString () + ".0" + P1Timer.seconds.ToString ("F2");

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
		
			P4Minutes = P1Timer.minutes;
			P4Seconds = P1Timer.seconds;
			n1 = 4;

			if (n2 == 1) {
				if (P1Seconds > 10) {
					P1.text = "1. PLAYER.2 - 0" + P1Minutes.ToString () + "." + P1Seconds.ToString ("F2");
				} else
					P1.text = "1. PLAYER.2 - 0" + P1Minutes.ToString () + ".0" + P1Seconds.ToString ("F2");
			}

			if (n2 == 2) {
				if (P2Seconds > 10) {
					P2.text = "2. PLAYER.2 - 0" + P2Minutes.ToString () + "." + P2Seconds.ToString ("F2");
				} else
					P2.text = "2. PLAYER.2 - 0" + P2Minutes.ToString () + ".0" + P2Seconds.ToString ("F2");
			}

			if (n2 == 3) {
				if (P3Seconds > 10) {
					P3.text = "3. PLAYER.2 - 0" + P3Minutes.ToString () + "." + P3Seconds.ToString ("F2");
				} else
					P3.text = "3. PLAYER.2 - 0" + P3Minutes.ToString () + ".0" + P3Seconds.ToString ("F2");
			}

			if (n2 == 4) {
				if (P4Seconds > 10) {
					P5.text = "5. PLAYER.2 - 0" + P4Minutes.ToString () + "." + P4Seconds.ToString ("F2");
				} else
					P5.text = "5. PLAYER.2 - 0" + P4Minutes.ToString () + ".0" + P4Seconds.ToString ("F2");
			}
		
		} else if(P1Timer.minutes >= P4Minutes && P1Timer.seconds > P4Seconds){

			if (P1Timer.seconds > 10) {
				P5.text = "5. PLAYER.1 - 0" + P1Timer.minutes.ToString () + "." + P1Timer.seconds.ToString ("F2");
			} else
				P5.text = "5. PLAYER.1 - 0" + P1Timer.minutes.ToString () + ".0" + P1Timer.seconds.ToString ("F2");
			
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

			P5Minutes = P1Timer.minutes;
			P5Seconds = P1Timer.seconds;
			n1 = 5;

			if (n2 == 1) {
				if (P1Seconds > 10) {
					P1.text = "1. PLAYER.2 - 0" + P1Minutes.ToString () + "." + P1Seconds.ToString ("F2");
				} else
					P1.text = "1. PLAYER.2 - 0" + P1Minutes.ToString () + ".0" + P1Seconds.ToString ("F2");
			}

			if (n2 == 2) {
				if (P2Seconds > 10) {
					P2.text = "2. PLAYER.2 - 0" + P2Minutes.ToString () + "." + P2Seconds.ToString ("F2");
				} else
					P2.text = "2. PLAYER.2 - 0" + P2Minutes.ToString () + ".0" + P2Seconds.ToString ("F2");
			}

			if (n2 == 3) {
				if (P3Seconds > 10) {
					P3.text = "3. PLAYER.2 - 0" + P3Minutes.ToString () + "." + P3Seconds.ToString ("F2");
				} else
					P3.text = "3. PLAYER.2 - 0" + P3Minutes.ToString () + ".0" + P3Seconds.ToString ("F2");
			}

			if (n2 == 4) {
				if (P4Seconds > 10) {
					P4.text = "5. PLAYER.2 - 0" + P4Minutes.ToString () + "." + P4Seconds.ToString ("F2");
				} else
					P4.text = "5. PLAYER.2 - 0" + P4Minutes.ToString () + ".0" + P4Seconds.ToString ("F2");
			}
		}
}

	void RefreshP2() {
		if (P2Timer.minutes <= P1Minutes && P2Timer.seconds < P1Seconds) {
			if (P2Timer.seconds > 10) {
				P1.text = "1. PLAYER.2 - 0" + P2Timer.minutes.ToString () + "." + P2Timer.seconds.ToString ("F2");
			} else
				P1.text = "1. PLAYER.2 - 0" + P2Timer.minutes.ToString () + ".0" + P2Timer.seconds.ToString ("F2");

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

			P1Minutes = P2Timer.minutes;
			P1Seconds = P2Timer.seconds;
			n2 = 1;

			if (n1 == 1) {
				if (P1Seconds > 10) {
					P2.text = "2. PLAYER.1 - 0" + P1Minutes.ToString () + "." + P1Seconds.ToString ("F2");
				} else
					P2.text = "2. PLAYER.1 - 0" + P1Minutes.ToString () + ".0" + P1Seconds.ToString ("F2");
			}

			if (n1 == 2) {
				if (P2Seconds > 10) {
					P3.text = "3. PLAYER.1 - 0" + P2Minutes.ToString () + "." + P2Seconds.ToString ("F2");
				} else
					P3.text = "3. PLAYER.1 - 0" + P2Minutes.ToString () + ".0" + P2Seconds.ToString ("F2");
			}

			if (n1 == 3) {
				if (P3Seconds > 10) {
					P4.text = "4. PLAYER.1 - 0" + P3Minutes.ToString () + "." + P3Seconds.ToString ("F2");
				} else
					P4.text = "4. PLAYER.1 - 0" + P3Minutes.ToString () + ".0" + P3Seconds.ToString ("F2");
			}

			if (n1 == 4) {
				if (P4Seconds > 10) {
					P5.text = "5. PLAYER.1 - 0" + P4Minutes.ToString () + "." + P4Seconds.ToString ("F2");
				} else
					P5.text = "5. PLAYER.1 - 0" + P4Minutes.ToString () + ".0" + P4Seconds.ToString ("F2");
			}


		} else if (P2Timer.minutes >= P1Minutes && P2Timer.seconds > P1Seconds && P2Timer.minutes <= P2Minutes && P2Timer.seconds < P2Seconds) {

			if (P2Timer.seconds > 10) {
				P2.text = "2. PLAYER.2 - 0" + P2Timer.minutes.ToString () + "." + P2Timer.seconds.ToString ("F2");
			} else
				P2.text = "2. PLAYER.2 - 0" + P2Timer.minutes.ToString () + ".0" + P2Timer.seconds.ToString ("F2");

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

			P2Minutes = P2Timer.minutes;
			P2Seconds = P2Timer.seconds;
			n2= 2;

			if (n1 == 1) {
				if (P1Seconds > 10) {
					P1.text = "1. PLAYER.1 - 0" + P1Minutes.ToString () + "." + P1Seconds.ToString ("F2");
				} else
					P1.text = "1. PLAYER.1 - 0" + P1Minutes.ToString () + ".0" + P1Seconds.ToString ("F2");
			}

			if (n1 == 2) {
				if (P2Seconds > 10) {
					P3.text = "3. PLAYER.1 - 0" + P2Minutes.ToString () + "." + P2Seconds.ToString ("F2");
				} else
					P3.text = "3. PLAYER.1 - 0" + P2Minutes.ToString () + ".0" + P2Seconds.ToString ("F2");
			}

			if (n1 == 3) {
				if (P3Seconds > 10) {
					P4.text = "4. PLAYER.1 - 0" + P3Minutes.ToString () + "." + P3Seconds.ToString ("F2");
				} else
					P4.text = "4. PLAYER.1 - 0" + P3Minutes.ToString () + ".0" + P3Seconds.ToString ("F2");
			}

			if (n1 == 4) {
				if (P4Seconds > 10) {
					P5.text = "5. PLAYER.1 - 0" + P4Minutes.ToString () + "." + P4Seconds.ToString ("F2");
				} else
					P5.text = "5. PLAYER.1 - 0" + P4Minutes.ToString () + ".0" + P4Seconds.ToString ("F2");
			}

		} else if (P2Timer.minutes >= P2Minutes && P2Timer.seconds > P2Seconds && P2Timer.minutes <= P3Minutes && P2Timer.seconds < P3Seconds) {

			if (P2Timer.seconds > 10) {
				P3.text = "3. PLAYER.2 - 0" + P2Timer.minutes.ToString () + "." + P2Timer.seconds.ToString ("F2");
			} else
				P3.text = "3. PLAYER.2 - 0" + P2Timer.minutes.ToString () + ".0" + P2Timer.seconds.ToString ("F2");

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

			P3Minutes = P2Timer.minutes;
			P3Seconds = P2Timer.seconds;
			n2 = 3;

			if (n1 == 1) {
				if (P1Seconds > 10) {
					P1.text = "1. PLAYER.1 - 0" + P1Minutes.ToString () + "." + P1Seconds.ToString ("F2");
				} else
					P1.text = "1. PLAYER.1 - 0" + P1Minutes.ToString () + ".0" + P1Seconds.ToString ("F2");
			}

			if (n1 == 2) {
				if (P2Seconds > 10) {
					P2.text = "2. PLAYER.1 - 0" + P2Minutes.ToString () + "." + P2Seconds.ToString ("F2");
				} else
					P2.text = "2. PLAYER.1 - 0" + P2Minutes.ToString () + ".0" + P2Seconds.ToString ("F2");
			}

			if (n1 == 3) {
				if (P3Seconds > 10) {
					P4.text = "4. PLAYER.1 - 0" + P3Minutes.ToString () + "." + P3Seconds.ToString ("F2");
				} else
					P4.text = "4. PLAYER.1 - 0" + P3Minutes.ToString () + ".0" + P3Seconds.ToString ("F2");
			}

			if (n1 == 4) {
				if (P4Seconds > 10) {
					P5.text = "5. PLAYER.1 - 0" + P4Minutes.ToString () + "." + P4Seconds.ToString ("F2");
				} else
					P5.text = "5. PLAYER.1 - 0" + P4Minutes.ToString () + ".0" + P4Seconds.ToString ("F2");
			}


		} else if (P2Timer.minutes >= P3Minutes && P2Timer.seconds > P3Seconds && P2Timer.minutes <= P4Minutes && P2Timer.seconds < P4Seconds) {

			if (P2Timer.seconds > 10) {
				P4.text = "4. PLAYER.2 - 0" + P2Timer.minutes.ToString () + "." + P2Timer.seconds.ToString ("F2");
			} else
				P4.text = "4. PLAYER.2 - 0" + P2Timer.minutes.ToString () + ".0" + P2Timer.seconds.ToString ("F2");

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

			P4Minutes = P2Timer.minutes;
			P4Seconds = P2Timer.seconds;
			n2 = 4;

			if (n1 == 1) {
				if (P1Seconds > 10) {
					P1.text = "1. PLAYER.1 - 0" + P1Minutes.ToString () + "." + P1Seconds.ToString ("F2");
				} else
					P1.text = "1. PLAYER.1 - 0" + P1Minutes.ToString () + ".0" + P1Seconds.ToString ("F2");
			}

			if (n1 == 2) {
				if (P2Seconds > 10) {
					P2.text = "2. PLAYER.1 - 0" + P2Minutes.ToString () + "." + P2Seconds.ToString ("F2");
				} else
					P2.text = "2. PLAYER.1 - 0" + P2Minutes.ToString () + ".0" + P2Seconds.ToString ("F2");
			}

			if (n1 == 3) {
				if (P3Seconds > 10) {
					P3.text = "3. PLAYER.1 - 0" + P3Minutes.ToString () + "." + P3Seconds.ToString ("F2");
				} else
					P3.text = "3. PLAYER.1 - 0" + P3Minutes.ToString () + ".0" + P3Seconds.ToString ("F2");
			}

			if (n1 == 4) {
				if (P4Seconds > 10) {
					P5.text = "5. PLAYER.1 - 0" + P4Minutes.ToString () + "." + P4Seconds.ToString ("F2");
				} else
					P5.text = "5. PLAYER.1 - 0" + P4Minutes.ToString () + ".0" + P4Seconds.ToString ("F2");
			}


		} else if(P2Timer.minutes >= P4Minutes && P2Timer.seconds > P4Seconds){

			if (P2Timer.seconds > 10) {
				P5.text = "5. PLAYER.2 - 0" + P2Timer.minutes.ToString () + "." + P2Timer.seconds.ToString ("F2");
			} else
				P5.text = "5. PLAYER.2 - 0" + P2Timer.minutes.ToString () + ".0" + P2Timer.seconds.ToString ("F2");

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

			P5Minutes = P2Timer.minutes;
			P5Seconds = P2Timer.seconds;
			n2 = 5;

			if (n1 == 1) {
				if (P1Seconds > 10) {
					P1.text = "1. PLAYER.1 - 0" + P1Minutes.ToString () + "." + P1Seconds.ToString ("F2");
				} else
					P1.text = "1. PLAYER.1 - 0" + P1Minutes.ToString () + ".0" + P1Seconds.ToString ("F2");
			}

			if (n1 == 2) {
				if (P2Seconds > 10) {
					P2.text = "2. PLAYER.1 - 0" + P2Minutes.ToString () + "." + P2Seconds.ToString ("F2");
				} else
					P2.text = "2. PLAYER.1 - 0" + P2Minutes.ToString () + ".0" + P2Seconds.ToString ("F2");
			}

			if (n1 == 3) {
				if (P3Seconds > 10) {
					P3.text = "3. PLAYER.1 - 0" + P3Minutes.ToString () + "." + P3Seconds.ToString ("F2");
				} else
					P3.text = "3. PLAYER.1 - 0" + P3Minutes.ToString () + ".0" + P3Seconds.ToString ("F2");
			}

			if (n1 == 4) {
				if (P4Seconds > 10) {
					P4.text = "4. PLAYER.1 - 0" + P4Minutes.ToString () + "." + P4Seconds.ToString ("F2");
				} else
					P4.text = "4. PLAYER.1 - 0" + P4Minutes.ToString () + ".0" + P4Seconds.ToString ("F2");
			}

		}
	}
}
