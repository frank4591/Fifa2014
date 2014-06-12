using UnityEngine;
using System.Collections;

public  class PointerMovement : MonoBehaviour {


	public GameObject originalPosition ;  	//specifies position of marker moving
	private Vector3 positionVector;					//used for assigning position of marker
	float positionX;						//x component of marker.
	float speedMovementPointer	;			//speed of movement

	void Start () {
		positionVector = new Vector3 (originalPosition.transform.position.x, originalPosition.transform.position.y, originalPosition.transform.position.z);
		speedMovementPointer = 0.5f;
	}



	void Update () {
	
		positionX =  + Mathf.PingPong (Time.time * speedMovementPointer, 0.5f) - 0.25f;
		positionVector = new Vector3 (positionX, originalPosition.transform.position.y, originalPosition.transform.position.z);
		originalPosition.transform.position = positionVector;
	}

	public Vector3 PointerPosition {
				get {
						return originalPosition.transform.position;
				}
				set{
			originalPosition.transform.position = value;
				}
				
			
		}
}
