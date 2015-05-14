using UnityEngine;
using System.Collections;


/// <summary>
/// Deals damage to Damageables when they collide
/// </summary>
public class Damager : MonoBehaviour
{
	/// <summary>
	/// The amount of damage dealt to others.
	/// </summary>
	public float amount = 10.0f;
	
	
	void OnTriggerEnter (Collider other)
	{
		// Miro a quien hago daño
		Damageable damageable = other.gameObject.GetComponent<Damageable>();
		if (damageable == null)
		{
			return;
		}
		
		// Le paso "amount" puntos de daño
		damageable.ReceiveDamage(amount);
	}
	
}
