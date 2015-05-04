using UnityEngine;
using System.Collections;


/// <summary>
/// Makes the transform look at the specified target.
/// </summary>
public class CameraLookAt : MonoBehaviour
{
	
	public GameObject target;
	
	// Update is called once per frame
	void Update ()
	{
		transform.LookAt(target.transform);
	}
}
