using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class P2vehicleController : MonoBehaviour {

	private GameObject vehicleBody;
	private GameObject wheelLeftFront;
	private GameObject wheelRightFront;
	private GameObject wheelLeftBack;
	private GameObject wheelRightBack;

	private PhysicMaterial tirePhysicsMat;
	private PhysicMaterial bodyPhysicsMat;
	
	[Header("Vehicle Tuning")]
	
	[Range(0f,3000f)]
	public float horsepower = 220f;
	[Range(0f,300f)]
	public float steering = 70f;
	[Range(0f,100f)]
	private float tireGrip = 100f;
	[Range(0f,10f)]
	private float wheelHangDistance = 1f;
	private bool wheelTiltWithBody = true;
	private Vector3 suspensionLengths = new Vector3(0.4f,0f,0.4f);
	[Range(0f,100)]
	private float suspensionTension = 15f;
	
	private bool autoCorrectRot = true;

	private GameObject FireIgnitionParticles;
	private GameObject NitroParticles;
	private Slider NitroImage;

	[Header("Sounds")]

	private AudioSource Engine;
	private AudioSource Tire;
	private AudioSource FireIgnition;
	private AudioSource Nitro;

	[HideInInspector]
	public Rigidbody rbody;
	private Rigidbody jbody;
	[HideInInspector]
	public GameObject physicsBody;
	private GameObject colBody;
	private GameObject suspensionBody;
	private GameObject colSuspension;
	private GameObject wheels;
	private GameObject colLB;
	private GameObject colLF;
	private GameObject colRB;
	private GameObject colRF;
	private GameObject turnLF;
	private GameObject turnRF;
	
	[HideInInspector]
	public float inputX;
	private float inputY;
	private float xVel;
	[HideInInspector]
	public float zVel;
	[HideInInspector]
	public bool touchLB;
	[HideInInspector]
	public bool touchLF;
	[HideInInspector]
	public bool touchRB;
	[HideInInspector]
	public bool touchRF;
	private int tiresOnGround;
	private int FtiresOnGround;
	private int BtiresOnGround;
	private float airTime;
	private float unstableTime = 0f;
	[HideInInspector]
	public bool roofOnGround = false;
	private Vector3 defaultCOG;
	private float boundSize = 1f;
	private float nitroSpeed;
	private float nitrocapacity = 8;
	public static int speedb,speeds,speede, steerb,steers,steere,nitrob,nitros,nitroe;
	public static int spd, std, nid;
	private float suspension = 0.5f;

	public static bool move;

	void Awake()
	{

		Instantiate(Resources.Load ("Manager/P2CameraDown", typeof(GameObject)));


		move = true;

		if (gameObject.name == "P2Vehicle07") {
			suspension = 0;
		}

		vehicleBody = GameObject.Find ("P2Body");
		wheelLeftFront = GameObject.Find ("P2FLW");
		wheelRightFront = GameObject.Find ("P2FRW");
		wheelLeftBack = GameObject.Find ("P2BLW");
		wheelRightBack = GameObject.Find ("P2BRW");
		tirePhysicsMat = GameObject.Find ("P2TireP").GetComponent<BoxCollider> ().material;
		bodyPhysicsMat = GameObject.Find ("P2BodyP").GetComponent<BoxCollider> ().material;

		//make sure vehicleBody has the correct parent//
		vehicleBody.transform.SetParent(transform);
		
		//create physics body//
		physicsBody = new GameObject(gameObject.name+" physicsP2");
		physicsBody.transform.position = (wheelLeftBack.transform.position + wheelLeftFront.transform.position + wheelRightBack.transform.position + wheelRightFront.transform.position)/4;
		physicsBody.transform.rotation = transform.rotation;
		transform.position = physicsBody.transform.position;
		
		//create a wheels holder
		wheels = new GameObject(gameObject.name+" wheelsP2");
		wheels.transform.position = physicsBody.transform.position;
		wheels.transform.rotation = physicsBody.transform.rotation;
		
		//create rigidbody//
		rbody = physicsBody.AddComponent<Rigidbody>();
		rbody.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
		rbody.mass = 100f;
		rbody.angularDrag = 5f;
		
		//set up the wheels//
		
		//rear left wheel//
		Mesh mesh = wheelLeftBack.GetComponentInChildren<MeshFilter>().mesh;
		getDiameter(mesh);
		colLB = new GameObject("P2colLB");
		SphereCollider col = colLB.AddComponent<SphereCollider>();
		if(wheelLeftBack.transform.childCount > 0)
		{
			col.radius = 1.5f;
			colLB.transform.position = wheelLeftBack.transform.position;
		}
		else
		{
			col.radius = 1.5f;
			colLB.transform.position = wheelLeftBack.transform.position + mesh.bounds.center;
		}
		col.material = tirePhysicsMat;
		col.center = new Vector3(0f,0f,0f);
		colLB.transform.SetParent(physicsBody.transform);
		P2wheel wheelScript = colLB.AddComponent<P2wheel>();
		wheelScript.vehicleObj = gameObject;
		wheelScript.wheelObj = wheelLeftBack;
		wheelScript.wheelLB = true;
		wheelScript.wheelHangDistance = wheelHangDistance;
		wheelLeftBack.transform.SetParent(wheels.transform);
		
		//front left wheel//
		mesh = wheelLeftFront.GetComponentInChildren<MeshFilter>().mesh;
		getDiameter(mesh);
		colLF = new GameObject("P2colLF");
		col = colLF.AddComponent<SphereCollider>();
		if(wheelLeftFront.transform.childCount > 0)
		{
			col.radius = 1.5f;
			colLF.transform.position = wheelLeftFront.transform.position;
		}
		else
		{
			col.radius = 1.5f;
			colLF.transform.position = wheelLeftFront.transform.position + mesh.bounds.center;
		}
		col.material = tirePhysicsMat;
		col.center = new Vector3(0f,0f,0f);
		colLF.transform.SetParent(physicsBody.transform);
		wheelScript = colLF.AddComponent<P2wheel>();
		wheelScript.vehicleObj = gameObject;
		wheelScript.wheelObj = wheelLeftFront;
		wheelScript.wheelLF = true;
		wheelScript.wheelHangDistance = wheelHangDistance;
		
		turnLF = new GameObject("turnLF");
		turnLF.transform.SetParent(wheels.transform);
		turnLF.transform.position = wheelLeftFront.transform.position;
		turnLF.transform.rotation = wheels.transform.rotation;
		wheelLeftFront.transform.SetParent(turnLF.transform);
		wheelScript.turnObj = turnLF;
		wheelScript.frontTire = true;
		
		//rear right wheel//
		mesh = wheelRightBack.GetComponentInChildren<MeshFilter>().mesh;
		getDiameter(mesh);
		colRB = new GameObject("P2colRB");
		col = colRB.AddComponent<SphereCollider>();
		if(wheelRightBack.transform.childCount > 0)
		{
			col.radius= 1.5f;
			colRB.transform.position = wheelRightBack.transform.position;
		}
		else
		{
			col.radius = 1.5f;
			colRB.transform.position = wheelRightBack.transform.position + mesh.bounds.center;
		}
		col.material = tirePhysicsMat;
		col.center = new Vector3(0f,0f,0f);
		colRB.transform.SetParent(physicsBody.transform);
		wheelScript = colRB.AddComponent<P2wheel>();
		wheelScript.vehicleObj = gameObject;
		wheelScript.wheelObj = wheelRightBack;
		wheelScript.wheelRB = true;
		wheelScript.wheelHangDistance = wheelHangDistance;
		wheelRightBack.transform.SetParent(wheels.transform);
		
		//front right wheel//
		mesh = wheelRightFront.GetComponentInChildren<MeshFilter>().mesh;
		getDiameter(mesh);
		colRF = new GameObject("P2colRF");
		col = colRF.AddComponent<SphereCollider>();
		if(wheelRightFront.transform.childCount > 0)
		{
			col.radius = 1.5f;
			colRF.transform.position = wheelRightFront.transform.position;
		}
		else
		{
			col.radius = 1.5f;
			colRF.transform.position = wheelRightFront.transform.position + mesh.bounds.center;
		}
		col.material = tirePhysicsMat;
		col.center = new Vector3(0f,0f,0f);
		colRF.transform.SetParent(physicsBody.transform);
		wheelScript = colRF.AddComponent<P2wheel>();
		wheelScript.vehicleObj = gameObject;
		wheelScript.wheelObj = wheelRightFront;
		wheelScript.wheelRF = true;
		wheelScript.wheelHangDistance = wheelHangDistance;
		
		turnRF = new GameObject("P2turnRF");
		turnRF.transform.SetParent(wheels.transform);
		turnRF.transform.position = wheelRightFront.transform.position;
		turnRF.transform.rotation = wheels.transform.rotation;
		wheelRightFront.transform.SetParent(turnRF.transform);
		wheelScript.turnObj = turnRF;
		wheelScript.frontTire = true;
		
		//create a body holder//
		suspensionBody = new GameObject(gameObject.name+" suspensionP2");
		suspensionBody.transform.position = physicsBody.transform.position;
		suspensionBody.transform.rotation = physicsBody.transform.rotation;
		
		jbody = suspensionBody.AddComponent<Rigidbody>();
		jbody.useGravity = false;
		jbody.mass = 10f;
		jbody.drag = 1f;
		jbody.angularDrag = 2f;
		jbody.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
		CharacterJoint joint = suspensionBody.AddComponent<CharacterJoint>();
		joint.connectedBody = rbody;
		joint.axis = new Vector3(1f,0f,0f);
		joint.swingAxis = new Vector3(1f,0f,0f);
		joint.enablePreprocessing = false;
		joint.enableProjection = true;
		
		SoftJointLimitSpring temp = joint.twistLimitSpring;
		temp.spring = suspensionTension*4000f;
		temp.damper = 0.4f;
		joint.twistLimitSpring = temp;
		
		SoftJointLimit temp2 = joint.lowTwistLimit;
		temp2.limit = suspensionLengths.x*-0.5f;
		temp2.bounciness = 0.5f;
		joint.lowTwistLimit = temp2;
		
		SoftJointLimit temp3 = joint.highTwistLimit;
		temp3.limit = suspensionLengths.x;
		temp3.bounciness = 0.5f;
		joint.highTwistLimit = temp3;
		
		SoftJointLimitSpring temp4 = joint.swingLimitSpring;
		temp4.spring = suspensionTension*3000f;
		temp4.damper = 0.1f;
		joint.swingLimitSpring = temp4;
		
		SoftJointLimit temp5 = joint.swing1Limit;
		temp5.limit = suspensionLengths.y*0.1f;
		temp5.bounciness = 0.5f;
		joint.swing1Limit = temp5;
		
		SoftJointLimit temp6 = joint.swing2Limit;
		temp6.limit = suspensionLengths.z;
		temp6.bounciness = 0.5f;
		joint.swing2Limit = temp6;
		
		//create body collider//
		colSuspension = new GameObject("P2colSuspension");
		colSuspension.transform.position = suspensionBody.transform.position;
		colSuspension.transform.rotation = suspensionBody.transform.rotation;
		colSuspension.transform.SetParent(suspensionBody.transform);
		BoxCollider col2 = colSuspension.AddComponent<BoxCollider>();
		float distX = Vector3.Distance(wheelLeftFront.transform.position,wheelRightFront.transform.position);
		float distZ = Vector3.Distance(wheelLeftFront.transform.position,wheelLeftBack.transform.position);
		col2.size = new Vector3(distX - (col.radius),(col.radius)*0.5f,distZ + ((col.radius)*2f));
		col2.center = new Vector3(0f,2f,0f);
		col2.material = bodyPhysicsMat;
		
		jbody.centerOfMass = col2.center + new Vector3(0f,col.radius*0.5f,0f);
		rbody.centerOfMass = col2.center + new Vector3(0f,-col.radius*0.5f,0f);
		defaultCOG = rbody.centerOfMass;
		
		colBody = new GameObject("P2colBody");
		colBody.transform.position = physicsBody.transform.position;
		colBody.transform.rotation = physicsBody.transform.rotation;
		colBody.transform.SetParent(physicsBody.transform);
		BoxCollider col3 = colBody.AddComponent<BoxCollider>();
		col3.size = new Vector3(distX - col.radius,col.radius*0.5f,distZ+10);
		col3.center = new Vector3(0f,col.radius,0f);
		col3.material = bodyPhysicsMat;

		Engine = GameObject.Find ("P2EngineSound").GetComponent<AudioSource> ();
		Nitro = GameObject.Find ("P2NitroSound").GetComponent<AudioSource> ();
		FireIgnition = GameObject.Find ("P2FireIgnitionSound").GetComponent<AudioSource> ();
		Tire = GameObject.Find ("P2TireSound").GetComponent<AudioSource> (); 


	}
	
	void getDiameter(Mesh mesh)
	{
		//of x y z, if two of them are equal, that must be the diameter//
		if(mesh.bounds.size.z == mesh.bounds.size.x)
		{
			boundSize = mesh.bounds.size.z;
		}
		else if(mesh.bounds.size.z == mesh.bounds.size.y)
		{
			boundSize = mesh.bounds.size.z;
		}
		else if(mesh.bounds.size.x == mesh.bounds.size.y)
		{
			boundSize = mesh.bounds.size.x;
		}
		//if the wheel is not round, go with the largest length for diameter//
		else
		{
			boundSize = mesh.bounds.size.z;
			
			if(mesh.bounds.size.x > boundSize)
			{
				boundSize = mesh.bounds.size.x;
			}
			if(mesh.bounds.size.y > boundSize)
			{
				boundSize = mesh.bounds.size.y;
			}
		}
	}
	
	// Use this for initialization
	void Start () 
	{
		inputX = 0f;
		inputY = 0f;
		
		xVel = 0f;
		zVel = 0f;
		
		//prevent colliding with seams in ground//
		Physics.defaultContactOffset = 0.001f;

		Engine.pitch = 0.6f;

		horsepower = horsepower + speedb + speeds + speede + spd; 
		nitroSpeed = horsepower;

		steering = steering + steerb + steers + steere + std;

		nitrocapacity = nitrocapacity - nitrob - nitros - nitroe - nid;

		NitroImage = GameObject.Find ("P2NitroImage").GetComponent<Slider> ();
		NitroParticles = GameObject.Find ("P2Nitro");
		NitroParticles.SetActive (false);
		FireIgnitionParticles = GameObject.Find ("P2FireIgnition");
		FireIgnitionParticles.SetActive (false);
	}
	
	void Update()
	{
		//track how many tires are touching the ground//
		tiresOnGround = 0;
		FtiresOnGround = 0;
		BtiresOnGround = 0;
		if(touchLB)
		{
			tiresOnGround++;
			BtiresOnGround++;
			airTime = 0f;
		}
		if(touchLF)
		{
			tiresOnGround++;
			FtiresOnGround++;
			airTime = 0f;
		}
		if(touchRB)
		{
			tiresOnGround++;
			BtiresOnGround++;
			airTime = 0f;
		}
		if(touchRF)
		{
			tiresOnGround++;
			FtiresOnGround++;
			airTime = 0f;
		}
		
		if(tiresOnGround <= 0)
		{
			airTime+=Time.deltaTime;
		}
		
		if(tiresOnGround >= 4)
		{
			unstableTime = 0f;
		}
		else
		{
			unstableTime += Time.deltaTime;
		}
		
		//prevent being stuck upside down//
		if(autoCorrectRot)
		{
			Vector3 rayUp = physicsBody.transform.TransformDirection(Vector3.up);
			//Debug.DrawRay(physicsBody.transform.position, rayUp*5f, Color.green);
			RaycastHit[] hits;
			roofOnGround = false;
			hits = Physics.RaycastAll (physicsBody.transform.position, rayUp,5f);
			
			if(hits.Length > 2)
			{
				roofOnGround = true;
			}
			
			if(tiresOnGround <= 0 && roofOnGround == true)
			{
				rbody.centerOfMass = new Vector3(0f,-5f*transform.localScale.y,0f);
			}
			
			if(tiresOnGround >=3)
			{
				rbody.centerOfMass = defaultCOG;
			}
			
			if(unstableTime > 5f)
			{
				if(rbody.velocity.magnitude < 2f)
				{
					rbody.centerOfMass = new Vector3(0f,-5f*transform.localScale.y,0f);
					
					if(unstableTime > 10f)
					{
						physicsBody.transform.rotation = Quaternion.Euler(0f,0f,0f);
						unstableTime = 6f;
					}
				}
			}
		}
	}
	// Update is called once per frame
	void FixedUpdate () 
	{

		//input//
		if (move) {
			inputX = Mathf.SmoothStep (inputX, CrossPlatformInputManager.GetAxis ("P2Horizontal"), (steering * 0.2f) * Time.deltaTime);
			inputY = CrossPlatformInputManager.GetAxis ("P2Vertical");
		}else {
		inputX = 0f;
		inputY = 0f;
	}

		//track velocity//
		xVel = physicsBody.transform.InverseTransformDirection(rbody.velocity).x;
		zVel = physicsBody.transform.InverseTransformDirection(rbody.velocity).z;
		
		//accellerate forwards//
		if (inputY > 0) {
			if (FtiresOnGround > 0 || airTime < 0.6f) {
				rbody.AddForce (inputY * physicsBody.transform.forward * (horsepower * 400f) * Time.deltaTime);
				if (Engine.pitch < 1.2f)
					Engine.pitch += 0.01f;
			}
			if (Engine.pitch <= 0.75f) {
				FireIgnition.enabled = true;
				FireIgnitionParticles.SetActive (true);
				StartCoroutine(Ignition());
			}
			if (Input.GetKey (KeyCode.RightShift) && NitroImage.value > 2) {
				NitroParticles.SetActive (true);
				NitroImage.value -= nitrocapacity;
				horsepower = nitroSpeed + 500;
				Nitro.enabled = true;
				if (Engine.pitch < 1.5f)
					Engine.pitch += 0.01f;
			} else {	
				NitroParticles.SetActive (false);
				Nitro.enabled = false;
				horsepower = nitroSpeed; 
			}
		}
		//accellerate backwards
		else {
			if (BtiresOnGround > 0) {
				rbody.AddForce (inputY * physicsBody.transform.forward * (horsepower * 200f) * Time.deltaTime);
				if (Engine.pitch > 0.7f) {
					Engine.pitch -= 0.02f;
				}
				if (inputY < 0) {
					if (Engine.pitch <= 0.9f) {
						Engine.pitch += 0.011f;
						Tire.enabled = false;
					} else if (Engine.pitch > 0.9f)
						Tire.enabled = true;
				} else
					Tire.enabled = false;
			}
			if(horsepower == nitroSpeed + 500) {
				NitroParticles.SetActive (false);
				Nitro.enabled = false;
				horsepower = nitroSpeed;
			}
		}


		
		if(tiresOnGround > 0 || airTime < 0.3f)
		{
			//stop sliding sideways//
			rbody.AddForce(physicsBody.transform.right*xVel*-(tireGrip*140f)*Time.deltaTime);
			
			//downforce//
			rbody.AddForce(physicsBody.transform.up*(Mathf.Abs(zVel)*-5000f)*Time.deltaTime);
		}
		else
		{
			if(airTime > 0.3f)
			{
				//increase gravity//
				rbody.AddForce((Physics.gravity * rbody.mass)*2f);
			}
		}
		
		//steer//
		float y = inputX*Time.deltaTime*steering;
		if(y > Mathf.Abs(zVel*0.2f))
		{
			y=Mathf.Abs(zVel*0.2f);
		}
		else if(y < (Mathf.Abs(zVel*0.2f))*-1f)
		{
			y = (Mathf.Abs(zVel*0.2f))*-1f;
		}
		if(zVel < 0f)
		{
			y*=-1f;
		}
		
		//steer//
		rbody.angularVelocity = new Vector3(rbody.angularVelocity.x,0f,rbody.angularVelocity.z);
		if(airTime > 0f)
		{
			physicsBody.transform.Rotate(0f,y*1.5f,0f);
		}
		else
		{
			physicsBody.transform.Rotate(0f,y*2f,0f);
		}
	
		NitroImage.value += 1;

		//smoothen out the visual movement//
		float smooth = 0.1f + (rbody.velocity.magnitude*0.02f);
	
		transform.position = Vector3.Slerp(transform.position,physicsBody.transform.position,smooth);
		transform.rotation = Quaternion.Slerp(transform.rotation,physicsBody.transform.rotation,0.2f);
		vehicleBody.transform.rotation = Quaternion.Slerp(vehicleBody.transform.rotation, suspensionBody.transform.rotation,suspension);	

	}

	void LateUpdate()
	{
		wheels.transform.position = transform.position;
		if(wheelTiltWithBody)
		{
			wheels.transform.rotation = vehicleBody.transform.rotation;
		}
		else
		{
			wheels.transform.rotation = transform.rotation;
		}
	}
		
	IEnumerator Ignition() {
		yield return new WaitForSeconds(1);
		FireIgnition.enabled = false;
		FireIgnitionParticles.SetActive (false);
	}
}


















