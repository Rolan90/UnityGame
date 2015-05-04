using UnityEngine;
using System.Collections;


/// <summary>
/// Manages the destruction of this gameObject, and the interactions with
/// other entities as this collides with them.
/// </summary>

public class Bullet : MonoBehaviour {
	
	public float timeToDestroyBullet = 5.0f;
	
	
	// Use this for initialization
	void Start () {
			Destroy(gameObject, timeToDestroyBullet);
	}
	
	/*void OnTriggerEnter(Collider other){
		if(other.gameObject.tag.Equals("Walls")){
			Destroy(gameObject);
		}else{
			Destroy(other.gameObject);
		}
	}*/
	
	
}
