using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer2 : MonoBehaviour {

	void Awake () {

		if (MultiPlayerCanvas.player2 == 0) {
			Instantiate (Resources.Load ("Multiplayer/Player2/P2Vehicle01", typeof(GameObject)), new Vector3(transform.position.x, -1.3f, transform.position.z),transform.rotation);
		}
		if (MultiPlayerCanvas.player2 == 1) {
			Instantiate (Resources.Load ("Multiplayer/Player2/P2Vehicle02", typeof(GameObject)), new Vector3(transform.position.x, -1.3f, transform.position.z),transform.rotation);
		}
		if (MultiPlayerCanvas.player2 == 2) {
			Instantiate (Resources.Load ("Multiplayer/Player2/P2Vehicle03", typeof(GameObject)), new Vector3(transform.position.x, -1.3f, transform.position.z),transform.rotation);
		}
		if (MultiPlayerCanvas.player2 == 3) {
			Instantiate (Resources.Load ("Multiplayer/Player2/P2Vehicle04", typeof(GameObject)), new Vector3(transform.position.x, -1.3f, transform.position.z),transform.rotation);
		}
		if (MultiPlayerCanvas.player2 == 4) {
			Instantiate (Resources.Load ("Multiplayer/Player2/P2Vehicle05", typeof(GameObject)), new Vector3(transform.position.x, -1.3f, transform.position.z),transform.rotation);
		}
		if (MultiPlayerCanvas.player2 == 5) {
			Instantiate (Resources.Load ("Multiplayer/Player2/P2Vehicle06", typeof(GameObject)), new Vector3(transform.position.x, -1.3f, transform.position.z),transform.rotation);
		}
		if (MultiPlayerCanvas.player2 == 6) {
			Instantiate (Resources.Load ("Multiplayer/Player2/P2Vehicle07", typeof(GameObject)), new Vector3(transform.position.x, -1.3f, transform.position.z),transform.rotation);
		}
		if (MultiPlayerCanvas.player2 == 7) {
			Instantiate (Resources.Load ("Multiplayer/Player2/P2Vehicle08", typeof(GameObject)), new Vector3(transform.position.x, -1.3f, transform.position.z),transform.rotation);
		}
		if (MultiPlayerCanvas.player2 == 8) {
			Instantiate (Resources.Load ("Multiplayer/Player2/P2Vehicle09", typeof(GameObject)), new Vector3(transform.position.x, -1.3f, transform.position.z),transform.rotation);
		}
		if (MultiPlayerCanvas.player2 == 9) {
			Instantiate (Resources.Load ("Multiplayer/Player2/P2Vehicle10", typeof(GameObject)), new Vector3(transform.position.x, -1.3f, transform.position.z),transform.rotation);
		}

	}
}
