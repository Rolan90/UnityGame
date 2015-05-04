using UnityEngine;
using System.Collections;

/// <summary>
/// Moves this GameObject when the keys are pressed
/// </summary>

public class KeyMovement : MonoBehaviour {
	
	public float speed = 3.0f;
	public float angularSpeed = 3.0f;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.UpArrow)){
			transform.position += transform.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.DownArrow)){
			transform.position -= transform.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.LeftArrow)){
			transform.position -= transform.right * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.RightArrow)){
			transform.position += transform.right * speed * Time.deltaTime;
		}
		
		if (Input.GetKey (KeyCode.LeftArrow)){
			transform.Rotate(new Vector3(0, -angularSpeed * Time.deltaTime, 0));
		}
		if (Input.GetKey (KeyCode.RightArrow)){
			transform.Rotate(new Vector3(0, angularSpeed * Time.deltaTime, 0));
		}
	
		
		
	}
}
