using UnityEngine;
using System.Collections;

public class Boat : MonoBehaviour 
{

	public float Speed;
	public float TorqueSpeed;

	private float CannonAngle;
	public float CannonPower;
	
	public GameObject CannonBall;

	public Transform FirePoint;
	public Transform CannonPivot;

	private GameObject LastCannonBall;
	
	void Start () 
	{
	
	}

	void FixedUpdate () 
	{
		if (Input.GetKey (KeyCode.W))
		{
			rigidbody.AddRelativeForce (Vector3.forward * Speed);
		}
		if (Input.GetKey (KeyCode.S))
		{
			rigidbody.AddRelativeForce (Vector3.forward * -Speed);
		}
		//----//
		if (Input.GetKey (KeyCode.D))
		{
			rigidbody.AddRelativeTorque (Vector3.up * TorqueSpeed);
		}
		if (Input.GetKey (KeyCode.A))
		{
			rigidbody.AddRelativeTorque (Vector3.up * -TorqueSpeed);
		}

		//CannonPivot.transform.eulerAngles = new Vector3 (CannonAngle, transform.rotation.y, 0f);
		//CannonPivot.transform.rotation.x = CannonAngle;
	}

	public void SetAngle (float SettedAngle)
	{
		CannonAngle = SettedAngle * -30f;
	}

	public void SetPower (float SettedPower)
	{
		CannonPower = SettedPower * 200000f;
	}

	public void FireAction ()
	{
		LastCannonBall = Instantiate (CannonBall, new Vector3(FirePoint.position.x, FirePoint.position.y, FirePoint.position.z), FirePoint.transform.rotation) as GameObject;
		LastCannonBall.rigidbody.AddRelativeForce (Vector3.forward * CannonPower);
	}
}
