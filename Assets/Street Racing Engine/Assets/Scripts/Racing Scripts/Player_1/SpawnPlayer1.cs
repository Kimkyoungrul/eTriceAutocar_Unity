using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer1 : MonoBehaviour {

	void Awake () {

		if (MultiPlayerCanvas.player1 == 0) {
			Instantiate (Resources.Load ("Multiplayer/Player1/P1Vehicle01", typeof(GameObject)), new Vector3(transform.position.x, -1.3f, transform.position.z),transform.rotation);
		}
		if (MultiPlayerCanvas.player1 == 1) {
			Instantiate (Resources.Load ("Multiplayer/Player1/P1Vehicle01", typeof(GameObject)), new Vector3(transform.position.x, -1.3f, transform.position.z),transform.rotation);
		}
		if (MultiPlayerCanvas.player1 == 2) {
			Instantiate (Resources.Load ("Multiplayer/Player1/P1Vehicle03", typeof(GameObject)), new Vector3(transform.position.x, -1.3f, transform.position.z),transform.rotation);
		}
		if (MultiPlayerCanvas.player1 == 3) {
			Instantiate (Resources.Load ("Multiplayer/Player1/P1Vehicle04", typeof(GameObject)), new Vector3(transform.position.x, -1.3f, transform.position.z),transform.rotation);
		}
		if (MultiPlayerCanvas.player1 == 4) {
			Instantiate (Resources.Load ("Multiplayer/Player1/P1Vehicle05", typeof(GameObject)), new Vector3(transform.position.x, -1.3f, transform.position.z),transform.rotation);
		}
		if (MultiPlayerCanvas.player1 == 5) {
			Instantiate (Resources.Load ("Multiplayer/Player1/P1Vehicle06", typeof(GameObject)), new Vector3(transform.position.x, -1.3f, transform.position.z),transform.rotation);
		}
		if (MultiPlayerCanvas.player1 == 6) {
			Instantiate (Resources.Load ("Multiplayer/Player1/P1Vehicle07", typeof(GameObject)), new Vector3(transform.position.x, -1.3f, transform.position.z),transform.rotation);
		}
		if (MultiPlayerCanvas.player1 == 7) {
			Instantiate (Resources.Load ("Multiplayer/Player1/P1Vehicle08", typeof(GameObject)), new Vector3(transform.position.x, -1.3f, transform.position.z),transform.rotation);
		}
		if (MultiPlayerCanvas.player1 == 8) {
			Instantiate (Resources.Load ("Multiplayer/Player1/P1Vehicle09", typeof(GameObject)), new Vector3(transform.position.x, -1.3f, transform.position.z),transform.rotation);
		}
		if (MultiPlayerCanvas.player1 == 9) {
			Instantiate (Resources.Load ("Multiplayer/Player1/P1Vehicle10", typeof(GameObject)), new Vector3(transform.position.x, -1.3f, transform.position.z),transform.rotation);
		}

	}
}
