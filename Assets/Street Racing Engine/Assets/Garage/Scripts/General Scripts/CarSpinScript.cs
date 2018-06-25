using UnityEngine;
using System.Collections;

public class CarSpinScript : MonoBehaviour {

	private Vector3 yrot;
	public Transform campos;
	public Camera cam;
	public static float speed = 9;

	void Update()
	{
//		PlayerPrefs.DeleteAll ();
		yrot.y = (transform.rotation.y)*180 ;
		if (BodyBuyScript.bse == 1) {
			if (speed <= 8) {
			speed += Time.deltaTime*10;
				cam.orthographicSize = 18 - speed;
			}
			campos.position = Vector3.Lerp (campos.position, new Vector3 (0,1.5f,0), Time.deltaTime*3);
			if (Mathf.Abs (yrot.y) >= 5f) {
				transform.Rotate (Vector3.up * Time.deltaTime * 250);
			}
		} else if (BodyBuyScript.bse == 2) {

			if (speed <= 8) {
				speed += Time.deltaTime*10;
				cam.orthographicSize = 18 - speed;
			}
			campos.position = Vector3.Lerp (campos.position, new Vector3 (0,5,0), Time.deltaTime*3);

			if (Mathf.Abs (yrot.y) <= 179.95f) {
				transform.Rotate (Vector3.up * Time.deltaTime * 250);
			}
		} else if (BodyBuyScript.bse == 3) {

			if (speed <= 8) {
				speed += Time.deltaTime*10;
				cam.orthographicSize = 18 - speed;
			}
			campos.position = Vector3.Lerp (campos.position, new Vector3 (0,1.5f,0), Time.deltaTime*3);

			if (Mathf.Abs (yrot.y) <= 179.95f) {
				transform.Rotate (Vector3.up * Time.deltaTime * 250);
			}
		} else if (BodyBuyScript.bse == 0 ||BodyBuyScript.bse == 4) {
			
			if (speed <= 8 && BodyBuyScript.col == 0) {
				speed += Time.deltaTime*10;
				cam.orthographicSize = 10 + speed;
			}
			campos.position = Vector3.Lerp (campos.position, new Vector3 (0,6.2f,0), Time.deltaTime*3);

			transform.Rotate (Vector3.up * Time.deltaTime * 30);

		}
		}

	void OnMouseDrag()
	{
		float rotX = Input.GetAxis ("Mouse X") * 20 * Mathf.Deg2Rad;

		transform.Rotate (Vector3.up, -rotX*20);
	}
}