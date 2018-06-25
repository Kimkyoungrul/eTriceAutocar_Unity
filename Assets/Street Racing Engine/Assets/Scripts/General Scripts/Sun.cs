using UnityEngine;
using System.Collections;

public class Sun : MonoBehaviour {

	Light sun;
	public static float secondsInFullDay;
	[Range(0,1)]
	public static float currentTimeOfDay = 0.5f;
	[HideInInspector]
	public float timeMultiplier = 1f;
	public static bool day;
	public static bool night;

	float sunInitialIntensity;

	void Start() {
		sun = gameObject.GetComponent<Light> ();
		sunInitialIntensity = sun.intensity;
	}

	void Update() {
		UpdateSun();

		if (day) {
			currentTimeOfDay = 0.5f;
		} else if (night) {
			currentTimeOfDay = 0f;
		} else {
			currentTimeOfDay += (Time.deltaTime / secondsInFullDay) * timeMultiplier;
		}

		if (currentTimeOfDay >= 1) {
			currentTimeOfDay = 0;
		}
	}

	void UpdateSun() {
		sun.transform.localRotation = Quaternion.Euler((currentTimeOfDay * 360f) - 90, 45, 0);

		float intensityMultiplier = 1;
		if (currentTimeOfDay <= 0.23f || currentTimeOfDay >= 0.75f) {
			intensityMultiplier = 0;
		}
		else if (currentTimeOfDay <= 0.25f) {
			intensityMultiplier = Mathf.Clamp01((currentTimeOfDay - 0.23f) * (1 / 0.02f));
		}
		else if (currentTimeOfDay >= 0.73f) {
			intensityMultiplier = Mathf.Clamp01(1 - ((currentTimeOfDay - 0.73f) * (1 / 0.02f)));
		}

		sun.intensity = sunInitialIntensity * intensityMultiplier;
	}
}