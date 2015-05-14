using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections;

/// <summary>
/// Invoke when someone enters
/// </summary>
public class Door : MonoBehaviour {

	public UnityEvent onEnter;

	protected void OnTriggerEnter(Collider other){
	
		onEnter.Invoke();
	}

}
