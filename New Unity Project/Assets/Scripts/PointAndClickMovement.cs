using UnityEngine;
using System.Collections;


/// <summary>
/// Moves an object when the user clicks on the screen
/// </summary>
public class PointAndClickMovement : MonoBehaviour
{
	/// <summary>
	/// Layers mask availables to be clicked.
	/// </summary>
	public LayerMask clickLayerMask;
	
	public Transform transformToMove;
	public Vector3 targetPoint;
	
	public float speed = 5.0f;
	
	
	void Awake ()
	{
		if (transformToMove != null)
		{
			targetPoint = transformToMove.position;
		}
	}
	

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 screenCoordinates = Input.mousePosition;
			Ray ray = Camera.main.ScreenPointToRay(screenCoordinates);
			
			Debug.DrawRay(ray.origin, ray.direction * 100.0f, Color.red, 0.5f);
			
			RaycastHit hit;
			if (Physics.Raycast(ray.origin, ray.direction, out hit, 100.0f, clickLayerMask.value))
			{
				Debug.DrawLine(ray.origin, hit.point, Color.yellow, 2.0f);
				Debug.DrawRay(hit.point, hit.normal * 2.0f, Color.cyan, 2.0f);
				
				targetPoint = hit.point;
			}
		}
		
		
		if (ShouldMove())
		{
			Vector3 direction = targetPoint - transformToMove.position;
			direction.y = 0;
			direction.Normalize();
			
			transformToMove.position += direction * speed * Time.deltaTime;
		}
	}
	
	
	protected bool ShouldMove ()
	{
		return transformToMove != null &&
			Vector3.Distance(targetPoint, transformToMove.position) > 0.5f;
		
	}
	
	
}
