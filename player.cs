using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public float playerSpeed = 0.5f;

	// Use this for initialization
	void Start () {
		transform.position = new Vector3(-2, -3, 0);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime);

		transform.Translate (Vector3.up * Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime);
	}
}
