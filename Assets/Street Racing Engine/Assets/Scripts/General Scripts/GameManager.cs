using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	//Racing Prefabs
	private List<GameObject> RouteList = new List<GameObject>();
	//Multiplayer Racing Prefabs
	private List<GameObject> MultiplayerRouteList = new List<GameObject>();

	[Header("Day Time")]
	public int secondsInOneDay = 480;
	public bool day, night;

	[Header("Traffic")]
	[Range(0,200)]
	public int maxTrafficCars;

	[Header("Player")]
	public bool customCar;

	[Header("Mobile")]
	public bool mobileSettings;
	public static bool mobileOn;

	[Header("Optimization")]
	public bool traffic;
	public static bool trafficOp;
	public bool rangeTraffic;
	public static bool disableTrafficOp;
	public bool player;
	public static bool playerOp;
	public bool cam;
	public static bool cameraOp;
	public bool canvas;
	public static bool canvasOp;

	void Awake () {

		//Optimization Settings
		mobileOn = mobileSettings;
		trafficOp = traffic;
		disableTrafficOp = rangeTraffic;

		playerOp = player;
		cameraOp = cam;
		canvasOp = canvas;

		//Local time setup
		Sun.secondsInFullDay = secondsInOneDay;
		Sun.day = day;
		Sun.night = night;

		//If started racing script will instantiate route prefab
		if (LoadRaceMap.race) {
			foreach (GameObject routePref in Resources.LoadAll("RoutesPlayer", typeof(GameObject))) {
				RouteList.Add (routePref);
			}

			foreach (GameObject MultiplayerRoutePref in Resources.LoadAll("RoutesMultiplayer", typeof(GameObject))) {
				MultiplayerRouteList.Add (MultiplayerRoutePref);
			}
			if (MultiPlayerCanvas.multiplayer) {
				Instantiate (MultiplayerRouteList [Route.n]);
				MultiPlayerCanvas.multiplayer = false;
			} else {
				Instantiate (RouteList [Route.n]);
			}
		
		} else {
			//If player choose freeride script will spawn car by default
			if (PlayerPrefs.GetInt ("V01A") == 0 
				&& PlayerPrefs.GetInt("V02A") == 0  
				&& PlayerPrefs.GetInt("V03A") == 0 
				&& PlayerPrefs.GetInt("V04A") == 0  
				&& PlayerPrefs.GetInt("V05A") == 0  
				&& PlayerPrefs.GetInt("V06A") == 0  
				&& PlayerPrefs.GetInt("V07A") == 0  
				&& PlayerPrefs.GetInt("V08A") == 0  
				&& PlayerPrefs.GetInt("V09A") == 0  
				&& PlayerPrefs.GetInt("V10A") == 0)
				 {
				PlayerPrefs.SetInt ("V01A", 2);
			}
			if (!customCar) {
				if(!mobileOn && !GameManager.playerOp)
				{
				if (PlayerPrefs.GetInt ("V01A") == 2) {
					if (GameObject.FindGameObjectWithTag ("Home") != null) {
						GameObject home = GameObject.FindGameObjectWithTag ("Home");
						Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle01", typeof(GameObject)), new Vector3 (home.transform.position.x + 38, home.transform.position.y, home.transform.position.z - 12), home.transform.rotation);
					} else {
						Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle01", typeof(GameObject)));
					}
				}
				if (PlayerPrefs.GetInt ("V02A") == 2) {
					if (GameObject.FindGameObjectWithTag ("Home") != null) {
						GameObject home = GameObject.FindGameObjectWithTag ("Home");
						Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle02", typeof(GameObject)), new Vector3 (home.transform.position.x + 38, home.transform.position.y, home.transform.position.z - 12), home.transform.rotation);
					} else {
						Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle02", typeof(GameObject)));
					}
				}
				if (PlayerPrefs.GetInt ("V03A") == 2) {
					if (GameObject.FindGameObjectWithTag ("Home") != null) {
						GameObject home = GameObject.FindGameObjectWithTag ("Home");
						Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle03", typeof(GameObject)), new Vector3 (home.transform.position.x + 38, home.transform.position.y, home.transform.position.z - 12), home.transform.rotation);
					} else {
						Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle03", typeof(GameObject)));
					}
				}
				if (PlayerPrefs.GetInt ("V04A") == 2) {
					if (GameObject.FindGameObjectWithTag ("Home") != null) {
						GameObject home = GameObject.FindGameObjectWithTag ("Home");
						Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle04", typeof(GameObject)), new Vector3 (home.transform.position.x + 38, home.transform.position.y, home.transform.position.z - 12), home.transform.rotation);
					} else {
						Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle04", typeof(GameObject)));
					}
				}
				if (PlayerPrefs.GetInt ("V05A") == 2) {
					if (GameObject.FindGameObjectWithTag ("Home") != null) {
						GameObject home = GameObject.FindGameObjectWithTag ("Home");
						Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle05", typeof(GameObject)), new Vector3 (home.transform.position.x + 38, home.transform.position.y, home.transform.position.z - 12), home.transform.rotation);
					} else {
						Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle05", typeof(GameObject)));
					}
				}
				if (PlayerPrefs.GetInt ("V06A") == 2) {
					if (GameObject.FindGameObjectWithTag ("Home") != null) {
						GameObject home = GameObject.FindGameObjectWithTag ("Home");
						Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle06", typeof(GameObject)), new Vector3 (home.transform.position.x + 38, home.transform.position.y, home.transform.position.z - 12), home.transform.rotation);
					} else {
						Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle06", typeof(GameObject)));
					}
				}
				if (PlayerPrefs.GetInt ("V07A") == 2) {
					if (GameObject.FindGameObjectWithTag ("Home") != null) {
						GameObject home = GameObject.FindGameObjectWithTag ("Home");
						Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle07", typeof(GameObject)), new Vector3 (home.transform.position.x + 38, home.transform.position.y, home.transform.position.z - 12), home.transform.rotation);
					} else {
						Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle07", typeof(GameObject)));
					}
				}
				if (PlayerPrefs.GetInt ("V08A") == 2) {
					if (GameObject.FindGameObjectWithTag ("Home") != null) {
						GameObject home = GameObject.FindGameObjectWithTag ("Home");
						Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle08", typeof(GameObject)), new Vector3 (home.transform.position.x + 38, home.transform.position.y, home.transform.position.z - 12), home.transform.rotation);
					} else {
						Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle08", typeof(GameObject)));
					}
				}
				if (PlayerPrefs.GetInt ("V09A") == 2) {
					if (GameObject.FindGameObjectWithTag ("Home") != null) {
						GameObject home = GameObject.FindGameObjectWithTag ("Home");
						Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle09", typeof(GameObject)), new Vector3 (home.transform.position.x + 38, home.transform.position.y, home.transform.position.z - 12), home.transform.rotation);
					} else {
						Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle09", typeof(GameObject)));
					}
				}
				if (PlayerPrefs.GetInt ("V10A") == 2) {
					if (GameObject.FindGameObjectWithTag ("Home") != null) {
						GameObject home = GameObject.FindGameObjectWithTag ("Home");
						Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle10", typeof(GameObject)), new Vector3 (home.transform.position.x + 38, home.transform.position.y, home.transform.position.z - 5), home.transform.rotation);
					} else {
						Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle10", typeof(GameObject)));
					}
				}
				} else if(mobileOn || playerOp) {
				if (PlayerPrefs.GetInt ("V01A") == 2) {
					if (GameObject.FindGameObjectWithTag ("Home") != null) {
						GameObject home = GameObject.FindGameObjectWithTag ("Home");
						Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle01", typeof(GameObject)), new Vector3 (home.transform.position.x + 38, home.transform.position.y, home.transform.position.z - 12), home.transform.rotation);
					} else {
						Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle01", typeof(GameObject)));
					}
				}
				if (PlayerPrefs.GetInt ("V02A") == 2) {
					if (GameObject.FindGameObjectWithTag ("Home") != null) {
						GameObject home = GameObject.FindGameObjectWithTag ("Home");
						Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle02", typeof(GameObject)), new Vector3 (home.transform.position.x + 38, home.transform.position.y, home.transform.position.z - 12), home.transform.rotation);
					} else {
						Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle02", typeof(GameObject)));
					}
				}
				if (PlayerPrefs.GetInt ("V03A") == 2) {
					if (GameObject.FindGameObjectWithTag ("Home") != null) {
						GameObject home = GameObject.FindGameObjectWithTag ("Home");
						Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle03", typeof(GameObject)), new Vector3 (home.transform.position.x + 38, home.transform.position.y, home.transform.position.z - 12), home.transform.rotation);
					} else {
						Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle03", typeof(GameObject)));
					}
				}
				if (PlayerPrefs.GetInt ("V04A") == 2) {
					if (GameObject.FindGameObjectWithTag ("Home") != null) {
						GameObject home = GameObject.FindGameObjectWithTag ("Home");
						Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle04", typeof(GameObject)), new Vector3 (home.transform.position.x + 38, home.transform.position.y, home.transform.position.z - 12), home.transform.rotation);
					} else {
						Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle04", typeof(GameObject)));
					}
				}
				if (PlayerPrefs.GetInt ("V05A") == 2) {
					if (GameObject.FindGameObjectWithTag ("Home") != null) {
						GameObject home = GameObject.FindGameObjectWithTag ("Home");
						Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle05", typeof(GameObject)), new Vector3 (home.transform.position.x + 38, home.transform.position.y, home.transform.position.z - 12), home.transform.rotation);
					} else {
						Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle05", typeof(GameObject)));
					}
				}
				if (PlayerPrefs.GetInt ("V06A") == 2) {
					if (GameObject.FindGameObjectWithTag ("Home") != null) {
						GameObject home = GameObject.FindGameObjectWithTag ("Home");
						Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle06", typeof(GameObject)), new Vector3 (home.transform.position.x + 38, home.transform.position.y, home.transform.position.z - 12), home.transform.rotation);
					} else {
						Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle06", typeof(GameObject)));
					}
				}
				if (PlayerPrefs.GetInt ("V07A") == 2) {
					if (GameObject.FindGameObjectWithTag ("Home") != null) {
						GameObject home = GameObject.FindGameObjectWithTag ("Home");
						Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle07", typeof(GameObject)), new Vector3 (home.transform.position.x + 38, home.transform.position.y, home.transform.position.z - 12), home.transform.rotation);
					} else {
						Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle07", typeof(GameObject)));
					}
				}
				if (PlayerPrefs.GetInt ("V08A") == 2) {
					if (GameObject.FindGameObjectWithTag ("Home") != null) {
						GameObject home = GameObject.FindGameObjectWithTag ("Home");
						Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle08", typeof(GameObject)), new Vector3 (home.transform.position.x + 38, home.transform.position.y, home.transform.position.z - 12), home.transform.rotation);
					} else {
						Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle08", typeof(GameObject)));
					}
				}
				if (PlayerPrefs.GetInt ("V09A") == 2) {
					if (GameObject.FindGameObjectWithTag ("Home") != null) {
						GameObject home = GameObject.FindGameObjectWithTag ("Home");
						Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle09", typeof(GameObject)), new Vector3 (home.transform.position.x + 38, home.transform.position.y, home.transform.position.z - 12), home.transform.rotation);
					} else {
						Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle09", typeof(GameObject)));
					}
				}
				if (PlayerPrefs.GetInt ("V10A") == 2) {
					if (GameObject.FindGameObjectWithTag ("Home") != null) {
						GameObject home = GameObject.FindGameObjectWithTag ("Home");
						Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle10", typeof(GameObject)), new Vector3 (home.transform.position.x + 38, home.transform.position.y, home.transform.position.z - 5), home.transform.rotation);
					} else {
						Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle10", typeof(GameObject)));
					}
				}
			}
		}
	}
	}

	void Start()
	{
		LoadRaceMap.race = false;
		SpawnTraffic.MaxVehicle = maxTrafficCars;
	}
}
