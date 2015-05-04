using UnityEngine;
using System.Collections;

public class DamagerPoison : MonoBehaviour {
	/// <summary>
	/// The amount of damage dealt to others
	/// </summary>
	public float amount = 10.0f;
	
	void OnTriggerEnter (Collider other){
		
		DamagePoison poison = other.gameObject.AddComponent<DamagePoison>();
			
	}
}
