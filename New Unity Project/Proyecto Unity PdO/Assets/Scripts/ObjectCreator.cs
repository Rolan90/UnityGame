using UnityEngine;
using System.Collections;

/// <summary>
/// Creates n copies of a given object
/// </summary>
public class ObjectCreator : MonoBehaviour
{
	public GameObject objectToClone;
	
	public float muzzleSpeed = 50.0f;
	
	
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			// Create the object right in front of us
			GameObject bulletObject = Instantiate(objectToClone, transform.position + transform.forward, Quaternion.identity) as GameObject;
			ShootBullet(bulletObject);
		}
	}
	/// <summary>
	/// Applies a force to the bulletObject's rigidbody (if any)
	/// </summary>
	/// <param name='bulletObject'>
	/// Bullet object.
	/// </param>
	public void ShootBullet (GameObject bulletObject)
	{
		if(bulletObject == null) return;
		
		Rigidbody bulletRigidbody = bulletObject.rigidbody;
		bulletRigidbody.AddForce(transform.forward * muzzleSpeed);
		
		
		bulletObject.transform.forward = transform.forward;
	
		//Destroy(bulletObject, timeToDestroyBullet);
		
	}
	
	
	
}
