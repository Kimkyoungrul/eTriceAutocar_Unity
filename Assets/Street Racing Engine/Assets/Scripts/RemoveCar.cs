using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveCar : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(transform.position.x,transform.position.y - 20,transform.position.z);
        Invoke("test", 10f);
    }
	
	// Update is called once per frame
	void Update () {
       
    }
    void test()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 20, transform.position.z);
    }
}
