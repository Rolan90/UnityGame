using UnityEngine;
using System.Collections;



/// <summary>
/// Deals damage per second for a while.
/// </summary>
public class DamagePoison : MonoBehaviour
{
	public float dps = 10.0f;
	
	public float seconds = 4.0f;
	protected float currentSeconds = 0.0f;
	protected int previousSeconds = 0;
	
	protected Damageable damageable;
	
	
	// Use this for initialization
	void Start ()
	{
		damageable = GetComponent<Damageable>();
		if (damageable == null)
		{
			Destroy(this);	
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (damageable == null || currentSeconds > seconds)
		{
			Destroy(this);
			return;
		}
		
		
		if (Mathf.FloorToInt(currentSeconds) - previousSeconds > 0)
		{
			damageable.ReceiveDamage(dps);
		}
		
		previousSeconds = Mathf.FloorToInt(currentSeconds);
		currentSeconds += Time.deltaTime;
	}
	
}
