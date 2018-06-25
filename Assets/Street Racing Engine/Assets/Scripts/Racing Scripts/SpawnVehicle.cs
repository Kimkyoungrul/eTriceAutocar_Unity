using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVehicle : MonoBehaviour {

	void Awake () {
		if (!GameManager.mobileOn && !GameManager.playerOp) {
			if (PlayerPrefs.GetInt ("V01A") == 0) {
				PlayerPrefs.SetInt ("V01A", 2);
			}
			if (PlayerPrefs.GetInt ("V01A") == 2) {
				Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle01", typeof(GameObject)), new Vector3 (transform.position.x, -1.3f, transform.position.z), transform.rotation);
			}
			if (PlayerPrefs.GetInt ("V02A") == 2) {
				Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle02", typeof(GameObject)), new Vector3 (transform.position.x, -1.3f, transform.position.z), transform.rotation);
			}
			if (PlayerPrefs.GetInt ("V03A") == 2) {
				Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle03", typeof(GameObject)), new Vector3 (transform.position.x, -1.3f, transform.position.z), transform.rotation);
			}
			if (PlayerPrefs.GetInt ("V04A") == 2) {
				Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle04", typeof(GameObject)), new Vector3 (transform.position.x, -1.3f, transform.position.z), transform.rotation);
			}
			if (PlayerPrefs.GetInt ("V05A") == 2) {
				Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle05", typeof(GameObject)), new Vector3 (transform.position.x, -1.3f, transform.position.z), transform.rotation);
			}
			if (PlayerPrefs.GetInt ("V06A") == 2) {
				Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle06", typeof(GameObject)), new Vector3 (transform.position.x, -1.3f, transform.position.z), transform.rotation);
			}
			if (PlayerPrefs.GetInt ("V07A") == 2) {
				Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle07", typeof(GameObject)), new Vector3 (transform.position.x, -1.3f, transform.position.z), transform.rotation);
			}		
			if (PlayerPrefs.GetInt ("V08A") == 2) {
				Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle08", typeof(GameObject)), new Vector3 (transform.position.x, -1.3f, transform.position.z), transform.rotation);
			}
			if (PlayerPrefs.GetInt ("V09A") == 2) {
				Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle09", typeof(GameObject)), new Vector3 (transform.position.x, -1.3f, transform.position.z), transform.rotation);
			}
			if (PlayerPrefs.GetInt ("V10A") == 2) {
				Instantiate (Resources.Load ("VehicleRacingPrefs/Vehicle10", typeof(GameObject)), new Vector3 (transform.position.x, -1.3f, transform.position.z), transform.rotation);
			}

		} else {
			if (PlayerPrefs.GetInt ("V01A") == 0) {
				PlayerPrefs.SetInt ("V01A", 2);
			}
			if (PlayerPrefs.GetInt ("V01A") == 2) {
				Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle01", typeof(GameObject)), new Vector3 (transform.position.x, -1.3f, transform.position.z), transform.rotation);
			}
			if (PlayerPrefs.GetInt ("V02A") == 2) {
				Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle02", typeof(GameObject)), new Vector3 (transform.position.x, -1.3f, transform.position.z), transform.rotation);
			}
			if (PlayerPrefs.GetInt ("V03A") == 2) {
				Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle03", typeof(GameObject)), new Vector3 (transform.position.x, -1.3f, transform.position.z), transform.rotation);
			}
			if (PlayerPrefs.GetInt ("V04A") == 2) {
				Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle04", typeof(GameObject)), new Vector3 (transform.position.x, -1.3f, transform.position.z), transform.rotation);
			}
			if (PlayerPrefs.GetInt ("V05A") == 2) {
				Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle05", typeof(GameObject)), new Vector3 (transform.position.x, -1.3f, transform.position.z), transform.rotation);
			}
			if (PlayerPrefs.GetInt ("V06A") == 2) {
				Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle06", typeof(GameObject)), new Vector3 (transform.position.x, -1.3f, transform.position.z), transform.rotation);
			}
			if (PlayerPrefs.GetInt ("V07A") == 2) {
				Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle07", typeof(GameObject)), new Vector3 (transform.position.x, -1.3f, transform.position.z), transform.rotation);
			}		
			if (PlayerPrefs.GetInt ("V08A") == 2) {
				Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle08", typeof(GameObject)), new Vector3 (transform.position.x, -1.3f, transform.position.z), transform.rotation);
			}
			if (PlayerPrefs.GetInt ("V09A") == 2) {
				Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle09", typeof(GameObject)), new Vector3 (transform.position.x, -1.3f, transform.position.z), transform.rotation);
			}
			if (PlayerPrefs.GetInt ("V10A") == 2) {
				Instantiate (Resources.Load ("VehicleRacingPrefsMobile/Vehicle10", typeof(GameObject)), new Vector3 (transform.position.x, -1.3f, transform.position.z), transform.rotation);
			}
		}
	}
}