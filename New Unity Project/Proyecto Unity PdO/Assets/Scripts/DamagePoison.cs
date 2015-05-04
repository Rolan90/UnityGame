using UnityEngine;
using System.Collections;



/// <summary>
/// Deals dama per second for a while
/// </summary>
public class DamagePoison : MonoBehaviour {
	
	public float dps = 10.0f;
	
	public float seconds = 4.0f;
	protected Damageable damageable;
	// Use this for initialization
	void Start () {
		damageable = GetComponent<Damageable>();
		if(damageable == null){
			Destroy(this);
		}else{
			Destroy (this,seconds);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(damageable == null){
			
			Destroy(this);
			return;
		}
		damageable.ReceiveDamage(dps * Time.deltaTime);
	}
}
