using UnityEngine;
using System.Collections;


/// <summary>
/// Grabs an object nearby when clicked, and drags it while
/// the button is pressed, and throws it when it is released
/// </summary>
public class MagneticGun : MonoBehaviour
{
	/// <summary>
	/// Force applied to the dragged object when the button is released
	/// </summary>
	public float shootForce = 500.0f;
	
	
	public float grabDistance = 3.0f;
	
	/// <summary>
	/// Layers mask availables to be clicked.
	/// </summary>
	public LayerMask clickLayerMask;
	
	/// <summary>
	/// The object we are dragging (if any)
	/// </summary>
	protected GameObject currentObject;
	
	protected RigidbodyConstraints previousConstraints;
	
	
	public Color selectedColor = Color.red;
	protected Color previusColor;
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown(1))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			
			RaycastHit hit;
			if (Physics.Raycast(ray.origin, ray.direction, out hit, grabDistance, clickLayerMask.value))
			{
				GrabObject(hit.transform.gameObject);
				
				//currentObject = hit.transform.gameObject;
				
				
				//currentObject.transform.parent = transform;
				
				
				// TODO ...
			}
		}
		else if (Input.GetMouseButton(1))
		{
			// TODO: Drag the object around	
		}
		else if  (Input.GetMouseButtonUp(1))
		{
			ShootCurrentObject();	
		}
	
	}
	/// <summary>
	/// Grabs the object.
	/// </summary>
	/// <param name='objectToGrab'>
	/// Object to grab.
	/// </param>
	public void GrabObject (GameObject objectToGrab){
		if(objectToGrab == null) return;
		currentObject = objectToGrab;
		
		currentObject.transform.parent=transform;
		//Freeze the rigibody to prevent it from moving
		if (currentObject.rigidbody != null)
		{
			//currentObject.rigidbody.useGravity = false;
			previousConstraints = currentObject.rigidbody.constraints;
			currentObject.rigidbody.constraints = RigidbodyConstraints.FreezePosition;
			
		}
		//Change de color of the object
		if(currentObject.renderer !=null){
			previusColor = currentObject.renderer.material.color;
			currentObject.renderer.material.color = selectedColor;
		}
		
	}
	
	protected void ShootCurrentObject ()
	{
		if (currentObject == null) return;
		
		if (currentObject.rigidbody != null)
		{
			// TODO ...
			currentObject.transform.parent = null;
			//currentObject.rigidbody.useGravity = true;
			currentObject.rigidbody.constraints = RigidbodyConstraints.None;
			currentObject.rigidbody.AddForce(transform.forward * shootForce, ForceMode.Impulse);
		}
		
		if(currentObject.renderer !=null){
			
			currentObject.renderer.material.color = previusColor;
		}
		
		currentObject = null;
	}
	
}
