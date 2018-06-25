using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BodyBuyScript : MonoBehaviour {

//	public BodyPartsInt BodyParts;
	public static int bse, col;
	public int bx, sx, ex, cx;
	public static bool attach = false;
	public Image bb, bs, be;
	public GameObject p, g, b, s, e, c, r, l, back, color;
	public Vehicle V;

	public void PressedB()
	{
		if(V.V1.activeInHierarchy == true)bx = Vehicle01BodyScript.bs;	if(V.V2.activeInHierarchy == true)bx = Vehicle02BodyScript.bs;	if(V.V3.activeInHierarchy == true)bx = Vehicle03BodyScript.bs;	if(V.V4.activeInHierarchy == true)bx = Vehicle04BodyScript.bs;	if(V.V5.activeInHierarchy == true)bx = Vehicle05BodyScript.bs;	if(V.V6.activeInHierarchy == true)bx = Vehicle06BodyScript.bs;	if(V.V7.activeInHierarchy == true)bx = Vehicle07BodyScript.bs;	if(V.V8.activeInHierarchy == true)bx = Vehicle08BodyScript.bs;	if(V.V9.activeInHierarchy == true)bx = Vehicle09BodyScript.bs;	if(V.V10.activeInHierarchy == true)bx = Vehicle10BodyScript.bs;
		bse = 1;
		col = 0;
		CarSpinScript.speed = 0;
		p.SetActive (true);
		b.SetActive (true);
		s.SetActive (false);
		e.SetActive (false);
		c.SetActive (false);
		back.SetActive (true);
		g.SetActive (false);
	}
	public void PressedS()
	{
		if(V.V1.activeInHierarchy == true)sx = Vehicle01BodyScript.ss;	if(V.V2.activeInHierarchy == true)sx = Vehicle02BodyScript.ss;	if(V.V3.activeInHierarchy == true)sx = Vehicle03BodyScript.ss;	if(V.V4.activeInHierarchy == true)sx = Vehicle04BodyScript.ss;	if(V.V5.activeInHierarchy == true)sx = Vehicle05BodyScript.ss;	if(V.V6.activeInHierarchy == true)sx = Vehicle06BodyScript.ss;	if(V.V7.activeInHierarchy == true)sx = Vehicle07BodyScript.ss;	if(V.V8.activeInHierarchy == true)sx = Vehicle08BodyScript.ss;	if(V.V9.activeInHierarchy == true)sx = Vehicle09BodyScript.ss;	if(V.V10.activeInHierarchy == true)sx = Vehicle10BodyScript.ss;
		bse = 2;
		col = 0;
		CarSpinScript.speed = 0;
		p.SetActive (true);
		b.SetActive (false);
		s.SetActive (true);
		e.SetActive (false);
		c.SetActive (false);
		back.SetActive (true);
		g.SetActive (false);
	}
	public void PRessedE()
	{
		if(V.V1.activeInHierarchy == true)ex = Vehicle01BodyScript.es;	if(V.V2.activeInHierarchy == true)ex = Vehicle02BodyScript.es;	if(V.V3.activeInHierarchy == true)ex = Vehicle03BodyScript.es;	if(V.V4.activeInHierarchy == true)ex = Vehicle04BodyScript.es;	if(V.V5.activeInHierarchy == true)ex = Vehicle05BodyScript.es;	if(V.V6.activeInHierarchy == true)ex = Vehicle06BodyScript.es;	if(V.V7.activeInHierarchy == true)ex = Vehicle07BodyScript.es;	if(V.V8.activeInHierarchy == true)ex = Vehicle08BodyScript.es;	if(V.V9.activeInHierarchy == true)ex = Vehicle09BodyScript.es;	if(V.V10.activeInHierarchy == true)ex = Vehicle10BodyScript.es;
		bse = 3;
		col = 0;
		CarSpinScript.speed = 0;
		p.SetActive (true);
		b.SetActive (false);
		s.SetActive (false);
		e.SetActive (true);
		c.SetActive (false);
		back.SetActive (true);
		g.SetActive (false);
	}
	public void PRessedC()
	{
		if(V.V1.activeInHierarchy == true)cx = Vehicle01BodyScript.cs;	if(V.V2.activeInHierarchy == true)cx = Vehicle02BodyScript.cs;	if(V.V3.activeInHierarchy == true)cx = Vehicle03BodyScript.cs;	if(V.V4.activeInHierarchy == true)cx = Vehicle04BodyScript.cs;	if(V.V5.activeInHierarchy == true)cx = Vehicle05BodyScript.cs;	if(V.V6.activeInHierarchy == true)cx = Vehicle06BodyScript.cs;	if(V.V7.activeInHierarchy == true)cx = Vehicle07BodyScript.cs;	if(V.V8.activeInHierarchy == true)cx = Vehicle08BodyScript.cs;	if(V.V9.activeInHierarchy == true)cx = Vehicle09BodyScript.cs;	if(V.V10.activeInHierarchy == true)cx = Vehicle10BodyScript.cs;
		bse = 4;
		col = 1;
		p.SetActive (true);
		b.SetActive (false);
		s.SetActive (false);
		e.SetActive (false);
		c.SetActive (true);
		color.SetActive (true);
		back.SetActive (true);
		g.SetActive (false);
	}
	public void PressedAdd()
	{
		bse = 0;
		CarSpinScript.speed = 0;
		back.SetActive (false);
		g.SetActive (true);
		p.SetActive (false);
	}
	public void PRessedEx()
	{
		if (bse == 1 && V.V1.activeInHierarchy == true)
			Vehicle01BodyScript.bs = bx;
		if (bse == 2 && V.V1.activeInHierarchy == true)
		Vehicle01BodyScript.ss = sx;	
		if (bse == 3 && V.V1.activeInHierarchy == true)
		Vehicle01BodyScript.es = ex;  
		if (bse == 4 && V.V1.activeInHierarchy == true)
		Vehicle01BodyScript.cs = cx;

		if (bse == 1 && V.V2.activeInHierarchy == true)
			Vehicle02BodyScript.bs = bx;
		if (bse == 2 && V.V2.activeInHierarchy == true)
			Vehicle02BodyScript.ss = sx;	
		if (bse == 3 && V.V2.activeInHierarchy == true)
			Vehicle02BodyScript.es = ex;
		if (bse == 4 && V.V2.activeInHierarchy == true)
			Vehicle02BodyScript.cs = cx;
		
		if (bse == 1 && V.V3.activeInHierarchy == true)
			Vehicle03BodyScript.bs = bx;
		if (bse == 2 && V.V3.activeInHierarchy == true)
			Vehicle03BodyScript.ss = sx;	
		if (bse == 3 && V.V3.activeInHierarchy == true)
			Vehicle03BodyScript.es = ex;
		if (bse == 4 && V.V3.activeInHierarchy == true)
			Vehicle03BodyScript.cs = cx;

		if (bse == 1 && V.V4.activeInHierarchy == true)
			Vehicle04BodyScript.bs = bx;
		if (bse == 2 && V.V4.activeInHierarchy == true)
			Vehicle04BodyScript.ss = sx;	
		if (bse == 3 && V.V4.activeInHierarchy == true)
			Vehicle04BodyScript.es = ex;
		if (bse == 4 && V.V4.activeInHierarchy == true)
			Vehicle04BodyScript.cs = cx;

		if (bse == 1 && V.V5.activeInHierarchy == true)
			Vehicle05BodyScript.bs = bx;
		if (bse == 2 && V.V5.activeInHierarchy == true)
			Vehicle05BodyScript.ss = sx;	
		if (bse == 3 && V.V5.activeInHierarchy == true)
			Vehicle05BodyScript.es = ex;
		if (bse == 4 && V.V5.activeInHierarchy == true)
			Vehicle05BodyScript.cs = cx;

		if (bse == 1 && V.V6.activeInHierarchy == true)
			Vehicle06BodyScript.bs = bx;
		if (bse == 2 && V.V6.activeInHierarchy == true)
			Vehicle06BodyScript.ss = sx;	
		if (bse == 3 && V.V6.activeInHierarchy == true)
			Vehicle06BodyScript.es = ex;
		if (bse == 4 && V.V6.activeInHierarchy == true)
			Vehicle06BodyScript.cs = cx;

		if (bse == 1 && V.V7.activeInHierarchy == true)
			Vehicle07BodyScript.bs = bx;
		if (bse == 2 && V.V7.activeInHierarchy == true)
			Vehicle07BodyScript.ss = sx;	
		if (bse == 3 && V.V7.activeInHierarchy == true)
			Vehicle07BodyScript.es = ex;
		if (bse == 4 && V.V7.activeInHierarchy == true)
			Vehicle07BodyScript.cs = cx;

		if (bse == 1 && V.V8.activeInHierarchy == true)
			Vehicle08BodyScript.bs = bx;
		if (bse == 2 && V.V8.activeInHierarchy == true)
			Vehicle08BodyScript.ss = sx;	
		if (bse == 3 && V.V8.activeInHierarchy == true)
			Vehicle08BodyScript.es = ex;
		if (bse == 4 && V.V8.activeInHierarchy == true)
			Vehicle08BodyScript.cs = cx;

		if (bse == 1 && V.V9.activeInHierarchy == true)
			Vehicle09BodyScript.bs = bx;
		if (bse == 2 && V.V9.activeInHierarchy == true)
			Vehicle09BodyScript.ss = sx;	
		if (bse == 3 && V.V9.activeInHierarchy == true)
			Vehicle09BodyScript.es = ex;
		if (bse == 4 && V.V9.activeInHierarchy == true)
			Vehicle09BodyScript.cs = cx;

		if (bse == 1 && V.V10.activeInHierarchy == true)
			Vehicle10BodyScript.bs = bx;
		if (bse == 2 && V.V10.activeInHierarchy == true)
			Vehicle10BodyScript.ss = sx;	
		if (bse == 3 && V.V10.activeInHierarchy == true)
			Vehicle10BodyScript.es = ex;
		if (bse == 4 && V.V10.activeInHierarchy == true)
			Vehicle10BodyScript.cs = cx;
		
		bb.enabled = false;
		bs.enabled = false;
		be.enabled = false;
		bse = 0;
		color.SetActive (false);
		CarSpinScript.speed = 0;
		back.SetActive (false);
		g.SetActive (true);
		p.SetActive (false);
	}
	public void PRessedExC()
	{
		bse = 0;
		color.SetActive (false);
		back.SetActive (false);
		g.SetActive (true);
		p.SetActive (false);
	}
}
