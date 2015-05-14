using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;
/// <summary>
///Manages the activation of the traps 
/// </summary>
public class ActiveTrap : MonoBehaviour {
	public UnityEvent activateTrap;
	
	protected void OnTriggerEnter(Collider other){
		
		activateTrap.Invoke();
	}
		
}
