using UnityEngine;
using System.Collections;

public class TurretEnemy : MonoBehaviour {


	public GameObject objectToClone;
	
	public float muzzleSpeed = 50.0f;
	
	
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	
	void OnTriggerEnter(Collider other){
		GameObject bulletObject = Instantiate(objectToClone, transform.position + transform.forward, Quaternion.identity) as GameObject;
		ShootBullet(bulletObject);
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
