using UnityEngine;
using System.Collections;

public class HitDirection : MonoBehaviour {

	Vector3 elevation ; 
	public Vector3 elevationAngle;
	public float throwForce;
	HitCalculation anglebtw;
	float PointerAForce;
	public Vector2 size = new Vector2(80,20);
	public float barDisplay = 0.0f;
	void Start () {
	  anglebtw= GameObject.FindWithTag("Pointer").GetComponent <HitCalculation>();// as HitCalculation; 44444

		elevationAngle = new  Vector3(anglebtw.angleBetween,1,2);
		Debug.Log ("elevation angle"+ elevationAngle);
		elevation = Quaternion.Euler(elevationAngle) * transform.forward;
		throwForce = 5.0f;

	}
	public float spe = 0.25f;

	void Update () 
	{
	//	HitCalculation anglebtw= GetComponent ("HitCalculation") as HitCalculation; 

		Debug.Log ("angle between " + anglebtw.angleBetween);
		elevationAngle = new Vector3((anglebtw.angleBetween/15),5,5);
		if(Input.GetKey(KeyCode.Space))
		{
			//throwForce += 0.2f;
			spe += 0.005f;
			barDisplay+=0.005f;
		}
		if(Input.GetKeyDown(KeyCode.A)){
			rigidbody.AddForce(elevation * throwForce);
			rigidbody.velocity = transform.TransformDirection(elevationAngle * spe);
		}
	}
	void OnGUI()
	{
		GUI.BeginGroup (new Rect (6*Screen.width/24, 150, 80,20));
		GUI.Box (new Rect (0,0, 80,20),"FORCE");
		GUI.BeginGroup (new Rect (0, 0, barDisplay*1000, 20));
		GUI.Box (new Rect (0,0,80,20),"FORCE");
		GUI.EndGroup ();
		
		GUI.EndGroup ();
	}
}
