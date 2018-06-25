using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnSlow : MonoBehaviour
{

    public static TrafficPathFollow[] PathToFollow = new TrafficPathFollow[512];

    //	public static TrafficPathFollow StaticPathToFollow;

    private int[] CurrentWayPointID = new int[201];
    private float[] speed = new float[201];
    private float[] reachDistance = new float[201];
    private float[] rotationSpeed = new float[201];
    public static bool[] col = new bool[201];
    public static bool[] cols = new bool[201];
    public static bool car;
    private float[] distance = new float[201];
    int x;
    public bool startObj = true;

    private AudioSource engine;

    public static string carName;

    private Vector3[] curPos = new Vector3[201];

    public int carInt;

    // Use this for initialization
    void Start()
    {
        engine = gameObject.GetComponent<AudioSource>();
        carName = gameObject.name;

        if (carName.Length == 5)
        {
            carName = carName.Substring(carName.Length - 2);
            carInt = int.Parse(carName) - 1; //Parse = 정수로 바꿈
            Debug.Log(carInt);

        }
        else
        {
            carName = carName.Substring(carName.Length - 3);
            carInt = int.Parse(carName);

        }
        col[carInt] = false;
        speed[carInt] = 5; //주행속도
        rotationSpeed[carInt] = 5;     //회전할때 속도
        reachDistance[carInt] = 1;

    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (x < 2)
        {
            x++;
        }
        else
        {
            if (ChangeTrafficPath.start == true && startObj == true)
            {
                PathToFollow[carInt] = ChangeTrafficPath.cPath[carInt];
                startObj = false;

            }
            if (col[carInt] == true)
            {
                if (speed[carInt] > 0)
                {
                    speed[carInt] -= 5f;
                    speed[carInt] -= 5f;
                    // Debug.Log("col");
                }
                if (engine.pitch > 0.6f)
                {
                    engine.pitch -= 0.01f;

                }
            }
            else if (col[carInt] == false)
            {
                if (speed[carInt] < 51)
                {
                    speed[carInt] += 0.01f;
                    //Debug.Log("no col");
                }
                if (engine.pitch < 0.9f)
                {
                    engine.pitch += 0.01f;
                }
            }

            if (speed[carInt] < 0)
            {
                speed[carInt] = 0;
                //Debug.Log("no speed");
            }
            Debug.Log(CurrentWayPointID[carInt]);

            distance[carInt] = Vector3.Distance(PathToFollow[carInt].path_objs[CurrentWayPointID[carInt]].position, transform.position);

            //CurrentWayPoinrID[carInt]가 없으면안됨
            transform.position = Vector3.MoveTowards(transform.position, PathToFollow[carInt].path_objs[CurrentWayPointID[carInt]].position, Time.deltaTime * speed[carInt]);
            //내차 현재 위치에서 좌표 방향으로 초당 스피드만큼 앞으로간다.
            var rotation = Quaternion.LookRotation(PathToFollow[carInt].path_objs[CurrentWayPointID[carInt]].position - curPos[carInt]);
            // Debug.Log("PathToFollow[carInt].path_objs[CurrentWayPointID[carInt]].position - curPos[carInt]" + PathToFollow[carInt].path_objs[CurrentWayPointID[carInt]].position - curPos[carInt]);
            //타겟을 기준으로 회전한다.
            transform.rotation = Quaternion.Slerp(transform.localRotation, rotation, Time.deltaTime * rotationSpeed[carInt]);
            //Debug.Log("transform.localRotation" + transform.localRotation);
            //Quaternion.Slerp(A,B,t) A에서 B로 회전속도는 t
            //Debug.Log("rotation"+rotation);
            curPos[carInt] = transform.position;

            if (distance[carInt] <= reachDistance[carInt])
            {   //1=reachdistance 
                // Debug.Log(CurrentWayPointID[carInt] +" : "+carInt);
                CurrentWayPointID[carInt]++; //회전구간진입시 1씩증가하다가 10에서 멈춘다.

            }


            if (CurrentWayPointID[carInt] >= PathToFollow[carInt].path_objs.Count)
            {
                PathToFollow[carInt] = ChangeTrafficPath.cPath[carInt];
                //Debug.Log("PathToFollow[carInt].path_objs.Count"+PathToFollow[carInt].path_objs.Count);

                CurrentWayPointID[carInt] = 1;
            }

        }
    }
}

