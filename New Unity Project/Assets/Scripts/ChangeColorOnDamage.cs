using UnityEngine;
using System.Collections;


/// <summary>
/// Changes the color of a gameObject when a damageable changes
/// its health
/// </summary>
public class ChangeColorOnDamage : MonoBehaviour
{
	public Color fullColor = Color.green;
	public Color emptyColor = Color.red;
	
	public Damageable damageable;
	
	
	// Use this for initialization
	void Start ()
	{
		if (damageable == null)
		{
			damageable = GetComponent<Damageable>();	
		}
		
		if (damageable != null)
		{
			damageable.listeners += UpdateColor;	
			
			UpdateColor(damageable, damageable.health);
		}
	}
	
	void OnDestroy ()
	{
		if (damageable != null)
		{
			damageable.listeners -= UpdateColor;	
		}
	}
	
	
	protected void UpdateColor (Damageable damageable, float amount)
	{
		if (GetComponent<Renderer>() != null)
		{
			float t = 1.0f - amount / damageable.initialHealth;
			GetComponent<Renderer>().material.color = Color.Lerp(fullColor, emptyColor, t);
		}
	}
	
	
}
