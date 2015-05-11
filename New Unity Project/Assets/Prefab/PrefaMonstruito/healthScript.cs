using UnityEngine;
using System.Collections;

public class healthScript : MonoBehaviour {


	public float health;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (health < 0f) 
		{
			enmeyIAScript.isPlayerAlive = false;
			Destroy (gameObject);
		}

	
	}
}
