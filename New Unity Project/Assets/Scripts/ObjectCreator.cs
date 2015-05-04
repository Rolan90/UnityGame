using UnityEngine;
using System.Collections;

/// <summary>
/// Creates n copies of a given object
/// </summary>
public class ObjectCreator : MonoBehaviour {

	public int numberOfCopies = 10;
	
	public GameObject objectToClone;
	
	// Use this for initialization
	void Start () {
		for(int i=0;i<numberOfCopies;++i){
			Instantiate(objectToClone, new Vector3(i,i,i), Quaternion.identity);
			
			
		}	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
