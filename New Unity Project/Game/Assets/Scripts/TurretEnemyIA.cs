using UnityEngine;
using System.Collections;

public class TurretEnemyIA: MonoBehaviour {
	

	public float flameSpeed = 10.0f;//speed of the attack
	public float distanceSeen = 20f;//when they begin to interact
	public float distanceToAttack = 15f;
	public Transform player;
	protected float playerDistance;//Comparison of position between enemy and player
	public float rotationSpeed = 10.0f;
	public float moveSpeed = 20.0f;
	public GameObject flame;//gameobject of the bullet
	public float shootTimer = 5.0f;
	//timers to control the attacks
	protected float timer = 0.0f;
	//function to add a force in the flame

	public void Shoot ()
	{
		if(flame == null){
			return;
		}
		GameObject bulletObject = Instantiate(flame, transform.position + transform.forward, Quaternion.identity) as GameObject;
		Rigidbody flameRigidbody = bulletObject.GetComponent<Rigidbody>();
		flameRigidbody.AddForce(transform.forward * flameSpeed);
		flame.transform.forward = transform.forward;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(player == null){
			return;
		}
		playerDistance = Vector3.Distance (player.position, transform.position);
		if (playerDistance < distanceSeen) {
			LookAtPlayer ();
			Chase();
			if (playerDistance < distanceToAttack) {
				if(timer>shootTimer){
					Shoot();
					timer=0.0f;
				}
				else{
					timer += Time.deltaTime;
				}
			}
		}
	}
	//look to the player
	void LookAtPlayer()
	{
		Quaternion rotation = Quaternion.LookRotation (player.position - transform.position); 
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * rotationSpeed);
		
	}
	//chase the player
	void Chase()
	{
		transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
	}

	
}



	
