using UnityEngine;
using System.Collections;


/// <summary>
/// Manages the destruction of this gameObject, and the interactions
/// with other entites as this collides with them
/// </summary>
public class Flame : MonoBehaviour
{
	
	public float timeToDestroyFlame = 2.0f;

	// Use this for initialization
	void Start ()
	{
		Destroy (gameObject, timeToDestroyFlame);
	}
	

	void OnTriggerEnter(Collider other)
	{	
 		Application.LoadLevel(0);
    }
	
}
