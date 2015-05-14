using UnityEngine;
using System.Collections;


/// <summary>
/// This component represents something that has "health" and
/// can be damaged, and thus, destroyed.
/// </summary>
public class Damageable : MonoBehaviour
{
	
	public float initialHealth = 100.0f;
	
	protected float mHealth = 100.0f;
	public float health
	{
		get { return mHealth; }
		protected set
		{
			if (mHealth == value)		return;
			
			mHealth = value;
			mHealth = Mathf.Clamp(health, 0.0f, initialHealth);
			
			if (listeners != null)
			{
				listeners(this, health);
			}
		}
	}
	
	
	public bool isAlive
	{
		get { return health > 0; }	
	}
	
	
	
	/// <summary>
	/// Declaration of the signature of the methods that will be called
	/// through listeners (delegates)
	/// 
	/// First parameter is the Damageable which health changed
	/// Second parameter is the current health of "damageable"
	/// </summary>
	public delegate void OnHealthChanged (Damageable damageable, float amount);
	/// <summary>
	/// Notifies method with same signature as OnHealthChanged, whenever
	/// the health of this Damageable changes
	/// </summary>
	public OnHealthChanged listeners;
	
	
	
	
	
	
	
	// Use this for initialization
	void Start ()
	{
		health = initialHealth;
	}

	
	
	/// <summary>
	/// Receives "amount" points of damage, that are substracted
	/// from the current health.
	///  If the health drops below 0, the gameObject is destroyed
	/// </summary>
	/// <param name='amount'>
	/// Amount.
	/// </param>
	public void ReceiveDamage (float amount)
	{
		if (health <= 0.0f)
		{
			return;
		}
		
		health -= amount;
		
		if (health <= 0.0f)
		{
			Destroy(gameObject);
		}
	}
	
}
