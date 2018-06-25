using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeBodyScript : MonoBehaviour {

	public Button bumper, spoiler, exhaust, col;
	public Image bb, bs, be;
	public Vehicle V;

	public void Right()
	{
		
		if (V.V1.activeInHierarchy == true) {
			if (BodyBuyScript.bse == 1 && Vehicle01BodyScript.bs == 0) {
				Vehicle01BodyScript.bs = 1;	buyb ();
			} else if (BodyBuyScript.bse == 1 && Vehicle01BodyScript.bs == 1) {
				Vehicle01BodyScript.bs = 2;	buyb ();}
			if (BodyBuyScript.bse == 2 && Vehicle01BodyScript.ss == 0) {
				Vehicle01BodyScript.ss = 1;	buys ();
			} else if (BodyBuyScript.bse == 2 && Vehicle01BodyScript.ss == 1) {
				Vehicle01BodyScript.ss = 2;	buys ();}
			if (BodyBuyScript.bse == 3 && Vehicle01BodyScript.es == 0) {
				Vehicle01BodyScript.es = 1;buye ();
			} else if (BodyBuyScript.bse == 3 && Vehicle01BodyScript.es == 1) {
				Vehicle01BodyScript.es = 2;buye ();	}
			if (BodyBuyScript.bse == 4 && Vehicle01BodyScript.cs == 0) {
				Vehicle01BodyScript.cs = 1;
			}	else if (BodyBuyScript.bse == 4 && Vehicle01BodyScript.cs == 1) {
				Vehicle01BodyScript.cs = 2;
			}	else if (BodyBuyScript.bse == 4 && Vehicle01BodyScript.cs == 2) {
				Vehicle01BodyScript.cs = 3;
			}	else if (BodyBuyScript.bse == 4 && Vehicle01BodyScript.cs == 3) {
				Vehicle01BodyScript.cs = 4;
			}	else if (BodyBuyScript.bse == 4 && Vehicle01BodyScript.cs == 4) {
				Vehicle01BodyScript.cs = 5;
			}
		}
		//------------------------------------------------------------------
		if (V.V2.activeInHierarchy == true) {
			if (BodyBuyScript.bse == 1 && Vehicle02BodyScript.bs == 0) {
				Vehicle02BodyScript.bs = 1;	buyb ();
			} else if (BodyBuyScript.bse == 1 && Vehicle02BodyScript.bs == 1) {
				Vehicle02BodyScript.bs = 2;	buyb ();}
			if (BodyBuyScript.bse == 2 && Vehicle02BodyScript.ss == 0) {
				Vehicle02BodyScript.ss = 1;	buys ();
			} else if (BodyBuyScript.bse == 2 && Vehicle02BodyScript.ss == 1) {
				Vehicle02BodyScript.ss = 2;	buys ();}
			if (BodyBuyScript.bse == 3 && Vehicle02BodyScript.es == 0) {
				Vehicle02BodyScript.es = 1;	buye ();
			} else if (BodyBuyScript.bse == 3 && Vehicle02BodyScript.es == 1) {
				Vehicle02BodyScript.es = 2;	buye ();}
			if (BodyBuyScript.bse == 4 && Vehicle02BodyScript.cs == 0) {
				Vehicle02BodyScript.cs = 1;
			}	else if (BodyBuyScript.bse == 4 && Vehicle02BodyScript.cs == 1) {
				Vehicle02BodyScript.cs = 2;
			}	else if (BodyBuyScript.bse == 4 && Vehicle02BodyScript.cs == 2) {
				Vehicle02BodyScript.cs = 3;
			}	else if (BodyBuyScript.bse == 4 && Vehicle02BodyScript.cs == 3) {
				Vehicle02BodyScript.cs = 4;
			}	else if (BodyBuyScript.bse == 4 && Vehicle02BodyScript.cs == 4) {
				Vehicle02BodyScript.cs = 5;
			}
		}
		//------------------------------------------------------------------
		if (V.V3.activeInHierarchy == true) {
			if (BodyBuyScript.bse == 1 && Vehicle03BodyScript.bs == 0) {
				Vehicle03BodyScript.bs = 1;	buyb ();
			} else if (BodyBuyScript.bse == 1 && Vehicle03BodyScript.bs == 1) {
				Vehicle03BodyScript.bs = 2;	buyb ();}
			if (BodyBuyScript.bse == 2 && Vehicle03BodyScript.ss == 0) {
				Vehicle03BodyScript.ss = 1;	buys ();
			} else if (BodyBuyScript.bse == 2 && Vehicle03BodyScript.ss == 1) {
				Vehicle03BodyScript.ss = 2;	buys ();}
			if (BodyBuyScript.bse == 3 && Vehicle03BodyScript.es == 0) {
				Vehicle03BodyScript.es = 1;	buye ();
			} else if (BodyBuyScript.bse == 3 && Vehicle03BodyScript.es == 1) {
				Vehicle03BodyScript.es = 2;	buye ();}
			if (BodyBuyScript.bse == 4 && Vehicle03BodyScript.cs == 0) {
				Vehicle03BodyScript.cs = 1;
			}	else if (BodyBuyScript.bse == 4 && Vehicle03BodyScript.cs == 1) {
				Vehicle03BodyScript.cs = 2;
			}	else if (BodyBuyScript.bse == 4 && Vehicle03BodyScript.cs == 2) {
				Vehicle03BodyScript.cs = 3;
			}	else if (BodyBuyScript.bse == 4 && Vehicle03BodyScript.cs == 3) {
				Vehicle03BodyScript.cs = 4;
			}	else if (BodyBuyScript.bse == 4 && Vehicle03BodyScript.cs == 4) {
				Vehicle03BodyScript.cs = 5;
			}
		}
		//------------------------------------------------------------------
		if (V.V4.activeInHierarchy == true) {
			if (BodyBuyScript.bse == 1 && Vehicle04BodyScript.bs == 0) {
				Vehicle04BodyScript.bs = 1;	buyb ();
			} else if (BodyBuyScript.bse == 1 && Vehicle04BodyScript.bs == 1) {
				Vehicle04BodyScript.bs = 2;	buyb ();}
			if (BodyBuyScript.bse == 2 && Vehicle04BodyScript.ss == 0) {
				Vehicle04BodyScript.ss = 1;	buys ();
			} else if (BodyBuyScript.bse == 2 && Vehicle04BodyScript.ss == 1) {
				Vehicle04BodyScript.ss = 2;	buys ();}
			if (BodyBuyScript.bse == 3 && Vehicle04BodyScript.es == 0) {
				Vehicle04BodyScript.es = 1;	buye ();
			} else if (BodyBuyScript.bse == 3 && Vehicle04BodyScript.es == 1) {
				Vehicle04BodyScript.es = 2;	buye ();}
			if (BodyBuyScript.bse == 4 && Vehicle04BodyScript.cs == 0) {
				Vehicle04BodyScript.cs = 1;
			}	else if (BodyBuyScript.bse == 4 && Vehicle04BodyScript.cs == 1) {
				Vehicle04BodyScript.cs = 2;
			}	else if (BodyBuyScript.bse == 4 && Vehicle04BodyScript.cs == 2) {
				Vehicle04BodyScript.cs = 3;
			}	else if (BodyBuyScript.bse == 4 && Vehicle04BodyScript.cs == 3) {
				Vehicle04BodyScript.cs = 4;
			}	else if (BodyBuyScript.bse == 4 && Vehicle04BodyScript.cs == 4) {
				Vehicle04BodyScript.cs = 5;
			}
		}
		//------------------------------------------------------------------
		if (V.V5.activeInHierarchy == true) {
			if (BodyBuyScript.bse == 1 && Vehicle05BodyScript.bs == 0) {
				Vehicle05BodyScript.bs = 1;	buyb ();
			} else if (BodyBuyScript.bse == 1 && Vehicle05BodyScript.bs == 1) {
				Vehicle05BodyScript.bs = 2;	buyb ();}
			if (BodyBuyScript.bse == 2 && Vehicle05BodyScript.ss == 0) {
				Vehicle05BodyScript.ss = 1;	buys ();
			} else if (BodyBuyScript.bse == 2 && Vehicle05BodyScript.ss == 1) {
				Vehicle05BodyScript.ss = 2;	buys ();}
			if (BodyBuyScript.bse == 3 && Vehicle05BodyScript.es == 0) {
				Vehicle05BodyScript.es = 1;	buye ();
			} else if (BodyBuyScript.bse == 3 && Vehicle05BodyScript.es == 1) {
				Vehicle05BodyScript.es = 2;	buye ();}
			if (BodyBuyScript.bse == 4 && Vehicle05BodyScript.cs == 0) {
				Vehicle05BodyScript.cs = 1;
			}	else if (BodyBuyScript.bse == 4 && Vehicle05BodyScript.cs == 1) {
				Vehicle05BodyScript.cs = 2;
			}	else if (BodyBuyScript.bse == 4 && Vehicle05BodyScript.cs == 2) {
				Vehicle05BodyScript.cs = 3;
			}	else if (BodyBuyScript.bse == 4 && Vehicle05BodyScript.cs == 3) {
				Vehicle05BodyScript.cs = 4;
			}	else if (BodyBuyScript.bse == 4 && Vehicle05BodyScript.cs == 4) {
				Vehicle05BodyScript.cs = 5;
			}
		}
		//------------------------------------------------------------------
		if (V.V6.activeInHierarchy == true) {
			if (BodyBuyScript.bse == 1 && Vehicle06BodyScript.bs == 0) {
				Vehicle06BodyScript.bs = 1;	buyb ();
			} else if (BodyBuyScript.bse == 1 && Vehicle06BodyScript.bs == 1) {
				Vehicle06BodyScript.bs = 2;	buyb ();}
			if (BodyBuyScript.bse == 2 && Vehicle06BodyScript.ss == 0) {
				Vehicle06BodyScript.ss = 1;	buys ();
			} else if (BodyBuyScript.bse == 2 && Vehicle06BodyScript.ss == 1) {
				Vehicle06BodyScript.ss = 2;	buys ();}
			if (BodyBuyScript.bse == 3 && Vehicle06BodyScript.es == 0) {
				Vehicle06BodyScript.es = 1;	buye ();
			} else if (BodyBuyScript.bse == 3 && Vehicle06BodyScript.es == 1) {
				Vehicle06BodyScript.es = 2;	buye ();}
			if (BodyBuyScript.bse == 4 && Vehicle06BodyScript.cs == 0) {
				Vehicle06BodyScript.cs = 1;
			}	else if (BodyBuyScript.bse == 4 && Vehicle06BodyScript.cs == 1) {
				Vehicle06BodyScript.cs = 2;
			}	else if (BodyBuyScript.bse == 4 && Vehicle06BodyScript.cs == 2) {
				Vehicle06BodyScript.cs = 3;
			}	else if (BodyBuyScript.bse == 4 && Vehicle06BodyScript.cs == 3) {
				Vehicle06BodyScript.cs = 4;
			}	else if (BodyBuyScript.bse == 4 && Vehicle06BodyScript.cs == 4) {
				Vehicle06BodyScript.cs = 5;
			}
		}
		//------------------------------------------------------------------
		if (V.V7.activeInHierarchy == true) {
			if (BodyBuyScript.bse == 1 && Vehicle07BodyScript.bs == 0) {
				Vehicle07BodyScript.bs = 1;	buyb ();
			} else if (BodyBuyScript.bse == 1 && Vehicle07BodyScript.bs == 1) {
				Vehicle07BodyScript.bs = 2;	buyb ();}
			if (BodyBuyScript.bse == 2 && Vehicle07BodyScript.ss == 0) {
				Vehicle07BodyScript.ss = 1;	buys ();
			} else if (BodyBuyScript.bse == 2 && Vehicle07BodyScript.ss == 1) {
				Vehicle07BodyScript.ss = 2;	buys ();}
			if (BodyBuyScript.bse == 3 && Vehicle07BodyScript.es == 0) {
				Vehicle07BodyScript.es = 1;	buye ();
			} else if (BodyBuyScript.bse == 3 && Vehicle07BodyScript.es == 1) {
				Vehicle07BodyScript.es = 2;	buye ();}
			if (BodyBuyScript.bse == 4 && Vehicle07BodyScript.cs == 0) {
				Vehicle07BodyScript.cs = 1;
			}	else if (BodyBuyScript.bse == 4 && Vehicle07BodyScript.cs == 1) {
				Vehicle07BodyScript.cs = 2;
			}	else if (BodyBuyScript.bse == 4 && Vehicle07BodyScript.cs == 2) {
				Vehicle07BodyScript.cs = 3;
			}	else if (BodyBuyScript.bse == 4 && Vehicle07BodyScript.cs == 3) {
				Vehicle07BodyScript.cs = 4;
			}	else if (BodyBuyScript.bse == 4 && Vehicle07BodyScript.cs == 4) {
				Vehicle07BodyScript.cs = 5;
			}
		}
		//------------------------------------------------------------------
		if (V.V8.activeInHierarchy == true) {
			if (BodyBuyScript.bse == 1 && Vehicle08BodyScript.bs == 0) {
				Vehicle08BodyScript.bs = 1;	buyb ();
			} else if (BodyBuyScript.bse == 1 && Vehicle08BodyScript.bs == 1) {
				Vehicle08BodyScript.bs = 2;	buyb ();}
			if (BodyBuyScript.bse == 2 && Vehicle08BodyScript.ss == 0) {
				Vehicle08BodyScript.ss = 1;	buys ();
			} else if (BodyBuyScript.bse == 2 && Vehicle08BodyScript.ss == 1) {
				Vehicle08BodyScript.ss = 2;	buys ();}
			if (BodyBuyScript.bse == 3 && Vehicle08BodyScript.es == 0) {
				Vehicle08BodyScript.es = 1;	buye ();
			} else if (BodyBuyScript.bse == 3 && Vehicle08BodyScript.es == 1) {
				Vehicle08BodyScript.es = 2;	buye ();}
			if (BodyBuyScript.bse == 4 && Vehicle08BodyScript.cs == 0) {
				Vehicle08BodyScript.cs = 1;
			}	else if (BodyBuyScript.bse == 4 && Vehicle08BodyScript.cs == 1) {
				Vehicle08BodyScript.cs = 2;
			}	else if (BodyBuyScript.bse == 4 && Vehicle08BodyScript.cs == 2) {
				Vehicle08BodyScript.cs = 3;
			}	else if (BodyBuyScript.bse == 4 && Vehicle08BodyScript.cs == 3) {
				Vehicle08BodyScript.cs = 4;
			}	else if (BodyBuyScript.bse == 4 && Vehicle08BodyScript.cs == 4) {
				Vehicle08BodyScript.cs = 5;
			}
		}
		//------------------------------------------------------------------
		if (V.V9.activeInHierarchy == true) {
			if (BodyBuyScript.bse == 1 && Vehicle09BodyScript.bs == 0) {
				Vehicle09BodyScript.bs = 1;	buyb ();
			} else if (BodyBuyScript.bse == 1 && Vehicle09BodyScript.bs == 1) {
				Vehicle09BodyScript.bs = 2;	buyb ();}
			if (BodyBuyScript.bse == 2 && Vehicle09BodyScript.ss == 0) {
				Vehicle09BodyScript.ss = 1;	buys ();
			} else if (BodyBuyScript.bse == 2 && Vehicle09BodyScript.ss == 1) {
				Vehicle09BodyScript.ss = 2;	buys ();}
			if (BodyBuyScript.bse == 3 && Vehicle09BodyScript.es == 0) {
				Vehicle09BodyScript.es = 1;	buye ();
			} else if (BodyBuyScript.bse == 3 && Vehicle09BodyScript.es == 1) {
				Vehicle09BodyScript.es = 2;	buye ();}
			if (BodyBuyScript.bse == 4 && Vehicle09BodyScript.cs == 0) {
				Vehicle09BodyScript.cs = 1;
			}	else if (BodyBuyScript.bse == 4 && Vehicle09BodyScript.cs == 1) {
				Vehicle09BodyScript.cs = 2;
			}	else if (BodyBuyScript.bse == 4 && Vehicle09BodyScript.cs == 2) {
				Vehicle09BodyScript.cs = 3;
			}	else if (BodyBuyScript.bse == 4 && Vehicle09BodyScript.cs == 3) {
				Vehicle09BodyScript.cs = 4;
			}	else if (BodyBuyScript.bse == 4 && Vehicle09BodyScript.cs == 4) {
				Vehicle09BodyScript.cs = 5;
			}
		}
		if (V.V10.activeInHierarchy == true) {
			if (BodyBuyScript.bse == 1 && Vehicle10BodyScript.bs == 0) {
				Vehicle10BodyScript.bs = 1;	buyb ();
			} else if (BodyBuyScript.bse == 1 && Vehicle10BodyScript.bs == 1) {
				Vehicle10BodyScript.bs = 2;	buyb ();}
			if (BodyBuyScript.bse == 2 && Vehicle10BodyScript.ss == 0) {
				Vehicle10BodyScript.ss = 1;	buys ();
			} else if (BodyBuyScript.bse == 2 && Vehicle10BodyScript.ss == 1) {
				Vehicle10BodyScript.ss = 2;	buys ();}
			if (BodyBuyScript.bse == 3 && Vehicle10BodyScript.es == 0) {
				Vehicle10BodyScript.es = 1;	buye ();
			} else if (BodyBuyScript.bse == 3 && Vehicle10BodyScript.es == 1) {
				Vehicle10BodyScript.es = 2;	buye ();}
			if (BodyBuyScript.bse == 4 && Vehicle10BodyScript.cs == 0) {
				Vehicle10BodyScript.cs = 1;
			}	else if (BodyBuyScript.bse == 4 && Vehicle10BodyScript.cs == 1) {
				Vehicle10BodyScript.cs = 2;
			}	else if (BodyBuyScript.bse == 4 && Vehicle10BodyScript.cs == 2) {
				Vehicle10BodyScript.cs = 3;
			}	else if (BodyBuyScript.bse == 4 && Vehicle10BodyScript.cs == 3) {
				Vehicle10BodyScript.cs = 4;
			}	else if (BodyBuyScript.bse == 4 && Vehicle10BodyScript.cs == 4) {
				Vehicle10BodyScript.cs = 5;
			}
		}
	}
	public void Left()
	{

		if (V.V1.activeInHierarchy == true) {
			if (BodyBuyScript.bse == 1 && Vehicle01BodyScript.bs == 1) {
				Vehicle01BodyScript.bs = 0;	buyb ();
			} else if (BodyBuyScript.bse == 1 && Vehicle01BodyScript.bs == 2) {
				Vehicle01BodyScript.bs = 1;	buyb ();}
			if (BodyBuyScript.bse == 2 && Vehicle01BodyScript.ss == 1) {
				Vehicle01BodyScript.ss = 0;	buys ();
			} else if (BodyBuyScript.bse == 2 && Vehicle01BodyScript.ss == 2) {
				Vehicle01BodyScript.ss = 1;	buys ();}
			if (BodyBuyScript.bse == 3 && Vehicle01BodyScript.es == 1) {
				Vehicle01BodyScript.es = 0;buye ();
			} else if (BodyBuyScript.bse == 3 && Vehicle01BodyScript.es == 2) {
				Vehicle01BodyScript.es = 1;buye ();	}
			if (BodyBuyScript.bse == 4 && Vehicle01BodyScript.cs == 1) {
				Vehicle01BodyScript.cs = 0;
			}	else if (BodyBuyScript.bse == 4 && Vehicle01BodyScript.cs == 2) {
				Vehicle01BodyScript.cs = 1;
			}	else if (BodyBuyScript.bse == 4 && Vehicle01BodyScript.cs == 3) {
				Vehicle01BodyScript.cs = 2;
			}	else if (BodyBuyScript.bse == 4 && Vehicle01BodyScript.cs == 4) {
				Vehicle01BodyScript.cs = 3;
			}	else if (BodyBuyScript.bse == 4 && Vehicle01BodyScript.cs == 5) {
				Vehicle01BodyScript.cs = 4;
			}
		}
		//------------------------------------------------------------------
		if (V.V2.activeInHierarchy == true) {
			if (BodyBuyScript.bse == 1 && Vehicle02BodyScript.bs == 1) {
				Vehicle02BodyScript.bs = 0;	buyb ();
			} else if (BodyBuyScript.bse == 1 && Vehicle02BodyScript.bs == 2) {
				Vehicle02BodyScript.bs = 1;	buyb ();}
			if (BodyBuyScript.bse == 2 && Vehicle02BodyScript.ss == 1) {
				Vehicle02BodyScript.ss = 0;	buys ();
			} else if (BodyBuyScript.bse == 2 && Vehicle02BodyScript.ss == 2) {
				Vehicle02BodyScript.ss = 1;	buys ();}
			if (BodyBuyScript.bse == 3 && Vehicle02BodyScript.es == 1) {
				Vehicle02BodyScript.es = 0;	buye ();
			} else if (BodyBuyScript.bse == 3 && Vehicle02BodyScript.es == 2) {
				Vehicle02BodyScript.es = 1;	buye ();}
			if (BodyBuyScript.bse == 4 && Vehicle02BodyScript.cs == 1) {
				Vehicle02BodyScript.cs = 0;
			}	else if (BodyBuyScript.bse == 4 && Vehicle02BodyScript.cs == 2) {
				Vehicle02BodyScript.cs = 1;
			}	else if (BodyBuyScript.bse == 4 && Vehicle02BodyScript.cs == 3) {
				Vehicle02BodyScript.cs = 2;
			}	else if (BodyBuyScript.bse == 4 && Vehicle02BodyScript.cs == 4) {
				Vehicle02BodyScript.cs = 3;
			}	else if (BodyBuyScript.bse == 4 && Vehicle02BodyScript.cs == 5) {
				Vehicle02BodyScript.cs = 4;
			}
		}
		//------------------------------------------------------------------
		if (V.V3.activeInHierarchy == true) {
			if (BodyBuyScript.bse == 1 && Vehicle03BodyScript.bs == 1) {
				Vehicle03BodyScript.bs = 0;	buyb ();
			} else if (BodyBuyScript.bse == 1 && Vehicle03BodyScript.bs == 2) {
				Vehicle03BodyScript.bs = 1;	buyb ();}
			if (BodyBuyScript.bse == 2 && Vehicle03BodyScript.ss == 1) {
				Vehicle03BodyScript.ss = 0;	buys ();
			} else if (BodyBuyScript.bse == 2 && Vehicle03BodyScript.ss == 2) {
				Vehicle03BodyScript.ss = 1;	buys ();}
			if (BodyBuyScript.bse == 3 && Vehicle03BodyScript.es == 1) {
				Vehicle03BodyScript.es = 0;	buye ();
			} else if (BodyBuyScript.bse == 3 && Vehicle03BodyScript.es == 2) {
				Vehicle03BodyScript.es = 1;	buye ();}
			if (BodyBuyScript.bse == 4 && Vehicle03BodyScript.cs == 1) {
				Vehicle03BodyScript.cs = 0;
			}	else if (BodyBuyScript.bse == 4 && Vehicle03BodyScript.cs == 2) {
				Vehicle03BodyScript.cs = 1;
			}	else if (BodyBuyScript.bse == 4 && Vehicle03BodyScript.cs == 3) {
				Vehicle03BodyScript.cs = 2;
			}	else if (BodyBuyScript.bse == 4 && Vehicle03BodyScript.cs == 4) {
				Vehicle03BodyScript.cs = 3;
			}	else if (BodyBuyScript.bse == 4 && Vehicle03BodyScript.cs == 5) {
				Vehicle03BodyScript.cs = 4;
			}
		}
		//------------------------------------------------------------------
		if (V.V4.activeInHierarchy == true) {
			if (BodyBuyScript.bse == 1 && Vehicle04BodyScript.bs == 1) {
				Vehicle04BodyScript.bs = 0;	buyb ();
			} else if (BodyBuyScript.bse == 1 && Vehicle04BodyScript.bs == 2) {
				Vehicle04BodyScript.bs = 1;	buyb ();}
			if (BodyBuyScript.bse == 2 && Vehicle04BodyScript.ss == 1) {
				Vehicle04BodyScript.ss = 0;	buys ();
			} else if (BodyBuyScript.bse == 2 && Vehicle04BodyScript.ss == 2) {
				Vehicle04BodyScript.ss = 1;	buys ();}
			if (BodyBuyScript.bse == 3 && Vehicle04BodyScript.es == 1) {
				Vehicle04BodyScript.es = 0;	buye ();
			} else if (BodyBuyScript.bse == 3 && Vehicle04BodyScript.es == 2) {
				Vehicle04BodyScript.es = 1;	buye ();}
			if (BodyBuyScript.bse == 4 && Vehicle04BodyScript.cs == 1) {
				Vehicle04BodyScript.cs = 0;
			}	else if (BodyBuyScript.bse == 4 && Vehicle04BodyScript.cs == 2) {
				Vehicle04BodyScript.cs = 1;
			}	else if (BodyBuyScript.bse == 4 && Vehicle04BodyScript.cs == 3) {
				Vehicle04BodyScript.cs = 2;
			}	else if (BodyBuyScript.bse == 4 && Vehicle04BodyScript.cs == 4) {
				Vehicle04BodyScript.cs = 3;
			}	else if (BodyBuyScript.bse == 4 && Vehicle04BodyScript.cs == 5) {
				Vehicle04BodyScript.cs = 4;
			}
		}
		//------------------------------------------------------------------
		if (V.V5.activeInHierarchy == true) {
			if (BodyBuyScript.bse == 1 && Vehicle05BodyScript.bs == 1) {
				Vehicle05BodyScript.bs = 0;	buyb ();
			} else if (BodyBuyScript.bse == 1 && Vehicle05BodyScript.bs == 2) {
				Vehicle05BodyScript.bs = 1;	buyb ();}
			if (BodyBuyScript.bse == 2 && Vehicle05BodyScript.ss == 1) {
				Vehicle05BodyScript.ss = 0;	buys ();
			} else if (BodyBuyScript.bse == 2 && Vehicle05BodyScript.ss == 2) {
				Vehicle05BodyScript.ss = 1;	buys ();}
			if (BodyBuyScript.bse == 3 && Vehicle05BodyScript.es == 1) {
				Vehicle05BodyScript.es = 0;	buye ();
			} else if (BodyBuyScript.bse == 3 && Vehicle05BodyScript.es == 2) {
				Vehicle05BodyScript.es = 1;	buye ();}
			if (BodyBuyScript.bse == 4 && Vehicle05BodyScript.cs == 1) {
				Vehicle05BodyScript.cs = 0;
			}	else if (BodyBuyScript.bse == 4 && Vehicle05BodyScript.cs == 2) {
				Vehicle05BodyScript.cs = 1;
			}	else if (BodyBuyScript.bse == 4 && Vehicle05BodyScript.cs == 3) {
				Vehicle05BodyScript.cs = 2;
			}	else if (BodyBuyScript.bse == 4 && Vehicle05BodyScript.cs == 4) {
				Vehicle05BodyScript.cs = 3;
			}	else if (BodyBuyScript.bse == 4 && Vehicle05BodyScript.cs == 5) {
				Vehicle05BodyScript.cs = 4;
			}
		}
		//------------------------------------------------------------------
		if (V.V6.activeInHierarchy == true) {
			if (BodyBuyScript.bse == 1 && Vehicle06BodyScript.bs == 1) {
				Vehicle06BodyScript.bs = 0;	buyb ();
			} else if (BodyBuyScript.bse == 1 && Vehicle06BodyScript.bs == 2) {
				Vehicle06BodyScript.bs = 1;	buyb ();}
			if (BodyBuyScript.bse == 2 && Vehicle06BodyScript.ss == 1) {
				Vehicle06BodyScript.ss = 0;	buys ();
			} else if (BodyBuyScript.bse == 2 && Vehicle06BodyScript.ss == 2) {
				Vehicle06BodyScript.ss = 1;	buys ();}
			if (BodyBuyScript.bse == 3 && Vehicle06BodyScript.es == 1) {
				Vehicle06BodyScript.es = 0;	buye ();
			} else if (BodyBuyScript.bse == 3 && Vehicle06BodyScript.es == 2) {
				Vehicle06BodyScript.es = 1;	buye ();}
			if (BodyBuyScript.bse == 4 && Vehicle06BodyScript.cs == 1) {
				Vehicle06BodyScript.cs = 0;
			}	else if (BodyBuyScript.bse == 4 && Vehicle06BodyScript.cs == 2) {
				Vehicle06BodyScript.cs = 1;
			}	else if (BodyBuyScript.bse == 4 && Vehicle06BodyScript.cs == 3) {
				Vehicle06BodyScript.cs = 2;
			}	else if (BodyBuyScript.bse == 4 && Vehicle06BodyScript.cs == 4) {
				Vehicle06BodyScript.cs = 3;
			}	else if (BodyBuyScript.bse == 4 && Vehicle06BodyScript.cs == 5) {
				Vehicle06BodyScript.cs = 4;
			}
		}
		//------------------------------------------------------------------
		if (V.V7.activeInHierarchy == true) {
			if (BodyBuyScript.bse == 1 && Vehicle07BodyScript.bs == 1) {
				Vehicle07BodyScript.bs = 0;	buyb ();
			} else if (BodyBuyScript.bse == 1 && Vehicle07BodyScript.bs == 2) {
				Vehicle07BodyScript.bs = 1;	buyb ();}
			if (BodyBuyScript.bse == 2 && Vehicle07BodyScript.ss == 1) {
				Vehicle07BodyScript.ss = 0;	buys ();
			} else if (BodyBuyScript.bse == 2 && Vehicle07BodyScript.ss == 2) {
				Vehicle07BodyScript.ss = 1;	buys ();}
			if (BodyBuyScript.bse == 3 && Vehicle07BodyScript.es == 1) {
				Vehicle07BodyScript.es = 0;	buye ();
			} else if (BodyBuyScript.bse == 3 && Vehicle07BodyScript.es == 2) {
				Vehicle07BodyScript.es = 1;	buye ();}
			if (BodyBuyScript.bse == 4 && Vehicle07BodyScript.cs == 1) {
				Vehicle07BodyScript.cs = 0;
			}	else if (BodyBuyScript.bse == 4 && Vehicle07BodyScript.cs == 2) {
				Vehicle07BodyScript.cs = 1;
			}	else if (BodyBuyScript.bse == 4 && Vehicle07BodyScript.cs == 3) {
				Vehicle07BodyScript.cs = 2;
			}	else if (BodyBuyScript.bse == 4 && Vehicle07BodyScript.cs == 4) {
				Vehicle07BodyScript.cs = 3;
			}	else if (BodyBuyScript.bse == 4 && Vehicle07BodyScript.cs == 5) {
				Vehicle07BodyScript.cs = 4;
			}
		}
		//------------------------------------------------------------------
		if (V.V8.activeInHierarchy == true) {
			if (BodyBuyScript.bse == 1 && Vehicle08BodyScript.bs == 1) {
				Vehicle08BodyScript.bs = 0;	buyb ();
			} else if (BodyBuyScript.bse == 1 && Vehicle08BodyScript.bs == 2) {
				Vehicle08BodyScript.bs = 1;	buyb ();}
			if (BodyBuyScript.bse == 2 && Vehicle08BodyScript.ss == 1) {
				Vehicle08BodyScript.ss = 0;	buys ();
			} else if (BodyBuyScript.bse == 2 && Vehicle08BodyScript.ss == 2) {
				Vehicle08BodyScript.ss = 1;	buys ();}
			if (BodyBuyScript.bse == 3 && Vehicle08BodyScript.es == 1) {
				Vehicle08BodyScript.es = 0;	buye ();
			} else if (BodyBuyScript.bse == 3 && Vehicle08BodyScript.es == 2) {
				Vehicle08BodyScript.es = 1;	buye ();}
			if (BodyBuyScript.bse == 4 && Vehicle08BodyScript.cs == 1) {
				Vehicle08BodyScript.cs = 0;
			}	else if (BodyBuyScript.bse == 4 && Vehicle08BodyScript.cs == 2) {
				Vehicle08BodyScript.cs = 1;
			}	else if (BodyBuyScript.bse == 4 && Vehicle08BodyScript.cs == 3) {
				Vehicle08BodyScript.cs = 2;
			}	else if (BodyBuyScript.bse == 4 && Vehicle08BodyScript.cs == 4) {
				Vehicle08BodyScript.cs = 3;
			}	else if (BodyBuyScript.bse == 4 && Vehicle08BodyScript.cs == 5) {
				Vehicle08BodyScript.cs = 4;
			}
		}
		//------------------------------------------------------------------
		if (V.V9.activeInHierarchy == true) {
			if (BodyBuyScript.bse == 1 && Vehicle09BodyScript.bs == 1) {
				Vehicle09BodyScript.bs = 0;	buyb ();
			} else if (BodyBuyScript.bse == 1 && Vehicle09BodyScript.bs == 2) {
				Vehicle09BodyScript.bs = 1;	buyb ();}
			if (BodyBuyScript.bse == 2 && Vehicle09BodyScript.ss == 1) {
				Vehicle09BodyScript.ss = 0;	buys ();
			} else if (BodyBuyScript.bse == 2 && Vehicle09BodyScript.ss == 2) {
				Vehicle09BodyScript.ss = 1;	buys ();}
			if (BodyBuyScript.bse == 3 && Vehicle09BodyScript.es == 1) {
				Vehicle09BodyScript.es = 0;	buye ();
			} else if (BodyBuyScript.bse == 3 && Vehicle09BodyScript.es == 2) {
				Vehicle09BodyScript.es = 1;	buye ();}
			if (BodyBuyScript.bse == 4 && Vehicle09BodyScript.cs == 1) {
				Vehicle09BodyScript.cs = 0;
			}	else if (BodyBuyScript.bse == 4 && Vehicle09BodyScript.cs == 2) {
				Vehicle09BodyScript.cs = 1;
			}	else if (BodyBuyScript.bse == 4 && Vehicle09BodyScript.cs == 3) {
				Vehicle09BodyScript.cs = 2;
			}	else if (BodyBuyScript.bse == 4 && Vehicle09BodyScript.cs == 4) {
				Vehicle09BodyScript.cs = 3;
			}	else if (BodyBuyScript.bse == 4 && Vehicle09BodyScript.cs == 5) {
				Vehicle09BodyScript.cs = 4;
			}
		}
		if (V.V10.activeInHierarchy == true) {
			if (BodyBuyScript.bse == 1 && Vehicle10BodyScript.bs == 1) {
				Vehicle10BodyScript.bs = 0;	buyb ();
			} else if (BodyBuyScript.bse == 1 && Vehicle10BodyScript.bs == 2) {
				Vehicle10BodyScript.bs = 1;	buyb ();}
			if (BodyBuyScript.bse == 2 && Vehicle10BodyScript.ss == 1) {
				Vehicle10BodyScript.ss = 0;	buys ();
			} else if (BodyBuyScript.bse == 2 && Vehicle10BodyScript.ss == 2) {
				Vehicle10BodyScript.ss = 1;	buys ();}
			if (BodyBuyScript.bse == 3 && Vehicle10BodyScript.es == 1) {
				Vehicle10BodyScript.es = 0;	buye ();
			} else if (BodyBuyScript.bse == 3 && Vehicle10BodyScript.es == 2) {
				Vehicle10BodyScript.es = 1;	buye ();}
			if (BodyBuyScript.bse == 4 && Vehicle10BodyScript.cs == 1) {
				Vehicle10BodyScript.cs = 0;
			}	else if (BodyBuyScript.bse == 4 && Vehicle10BodyScript.cs == 2) {
				Vehicle10BodyScript.cs = 1;
			}	else if (BodyBuyScript.bse == 4 && Vehicle10BodyScript.cs == 3) {
				Vehicle10BodyScript.cs = 2;
			}	else if (BodyBuyScript.bse == 4 && Vehicle10BodyScript.cs == 4) {
				Vehicle10BodyScript.cs = 3;
			}	else if (BodyBuyScript.bse == 4 && Vehicle10BodyScript.cs == 5) {
				Vehicle10BodyScript.cs = 4;
			}
		}
	}
	void buyb()
	{
		bb.enabled = true;
		bumper.enabled = false;
	}
	void buys()
	{
		bs.enabled = true;
		spoiler.enabled = false;
	}
	void buye()
	{
		be.enabled = true;
		exhaust.enabled = false;
	}
	}
