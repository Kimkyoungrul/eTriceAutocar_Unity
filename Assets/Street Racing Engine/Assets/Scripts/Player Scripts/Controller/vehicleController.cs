using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
#if UNITY_EDITOR
using UnityEditor;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.Networking;

#endif
public class vehicleController : MonoBehaviour
{
    //private Network_vehicleController n_vehicle;
    private Socket m_listener = null;//������� 
    private Socket m_socket = null;//������� 
    private GameObject vehicleBody;
    private GameObject wheelLeftFront;
    private GameObject wheelRightFront;
    private GameObject wheelLeftBack;
    private GameObject wheelRightBack;

    private PhysicMaterial tirePhysicsMat;
    private PhysicMaterial bodyPhysicsMat;
    public bool isAtStartup = true;
    [Header("Vehicle Tuning")]
    private bool kkrstate = false;
    private int xposition = 0;
    [Range(0f, 3000f)]
    public float horsepower = 220f;
    [Range(0f, 300f)]
    public float steering = 70f;
    [Range(0f, 100f)]
    private float tireGrip = 0f;
    [Range(0f, 10f)]
    private float wheelHangDistance = 1f;
    private bool wheelTiltWithBody = true;
    private Vector3 suspensionLengths = new Vector3(0.4f, 0f, 0.4f);
    [Range(0f, 100)]
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
    private Socket recvServer;
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
    public static int speedb, speeds, speede, steerb, steers, steere, nitrob, nitros, nitroe;
    public static int spd, std, nid;
    private float suspension = 0.5f;

    public static bool move;
    private NetworkStream etstream;
  
    private GameObject Vehicle01;   
    private GameObject Trafficlight01;  //��ȣ��
    public string ss;   //steering�� string���� �ٲ� ��
    public int colliderNum;
    public string s_message; //���� �޽���
    private string Trafficdistance; //��ȣ��� �Ÿ�
    string mvelocity;//�ӷ� 
    string msteering;//�ڵ�
    private float traffic;
    private int ALKSpeed;
    public float Car01distance;
    public float Car09distance;
    public string distance;
    public int count = 0;
    public string[] spstring = new string[512];
    private GameObject Car01;
    private GameObject Car09;

    enum State
    {
        ClientProcess,
        StartListener,
        AcceptClient,
        ServerCommunication,
        CloseConnection,
        StopListener,
        EndCommunication,
    }
    void Awake()
    {
        Console.WriteLine("Connected to server...");

        Instantiate(Resources.Load("Manager/CarCanvas", typeof(GameObject)));
        if (GameManager.mobileOn || GameManager.cameraOp)
        {
            Instantiate(Resources.Load("Manager/PlayerCameraMobile", typeof(GameObject)));
        }
        else if (!GameManager.mobileOn && !GameManager.cameraOp)
        {
            Instantiate(Resources.Load("Manager/PlayerCamera", typeof(GameObject)));
        }
        move = true;

        if (gameObject.name == "Vehicle07")
        {
            suspension = 0;
        }

        vehicleBody = GameObject.Find("Body");
        wheelLeftFront = GameObject.Find("FLW");
        wheelRightFront = GameObject.Find("FRW");
        wheelLeftBack = GameObject.Find("BLW");
        wheelRightBack = GameObject.Find("BRW");
        tirePhysicsMat = GameObject.Find("TireP").GetComponent<BoxCollider>().material;
        bodyPhysicsMat = GameObject.Find("BodyP").GetComponent<BoxCollider>().material;

        //make sure vehicleBody has the correct parent//
        vehicleBody.transform.SetParent(transform);

        //create physics body//
        physicsBody = new GameObject(gameObject.name + " physics");
        physicsBody.transform.position = (wheelLeftBack.transform.position + wheelLeftFront.transform.position + wheelRightBack.transform.position + wheelRightFront.transform.position) / 4;
        physicsBody.transform.rotation = transform.rotation;
        transform.position = physicsBody.transform.position;

        //create a wheels holder
        wheels = new GameObject(gameObject.name + " wheels");
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
        colLB = new GameObject("colLB");
        SphereCollider col = colLB.AddComponent<SphereCollider>();
        if (wheelLeftBack.transform.childCount > 0)
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
        col.center = new Vector3(0f, 0f, 0f);
        colLB.transform.SetParent(physicsBody.transform);
        wheel wheelScript = colLB.AddComponent<wheel>();
        wheelScript.vehicleObj = gameObject;
        wheelScript.wheelObj = wheelLeftBack;
        wheelScript.wheelLB = true;
        wheelScript.wheelHangDistance = wheelHangDistance;
        wheelLeftBack.transform.SetParent(wheels.transform);

        //front left wheel//
        mesh = wheelLeftFront.GetComponentInChildren<MeshFilter>().mesh;
        getDiameter(mesh);
        colLF = new GameObject("colLF");
        col = colLF.AddComponent<SphereCollider>();
        if (wheelLeftFront.transform.childCount > 0)
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
        col.center = new Vector3(0f, 0f, 0f);
        colLF.transform.SetParent(physicsBody.transform);
        wheelScript = colLF.AddComponent<wheel>();
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
        colRB = new GameObject("colRB");
        col = colRB.AddComponent<SphereCollider>();
        if (wheelRightBack.transform.childCount > 0)
        {
            col.radius = 1.5f;
            colRB.transform.position = wheelRightBack.transform.position;
        }
        else
        {
            col.radius = 1.5f;
            colRB.transform.position = wheelRightBack.transform.position + mesh.bounds.center;
        }
        col.material = tirePhysicsMat;
        col.center = new Vector3(0f, 0f, 0f);
        colRB.transform.SetParent(physicsBody.transform);
        wheelScript = colRB.AddComponent<wheel>();
        wheelScript.vehicleObj = gameObject;
        wheelScript.wheelObj = wheelRightBack;
        wheelScript.wheelRB = true;
        wheelScript.wheelHangDistance = wheelHangDistance;
        wheelRightBack.transform.SetParent(wheels.transform);

        //front right wheel//
        mesh = wheelRightFront.GetComponentInChildren<MeshFilter>().mesh;
        getDiameter(mesh);
        colRF = new GameObject("colRF");
        col = colRF.AddComponent<SphereCollider>();
        if (wheelRightFront.transform.childCount > 0)
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
        col.center = new Vector3(0f, 0f, 0f);
        colRF.transform.SetParent(physicsBody.transform);
        wheelScript = colRF.AddComponent<wheel>();
        wheelScript.vehicleObj = gameObject;
        wheelScript.wheelObj = wheelRightFront;
        wheelScript.wheelRF = true;
        wheelScript.wheelHangDistance = wheelHangDistance;

        turnRF = new GameObject("turnRF");
        turnRF.transform.SetParent(wheels.transform);
        turnRF.transform.position = wheelRightFront.transform.position;
        turnRF.transform.rotation = wheels.transform.rotation;
        wheelRightFront.transform.SetParent(turnRF.transform);
        wheelScript.turnObj = turnRF;
        wheelScript.frontTire = true;

        //create a body holder//
        suspensionBody = new GameObject(gameObject.name + " suspension");
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
        joint.axis = new Vector3(1f, 0f, 0f);
        joint.swingAxis = new Vector3(1f, 0f, 0f);
        joint.enablePreprocessing = false;
        joint.enableProjection = true;

        SoftJointLimitSpring temp = joint.twistLimitSpring;
        temp.spring = suspensionTension * 4000f;
        temp.damper = 0.4f;
        joint.twistLimitSpring = temp;

        SoftJointLimit temp2 = joint.lowTwistLimit;
        temp2.limit = suspensionLengths.x * -0.5f;
        temp2.bounciness = 0.5f;
        joint.lowTwistLimit = temp2;

        SoftJointLimit temp3 = joint.highTwistLimit;
        temp3.limit = suspensionLengths.x;
        temp3.bounciness = 0.5f;
        joint.highTwistLimit = temp3;

        SoftJointLimitSpring temp4 = joint.swingLimitSpring;
        temp4.spring = suspensionTension * 3000f;
        temp4.damper = 0.1f;
        joint.swingLimitSpring = temp4;

        SoftJointLimit temp5 = joint.swing1Limit;
        temp5.limit = suspensionLengths.y * 0.1f;
        temp5.bounciness = 0.5f;
        joint.swing1Limit = temp5;

        SoftJointLimit temp6 = joint.swing2Limit;
        temp6.limit = suspensionLengths.z;
        temp6.bounciness = 0.5f;
        joint.swing2Limit = temp6;

        //create body collider//
        colSuspension = new GameObject("colSuspension");
        colSuspension.transform.position = suspensionBody.transform.position;
        colSuspension.transform.rotation = suspensionBody.transform.rotation;
        colSuspension.transform.SetParent(suspensionBody.transform);
        BoxCollider col2 = colSuspension.AddComponent<BoxCollider>();
        float distX = Vector3.Distance(wheelLeftFront.transform.position, wheelRightFront.transform.position);
        float distZ = Vector3.Distance(wheelLeftFront.transform.position, wheelLeftBack.transform.position);
        col2.size = new Vector3(distX - (col.radius), (col.radius) * 0.5f, distZ + ((col.radius) * 2f));
        col2.center = new Vector3(0f, 2f, 0f);
        col2.material = bodyPhysicsMat;

        jbody.centerOfMass = col2.center + new Vector3(0f, col.radius * 0.5f, 0f);
        rbody.centerOfMass = col2.center + new Vector3(0f, -col.radius * 0.5f, 0f);
        defaultCOG = rbody.centerOfMass;

        colBody = new GameObject("colBody");
        colBody.transform.position = physicsBody.transform.position;
        colBody.transform.rotation = physicsBody.transform.rotation;
        colBody.transform.SetParent(physicsBody.transform);
        BoxCollider col3 = colBody.AddComponent<BoxCollider>();
        col3.size = new Vector3(distX - col.radius, col.radius * 0.5f, distZ + 10);
        col3.center = new Vector3(0f, col.radius, 0f);
        col3.material = bodyPhysicsMat;

        Engine = GameObject.Find("EngineSound").GetComponent<AudioSource>();
        Nitro = GameObject.Find("NitroSound").GetComponent<AudioSource>();
        FireIgnition = GameObject.Find("FireIgnitionSound").GetComponent<AudioSource>();
        Tire = GameObject.Find("TireSound").GetComponent<AudioSource>();


    }

    void getDiameter(Mesh mesh)
    {
        //of x y z, if two of them are equal, that must be the diameter//
        if (mesh.bounds.size.z == mesh.bounds.size.x)
        {
            boundSize = mesh.bounds.size.z;
        }
        else if (mesh.bounds.size.z == mesh.bounds.size.y)
        {
            boundSize = mesh.bounds.size.z;
        }
        else if (mesh.bounds.size.x == mesh.bounds.size.y)
        {
            boundSize = mesh.bounds.size.x;
        }
        //if the wheel is not round, go with the largest length for diameter//
        else
        {
            boundSize = mesh.bounds.size.z;

            if (mesh.bounds.size.x > boundSize)
            {
                boundSize = mesh.bounds.size.x;
            }
            if (mesh.bounds.size.y > boundSize)
            {
                boundSize = mesh.bounds.size.y;
            }
        }
    }

    // Use this for initialization
    void Start()
    {
        m_listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        // TCP����� ���� ���� �ʱ�ȭ added by kkr
        m_listener.Bind(new IPEndPoint(IPAddress.Any, 50765));
        // ��Ʈ��ȣ ���ε�
        m_listener.Listen(1);//�����û�� ��ٸ���.

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

        NitroImage = GameObject.Find("NitroImage").GetComponent<Slider>();
        NitroParticles = GameObject.Find("Nitro");
        NitroParticles.SetActive(false);
        FireIgnitionParticles = GameObject.Find("FireIgnition");
        FireIgnitionParticles.SetActive(false);

    }

    void Update()
    {

        Vehicle01 = GameObject.Find("Vehicle01");   //Vehicle01 Object
        Trafficlight01 = GameObject.Find("Traffic Lights"); //��ȣ�� Object
        Vector3 trafficcollider = Trafficlight01.GetComponentInChildren<BoxCollider>().transform.position; //��ȣ���̶� ����� BoxCollider ��ġ
        Vector3 tl = Trafficlight01.transform.localPosition;//��ȣ���� ��ġ
        Car01 = GameObject.Find("Car01");//Car01�� ��ġ 
        Car09 = GameObject.Find("Car09");//Car09�� ��ġ
        traffic = trafficcollider.y; //��ȣ�� boxcollider�� y�� ��ȭ
        Vector3 vehiclecollidercenter = Vehicle01.GetComponentInChildren<BoxCollider>().center;
        Vector3 vehiclecollider = Vehicle01.transform.position + vehiclecollidercenter;//vehicle boxcollider��ġ
        Vector3 car1collidercenter = Car01.GetComponent<BoxCollider>().center;
        Vector3 car9collidercenter = Car09.GetComponent<BoxCollider>().center;
        Vector3 car1collider = Car01.transform.position + car1collidercenter;
        Vector3 car9collider = Car09.transform.position + car9collidercenter;
        Car01distance = car1collider.z - vehiclecollider.z - 23;//������ Car01�� �Ÿ�
        Car09distance = car9collider.z - vehiclecollider.z-23;//������ Car09�� �Ÿ�
        float Distance = Math.Abs((vehiclecollider.z + 10) - trafficcollider.z);//Vehicle collider ��ġ�� traffic lighit collider��ġ���� �Ÿ� 

        Trafficdistance = Distance.ToString("f2");//��ȣ������� �Ÿ�
        mvelocity = zVel.ToString("f2");//�ӷ�
        msteering = ss;//�ڵ��� ����

        //track how many tires are touching the ground//
        tiresOnGround = 0;
        FtiresOnGround = 0;
        BtiresOnGround = 0;
        if (touchLB)
        {
            tiresOnGround++;
            BtiresOnGround++;
            airTime = 0f;
        }
        if (touchLF)
        {
            tiresOnGround++;
            FtiresOnGround++;
            airTime = 0f;
        }
        if (touchRB)
        {
            tiresOnGround++;
            BtiresOnGround++;
            airTime = 0f;
        }
        if (touchRF)
        {
            tiresOnGround++;
            FtiresOnGround++;
            airTime = 0f;
        }

        if (tiresOnGround <= 0)
        {
            airTime += Time.deltaTime;
        }

        if (tiresOnGround >= 4)
        {
            unstableTime = 0f;
        }
        else
        {
            unstableTime += Time.deltaTime;
        }
        if (kkrstate)//ALK����� Update�Լ� �ȿ��� ������ �ٲ�����Ѵ�. added by kkr
        {
            physicsBody.transform.position = new Vector3(xposition, physicsBody.transform.position.y, physicsBody.transform.position.z);
        }
        //prevent being stuck upside down//
        if (autoCorrectRot)
        {
            Vector3 rayUp = physicsBody.transform.TransformDirection(Vector3.up);
            RaycastHit[] hits;
            roofOnGround = false;
            hits = Physics.RaycastAll(physicsBody.transform.position, rayUp, 5f);

            if (hits.Length > 2)
            {
                roofOnGround = true;
            }

            if (tiresOnGround <= 0 && roofOnGround == true)
            {
                rbody.centerOfMass = new Vector3(0f, -5f * transform.localScale.y, 0f);
            }

            if (tiresOnGround >= 3)
            {
                rbody.centerOfMass = defaultCOG;
            }

            if (unstableTime > 5f)
            {
                if (rbody.velocity.magnitude < 2f)
                {
                    rbody.centerOfMass = new Vector3(0f, -5f * transform.localScale.y, 0f);

                    if (unstableTime > 10f)
                    {
                        physicsBody.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                        unstableTime = 6f;
                    }
                }
            }
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        string message = "0";//message �ʱ�ȭ 
        if (m_listener != null && m_listener.Poll(0, SelectMode.SelectRead))
            //Poll�޼ҵ�� ������¸� Ȯ���Ͽ� �񵿱�� ���� added by kkr
        {   
            m_socket = m_listener.Accept();// Ŭ���̾�Ʈ�� ���ӵǾ���.
            Debug.Log("Connected from client.");
        }
        if (m_socket != null)//added by kkr
        {
            while (m_socket.Poll(0, SelectMode.SelectRead))
            {
                byte[] buffer = new byte[8192];//���� �ʱ�ȭ 
                int? recvSize = m_socket.Receive(buffer, buffer.Length, SocketFlags.None);//added by kkr
                if (recvSize == null)
                {
                }
                else if (recvSize > 0)
                {
                    message = System.Text.Encoding.UTF8.GetString(buffer);//���� buffer�� string�������� message�� ����
                    byte[] buffer1 = new byte[2048];//���ۻ����� ����
                    if (count == 0) //������ ���� �ʱ�ȭ
                    {
                        distance = Car01distance.ToString("f2");
                        colliderNum = 1;
                        count++;
                    }
                    s_message = mvelocity + "," + distance + "," + colliderNum + "," + msteering + "," + traffic;//������ message
                    buffer1 = System.Text.Encoding.UTF8.GetBytes(s_message);
                    int sendSize = buffer1.Length;
                    m_socket.Send(buffer1, sendSize, SocketFlags.None);//Client�� ����
                }
            }
        }

        if (move)
        {

            //input//
            inputX = Mathf.SmoothStep(inputX, CrossPlatformInputManager.GetAxis("Horizontal"), (steering * 0.2f) * Time.deltaTime);
            inputY = CrossPlatformInputManager.GetAxis("Vertical");

        }
        else
        {
            inputX = 0f;
            inputY = 0f;
        }

        char sp = ',';  //�и��� ���� ���� added jsk
        spstring = message.Split(sp); //message split�ؼ� ����
        inputY = float.Parse(spstring[0]);//horsepower�� ����

        if (spstring.Length > 1)    //added jsk
        {
            colliderNum = int.Parse(spstring[2]);  
            if (colliderNum == 1)
            {
                distance = Car01distance.ToString("f2");//Car01������ �Ÿ��� distance ����

            }
            else if (colliderNum == 2)
            {
                distance = Car09distance.ToString("f2");//Car09������ �Ÿ��� distance ����            
            }
            else if (colliderNum == 3)
            {
                distance = Trafficdistance;//��ȣ������� �Ÿ��� distance ����
            }
        }

        if (inputY >= 1)
        {
            inputY = 400f;//revised by kkr
        }
        else if (inputY == -1)//AEB added by kkr
        {
            rbody.velocity = Vector3.zero;  //�ӵ��� 0���� �����Ѵ�.
            rbody.angularVelocity = Vector3.zero;
        }
        else if (inputY == -2)//ALK added by kkr
        {
            if (colliderNum == 2)
            {
                kkrstate = true;
                xposition = 14;
            }
            else if (colliderNum == 3)
            {
                xposition = -13;
            }
            else
            {
            }
        }
        if (spstring.Length > 1)
        {
            string a = spstring[1]; //added jsk
            inputX = float.Parse(a);//steering �� ����
            inputX = inputX / 100;
            inputX = (float)Math.Truncate((decimal)inputX * 100) / 100;
        }

        xVel = physicsBody.transform.InverseTransformDirection(rbody.velocity).x;
        zVel = physicsBody.transform.InverseTransformDirection(rbody.velocity).z;
        //accellerate forwards//
        if (inputY > 0)
        {

            if (FtiresOnGround > 0 || airTime < 0.6f)
            {
                rbody.AddForce(inputY * physicsBody.transform.forward * (horsepower * 1f) * Time.smoothDeltaTime);//horsepower ������Ʈ ���⸦ ���� revised by kkr
                if (Engine.pitch < 1.2f)
                    Engine.pitch += 0.005f;
            }
            if (Engine.pitch <= 0.75f)
            {
                FireIgnition.enabled = true;
                FireIgnitionParticles.SetActive(true);
                StartCoroutine(Ignition());
            }
            if (CrossPlatformInputManager.GetButton("Jump") && NitroImage.value > 2 || Input.GetKey(KeyCode.LeftShift) && NitroImage.value > 2)
            {
                NitroParticles.SetActive(true);
                NitroImage.value -= nitrocapacity;
                horsepower = nitroSpeed + 500;
                Nitro.enabled = true;
                if (Engine.pitch < 1.5f)
                    Engine.pitch += 0.01f;
            }
            else
            {
                NitroParticles.SetActive(false);
                Nitro.enabled = false;
                horsepower = nitroSpeed;
            }
        }
        //accellerate backwards
        else
        {
            if (BtiresOnGround > 0)
            {
                rbody.AddForce(inputY * physicsBody.transform.forward * (horsepower * 200f) * Time.deltaTime);
                if (Engine.pitch > 0.7f)
                {
                    Engine.pitch -= 0.02f;
                }
                if (inputY < 0)
                {
                    if (Engine.pitch <= 0.9f)
                    {
                        Engine.pitch += 0.011f;
                        Tire.enabled = false;
                    }
                    else if (Engine.pitch > 0.9f)
                        Tire.enabled = true;
                }
                else
                    Tire.enabled = false;
            }
            if (horsepower == nitroSpeed + 500)
            {
                NitroParticles.SetActive(false);
                Nitro.enabled = false;
                horsepower = nitroSpeed;
            }
        }


        // Debug.Log(ToString());
        if (tiresOnGround > 0 || airTime < 0.3f)
        {
            //stop sliding sideways//
            rbody.AddForce(physicsBody.transform.right * xVel * -(tireGrip * 140f) * Time.smoothDeltaTime);

            //downforce//
            rbody.AddForce(physicsBody.transform.up * (Mathf.Abs(zVel) * -7700f) * Time.smoothDeltaTime);//���� ���⸦ ���� revised by kkr
        }
        else
        {
            if (airTime > 0.3f)
            {
                //increase gravity//
                rbody.AddForce((Physics.gravity * rbody.mass) * 2f);
            }
        }

        //steer//
        float y = inputX * Time.deltaTime * steering;
        ss = y.ToString("f4");  //steering ��
       
        if (y > Mathf.Abs(zVel * 0.2f))
        {
            y = Mathf.Abs(zVel * 0.2f);
        }
        else if (y < (Mathf.Abs(zVel * 0.2f)) * -1f)
        {
            if (Engine.pitch > 1f)
                Engine.pitch -= 0.05f;
            y = (Mathf.Abs(zVel * 0.2f)) * -1f;
        }
        if (zVel < 0f)
        {
            y *= -1f;
        }

        //steer//
        rbody.angularVelocity = new Vector3(rbody.angularVelocity.x, 0f, rbody.angularVelocity.z);

        if (airTime > 0f)
        {
            physicsBody.transform.Rotate(0f, y * 1.5f, 0f);
        }
        else
        {
            physicsBody.transform.Rotate(0f, y * 2f, 0f);
        }

        NitroImage.value += 0.5f;

        //smoothen out the visual movement//
        float smooth = 0.1f + (rbody.velocity.magnitude * 0.02f);

        transform.position = Vector3.Slerp(transform.position, physicsBody.transform.position, smooth);
        transform.rotation = Quaternion.Slerp(transform.rotation, physicsBody.transform.rotation, 0.2f);
        vehicleBody.transform.rotation = Quaternion.Slerp(vehicleBody.transform.rotation, suspensionBody.transform.rotation, suspension);

    }

    void LateUpdate()
    {
        wheels.transform.position = transform.position;
        if (wheelTiltWithBody)
        {
            wheels.transform.rotation = vehicleBody.transform.rotation;
        }
        else
        {
            wheels.transform.rotation = transform.rotation;
        }
    }

    IEnumerator Ignition()
    {
        yield return new WaitForSeconds(1);
        FireIgnition.enabled = false;
        FireIgnitionParticles.SetActive(false);
    }
}
