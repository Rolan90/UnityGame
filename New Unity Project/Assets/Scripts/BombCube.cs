using UnityEngine;
using System.Collections;

public class BombCube : MonoBehaviour {

	public GameObject explosion;

	void OnTriggerEnter(Collider other){


		if (other.Equals ("Character")) {
			Collider[] around = Physics.OverlapSphere(gameObject.transform.position, 5);
			//Instantiate (explosion, transform.position, transform.rotation);
			foreach(Collider inExplosion in around)
			{        
				if(inExplosion.transform.tag == "Player")
				{
					Debug.Log("bomb has hit some enemy");
					//gameObject.GetComponent<healthScript>().characterHealth -= 110;
				}
			}
			Destroy (gameObject);
			Destroy (other);
		}
		Debug.Log("Has entrado en mi collider");

	}
}
