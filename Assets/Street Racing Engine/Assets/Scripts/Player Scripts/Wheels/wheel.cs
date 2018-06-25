using UnityEngine;
using System.Collections;

public class wheel : MonoBehaviour {

	[HideInInspector]
	public GameObject vehicleObj;
	[HideInInspector]
	public GameObject turnObj;
	[HideInInspector]
	public GameObject wheelObj;
	[HideInInspector]
	public bool frontTire = false;
	[HideInInspector]
	public float wheelHangDistance = 1f;
	private float suspensionRange;

	private float radius;
	private Vector3 goalPos;
	private Vector3 WheelstartPos;
	private bool touchGround;
	[HideInInspector]
	public bool wheelLB = false;
	[HideInInspector]
	public bool wheelLF = false;
	[HideInInspector]
	public bool wheelRB = false;
	[HideInInspector]
	public bool wheelRF = false;

	// Use this for initialization
	void Start () 
	{
		WheelstartPos = wheelObj.transform.localPosition;
		goalPos = transform.position;
		radius = GetComponent<SphereCollider>().radius;
		suspensionRange = (GetComponent<SphereCollider>().radius/2f)*wheelHangDistance;
		touchGround = false;


	}
	
	// Update is called once per frame
	void Update () 
	{
		//assume the ground is far away//
		float groundDist = 10f;

		Vector3 down = transform.TransformDirection(Vector3.down);
		//Debug.DrawRay(transform.position, down*10f, Color.green);
		RaycastHit hit;
		//int mask = 1 << 8;
		if(Physics.Raycast (transform.position, down, out hit))//, 10f,mask))
		{
			//detect ground distance//
			groundDist = Vector3.Distance(transform.position, hit.point) - radius;
			
			if(groundDist <= suspensionRange)
			{
				if(!touchGround)
				{
					setTouchGround(true);
				}
			}
			else if(touchGround)
			{
				setTouchGround(false);
			}

		}
		else if(touchGround)
		{
			setTouchGround(false);
		}
		
		//restrict tires from going above car//
		if(groundDist < 0f)
		{
			groundDist = 0f;
		}
		
		//restrict tires from going below the suspension limit//
		if(groundDist > suspensionRange)
		{
			groundDist = suspensionRange;
		}

		goalPos = new Vector3(WheelstartPos.x,WheelstartPos.y - groundDist,WheelstartPos.z);
		
		//update tire y position//
		if(wheelObj.transform.localPosition.y < goalPos.y)
		{
			wheelObj.transform.localPosition = Vector3.Lerp(wheelObj.transform.localPosition,goalPos,14f*Time.deltaTime);
		}
		else
		{
			wheelObj.transform.localPosition = Vector3.Lerp(wheelObj.transform.localPosition,goalPos,10f*Time.deltaTime);
		}

		//front tires//
		if (frontTire) {
			//steer tire visual//
			turnObj.transform.localRotation = Quaternion.Euler (wheelObj.transform.localRotation.x, vehicleObj.GetComponent<vehicleController> ().inputX * 33f, wheelObj.transform.localRotation.z);
		}

	}

	//tell vehicle which wheel is touching the ground//
	void setTouchGround(bool _bool)
	{
		touchGround = _bool;

		if(wheelLB)
		{
			vehicleObj.GetComponent<vehicleController>().touchLB = touchGround;
		}
		else if(wheelLF)
		{
			vehicleObj.GetComponent<vehicleController>().touchLF = touchGround;
		}
		else if(wheelRB)
		{
			vehicleObj.GetComponent<vehicleController>().touchRB = touchGround;
		}
		else if(wheelRF)
		{
			vehicleObj.GetComponent<vehicleController>().touchRF = touchGround;
		}
	}
}






