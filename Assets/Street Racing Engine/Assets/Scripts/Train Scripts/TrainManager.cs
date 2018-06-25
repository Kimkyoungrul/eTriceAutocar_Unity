using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainManager : MonoBehaviour {

	public bool trainStart;
	public bool trainEnd;



	[Header("Carriage Number")]

	public int maxCarriage;
	public bool randomCarriage;

	public static bool destroy;

	private List<GameObject> TrainList = new List<GameObject>();	


	// Use this for initialization
	void Start () {

		foreach (GameObject trainPref in Resources.LoadAll("Train", typeof(GameObject))) {
			TrainList.Add (trainPref);
		}

		if (randomCarriage) {
		 int randomCarr = UnityEngine.Random.Range (3, maxCarriage);
			maxCarriage = randomCarr;
		}
		if (trainStart) {
			StartCoroutine (SpawnNewTrain ());
			}
	}
	
	// Update is called once per frame
	void Update () {
		if (trainStart && destroy) {
			StartCoroutine (SpawnNewTrain ());
			destroy = false;
		}
	}

	void OnTriggerExit(Collider col)
	{
		if(col.gameObject.tag == "TrainEnd")
		{
			if (trainEnd) {
				GameObject[] train = GameObject.FindGameObjectsWithTag ("Train");
				GameObject frontC = GameObject.FindGameObjectWithTag ("TrainStart");
				GameObject backC = GameObject.FindGameObjectWithTag ("TrainEnd");
				Destroy (frontC);
				Destroy(backC);
				for (var i = 0; i < train.Length; i++) {
					Destroy (train [i]);
					destroy = true;
				}
			}
		}
	}
	IEnumerator SpawnNewTrain() {
		{	int carriageNumber = 1;
			yield return new WaitForSeconds(2);
			{
				}
				Instantiate (TrainList [0], new Vector3 (transform.position.x, transform.position.y, transform.position.z), transform.rotation);
				while (carriageNumber < maxCarriage) {
					int prefabIndex = UnityEngine.Random.Range (1, TrainList.Count);	
				GameObject TrainObj = Instantiate (TrainList [prefabIndex], new Vector3 (transform.position.x-38*carriageNumber, transform.position.y, transform.position.z), transform.rotation) as GameObject;;
					carriageNumber++;
				if (carriageNumber == maxCarriage) {
					TrainObj.tag = "TrainEnd";
				}	
				}
			}
		}
}
