using UnityEngine;
using System.Collections;

public class EnemyIAScript : MonoBehaviour {

	public Transform player;
	public float playerDistance;
	public float rotationDamping;
	public float moveSpeed;
	public static bool isPlayerAlive = true;
	public float distanceSeen = 20f;
	public float attackTimer = 1.0f;
	//timers to control the attacks
	protected float timer = 0.0f;
	public float distanceToAttack = 8.0f;
	//Use to keep the value of moveSpeed
	protected float auxSpeed;

	// Update is called once per frame
	void Update () {
		if (player == null) {
			return;
		}
		playerDistance = Vector3.Distance (player.position, transform.position);
		
		if (playerDistance < distanceSeen) {
			LookAtPlayer ();
			Chase ();
			if (playerDistance < distanceToAttack) {
				auxSpeed=moveSpeed;
				moveSpeed=0;
				if (timer > attackTimer) {
					Attack();
					timer = 0.0f;
				} 
				else {
					timer += Time.deltaTime;
				}
			}
			timer=0.0f;
			moveSpeed=auxSpeed;
		}
	}
	void LookAtPlayer()
	{
		Quaternion rotation = Quaternion.LookRotation (player.position - transform.position); 
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * rotationDamping);

	}

	void Chase()
	{
		transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
	}

	void Attack()
	{

	}

}