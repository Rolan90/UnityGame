using UnityEngine;
using System.Collections;

public class enemy: MonoBehaviour {
	
	
	public GameObject objectToClone;//Objeto a crear
	public float flameSpeed = 10.0f;//velocidad de bala
	public Transform player;
	public float playerDistance;
	public float rotationDamping;
	public float moveSpeed;
	public static bool isPlayerAlive = true;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if (isPlayerAlive) {
			
			playerDistance = Vector3.Distance (player.position, transform.position);
			
			if (playerDistance < 15f) {
				lookAtPlayer ();
			}
			if (playerDistance < 12f) {
				if (playerDistance > 2f) {
					chase ();
				} else if (playerDistance < 2f) {
					attack ();
				}
			}
		}
	}
	
	void lookAtPlayer()
	{
		Quaternion rotation = Quaternion.LookRotation (player.position - transform.position); 
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * rotationDamping);
		
	}
	
	void chase()
	{
		transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
	}
	
	void attack()
	{
		public void Shoot (GameObject flameObject)
		{
			if(flameObject == null) return;
			Rigidbody flameRigidbody = flameObject.GetComponent<Rigidbody>();
			flameRigidbody.AddForce(transform.forward * flameSpeed);
			flameObject.transform.forward = transform.forward;
			
			
			
		}
		RaycastHit hit;
		if (Physics.Raycast (transform.position, transform.forward, out hit))
		{
			if(hit.collider.gameObject.tag == "Player")
			{
				hit.collider.gameObject.GetComponent<healthScript>().health -= 5f;
			}
		}
	}
	
}



	
