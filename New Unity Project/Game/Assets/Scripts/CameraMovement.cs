using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public Transform target;
	public float distanceZ = 10.0f;
	public float distanceY = 10.0f;
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(target.position.x, target.position.y - distanceY, target.position.z - distanceZ);
	}
}
