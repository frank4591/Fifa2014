using UnityEngine;
using System.Collections;

public class HitCalculation : MonoBehaviour {


	public Transform markerobject ;
	public Transform pointerObject;
	private Vector2 fromPosition;
	private Vector2 toPosition;
	public float angleBetween;	//angle between marker and pointer for the calculation of force


	PointerMovement pointer ;//= new PointerMovement ();
	void Start () {
		pointer = GetComponent ("PointerMovement") as PointerMovement; 
		angleBetween = 0f;
	}
	
	// Update is called once per frame
	void Update () {



		fromPosition = new Vector2 (markerobject.position.x, markerobject.position.z);
		toPosition = new Vector2 (pointer.originalPosition.transform.position.x, pointer.originalPosition.transform.position.z);
		angleBetween = Vector2.Angle (fromPosition, toPosition);
		if (markerobject.position.x > pointerObject.position.x) {
			angleBetween = - angleBetween;
				} 
	
	}
}
