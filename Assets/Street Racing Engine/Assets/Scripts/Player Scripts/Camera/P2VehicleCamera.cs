using UnityEngine;
using System.Collections;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class P2VehicleCamera: MonoBehaviour {

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
	
	
	// Use this for initialization
	void Start () 
	{
		carObj = GameObject.Find ("Wheels");
	}
	
		void FixedUpdate()
	{		

		if (Input.GetKey (KeyCode.Keypad2)) {
				followPosition = new Vector3 (followPosition.x, followPosition.y, 30);
		} else if (Input.GetKey (KeyCode.Keypad4)) {
				followPosition = new Vector3 (30, followPosition.y, 0);
		} else if (Input.GetKey (KeyCode.Keypad6)) {
				followPosition = new Vector3 (-30, followPosition.y, 0);
			} else {
				followPosition.z = -27;
				followPosition.x = 0;
			}
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







