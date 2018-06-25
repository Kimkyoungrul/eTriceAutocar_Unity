using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class CameraManager : MonoBehaviour {

	int cams;

	[Header("PlayerCamera")]
	public bool firstCamera;
	public static bool firstCameraOp;
	public bool secondCamera;
	public static bool secondCameraOp;
	public bool thirdCamera;
	public static bool thirdCameraOp;

	// Use this for initialization
	void Start () {

		//Camera Settings
		firstCameraOp = firstCamera;
		secondCameraOp = secondCamera;
		thirdCameraOp = thirdCamera;

	}
	
	#if UNITY_EDITOR
	void Update()
	{

		if (cams == 0)
			cams = 1;

		if (firstCamera && cams!=1) {
			cams = 1;
			secondCamera = false;
			thirdCamera = false;
		}

		if (secondCamera && cams!=2) {
			cams = 2;
			firstCamera = false;
			thirdCamera = false;
		}

		if (thirdCamera && cams!=3) {
			cams = 3;
			secondCamera = false;
			firstCamera = false;
		}
	}
	#endif
}
