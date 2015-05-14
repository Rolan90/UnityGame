using UnityEngine;
using System.Collections;

/// <summary>
/// Moves this GameObject when the keys are pressed
/// </summary>

public class KeyMovement : MonoBehaviour {
	
	public float speed = 3.0f;
	public float angularSpeed = 100.0f;
	public float posz=0f;
	public float smooth = 0.1f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)){
			transform.position += transform.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.S)){
			transform.position -= transform.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.A)){
			transform.position -= transform.right * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.D)){
			transform.position += transform.right * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.Q)){
			transform.Rotate(new Vector3(0, -angularSpeed * Time.deltaTime, 0));
		}
		if (Input.GetKey (KeyCode.E)){
			transform.Rotate(new Vector3(0, angularSpeed * Time.deltaTime, 0));
		}
		/*
		Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (ray, hit)) {
			transform.LookAt(hit.point);
			transform.position = Vector3.Lerp(transform.position,hit.point,smooth);
		}
		transform.rotation = Quaternion.Euler (0.0f, 0.0f, posz);*/


	
		
		
	}
}
