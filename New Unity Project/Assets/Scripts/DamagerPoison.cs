using UnityEngine;
using System.Collections;


/// <summary>
/// Adds DamagePoison to the entities it collides with.
/// </summary>
public class DamagerPoison : MonoBehaviour
{
	
	void OnTriggerEnter (Collider other)
	{
		DamagePoison poison = other.gameObject.AddComponent<DamagePoison>();
	}
	
}
