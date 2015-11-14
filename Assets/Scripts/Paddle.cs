using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public float paddleSpeed = 1f;

	private Vector3 playerPos = new Vector3 (4f, 0.5f, 0);
	
	void Update () {
		float xPos = transform.position.x + (Input.GetAxis ("Horizontal") * this.paddleSpeed);
		playerPos = new Vector3 (Mathf.Clamp (xPos, -7f, 7f), 0.5f, 0);

		transform.position = playerPos;
	}
}
