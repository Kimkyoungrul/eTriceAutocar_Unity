using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficPathFollow : MonoBehaviour {
    //하얀색으로 길만들기
	private Color rayColor = Color.white;
	public List<Transform> path_objs = new List<Transform>();
	Transform[] theArray;
    static public Vector3 pos;
	void OnDrawGizmos()
	{
		Gizmos.color = rayColor;
		theArray = GetComponentsInChildren<Transform> ();
        path_objs.Clear();


        foreach (Transform path_obj in theArray)	//path_obj가 변하는 동안
		{
			if (path_obj != this.transform) {
				path_objs.Add (path_obj);
              
			}
		}
		for (int i = 0; i < path_objs.Count; i++) {
			pos = path_objs [i].position;
           
			if (i > 0) {
				Vector3 prepos = path_objs [i - 1].position;
				Gizmos.DrawLine (prepos, pos);//prepos에서 pos로 향하는 라인을 만든다.
				Gizmos.DrawWireSphere (pos,5);//pos에서 반지름이 5인 원을 그린다.
			}
		}
	}
}
