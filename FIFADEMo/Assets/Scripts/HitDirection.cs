using UnityEngine;
using System.Collections;

public class HitDirection : MonoBehaviour {

	Vector3 elevation ; 
	Vector3 elevationAngle;
	int throwForce;
	HitCalculation anglebtw;
	float PointerAForce;
	void Start () {
	  anglebtw= GameObject.FindWithTag("Pointer").GetComponent <HitCalculation>();// as HitCalculation; 44444

		elevationAngle = new  Vector3(anglebtw.angleBetween,1,2);
		Debug.Log ("elevation angle"+ elevationAngle);
		elevation = Quaternion.Euler(elevationAngle) * transform.forward;
		throwForce = 1000;
	}


	void Update () {
	//	HitCalculation anglebtw= GetComponent ("HitCalculation") as HitCalculation; 

		Debug.Log ("angle between " + anglebtw.angleBetween);
		elevationAngle = new Vector3((anglebtw.angleBetween/5),5,10);

		if(Input.GetKeyDown(KeyCode.A)){
			//	this.rigidbody.AddForce(elevation * throwForce);
			rigidbody.velocity = transform.TransformDirection(elevationAngle * 0.3f);
		}
	
	}
}
