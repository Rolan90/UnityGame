using UnityEngine;
using System.Collections;

/// <summary>
/// Shows the current health whenever a damageable is damaged.
/// </summary>
public class DamageAlert : MonoBehaviour
{
	protected Damageable damageable;
	

	// Use this for initialization
	void Start ()
	{
		damageable = GetComponent<Damageable>();
		
		damageable.listeners += HealthChanged;
	}
	
	
	void OnDestroy ()
	{
		if (damageable != null)
		{
			damageable.listeners -= HealthChanged;
		}
	}
	
	
	
	void HealthChanged (Damageable damageable, float amount)
	{
		Debug.Log("Health = " + damageable.health + "/" + damageable.initialHealth);
	}
	
	
}
