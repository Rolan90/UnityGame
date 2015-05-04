using UnityEngine;
using System.Collections;

/// <summary>
/// Represents something that has health and can be damaged, and thus, die.
/// </summary>
public class Damageable : MonoBehaviour {
	
	public float initialHealth = 100.0f;
	protected float health = 100.0f;
	
	// Use this for initialization
	void Start () {
		
		health = initialHealth;
		
	}
	
	
	/*public float dps = 25.0f;
	
	void Update(){
		ReceiveDamage(dps * Time.deltaTime);
	}*/
	
	/// <summary>
	/// Receives "amount" points of damage, that are substracted from the current life
	/// <param name='amount'>
	/// Amount.
	/// </param>
	public void ReceiveDamage(float amount){
		
		if(health<= 0.0f){ 
			return;
		}
		
		health -= amount;
		health = Mathf.Clamp(health,0,initialHealth); 
			
		if(health<=0.0f){
			Destroy(gameObject);
		}
			
	}
	
}
