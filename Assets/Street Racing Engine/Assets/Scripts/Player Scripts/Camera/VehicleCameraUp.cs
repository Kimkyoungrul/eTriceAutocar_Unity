using UnityEngine;
using System.Collections;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class VehicleCameraUp: MonoBehaviour {

	private GameObject carObj;
	
	[Header("Camera Settings")]
	
	public Vector3 lookAtOffset = new Vector3(0f,0f,0f);
	public Vector3 followPosition = new Vector3(0f,2f,-5f);
	public bool useCarRotation = true;
	public bool tiltWithSlopes = false;
	[Range(0f,100f)]
	public float followSpeed = 5f;
	[Range(0f,3f)]
	private Vector3 goalPos;
	private Vector3 finalLookPos;
	private Quaternion goalRot;
	public GameObject cam;
	
	
	// Use this for initialization
	void Start () 
	{
		carObj = GameObject.Find ("Wheels");
		if (!CameraManager.secondCameraOp && gameObject.name == "CameraSecond")
			gameObject.SetActive (false);
	}
	
		void FixedUpdate()
	{
		if (Input.GetKeyDown (KeyCode.V)) {
			cam.SetActive (true);
			gameObject.SetActive(false);
		}
//			followPosition = new Vector3 (10, 20, -11);
//			useCarRotation = false;
			if (followSpeed < 100f) {
				moveCamera ();
			}


	}
	void moveCamera()
	{
		if(useCarRotation)
		{
			goalPos = carObj.transform.position + (carObj.transform.forward*followPosition.z) + (carObj.transform.up*followPosition.y) + (carObj.transform.right*followPosition.x);
			finalLookPos = carObj.transform.position + (carObj.transform.forward*lookAtOffset.z) + (carObj.transform.up*lookAtOffset.y) + (carObj.transform.right*lookAtOffset.x);
		}
		else
		{
			goalPos = carObj.transform.position + followPosition;
			finalLookPos = carObj.transform.position + lookAtOffset;
		}
		transform.position = Vector3.Lerp(transform.position,goalPos,followSpeed*Time.deltaTime);

		if(tiltWithSlopes)
		{
			goalRot = Quaternion.LookRotation(finalLookPos - transform.position,carObj.transform.up);
			transform.rotation = Quaternion.Lerp(transform.rotation,goalRot,followSpeed*0.05f);
		}
		else
		{
			transform.LookAt(finalLookPos);
		}
	}
}







