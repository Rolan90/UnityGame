using UnityEngine;
using System.Collections;
/// <summary>
/// This component defines the movement of a gameobject.
/// </summary>
public class Trap : MonoBehaviour {
	//speed of the movement
	public float angularSpeed = 50.0f;
	//speed that is going to be used
	protected float speedUsed = 0.0f;
	//counter to turn the movement
	protected float turn = 0;
	//max spaced travelled
	public float maxTurn = 2.0f;
	//direction of the movement
	public bool positive = false;
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 0, speedUsed * Time.deltaTime));

		if(positive){
			turn += Time.deltaTime;
			speedUsed = -angularSpeed;
			if (turn >= maxTurn) {
				positive = false;
			}
		}
		else{
			turn -= Time.deltaTime;
			speedUsed = angularSpeed;
			if (turn <= -maxTurn) {
				positive = true;
			}
		}
	}
	void OnTriggerEnter(Collider other){
		Application.LoadLevel(0);
	}
}
