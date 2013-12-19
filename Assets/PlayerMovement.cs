using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
	public float fSpeed = 100.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	void Update()
	{
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		
		float fMoveHorizontal = Input.GetAxis("Horizontal");
		float fMoveVertical = Input.GetAxis("Vertical");
		Vector3 v3fMoveForce = new Vector3(fMoveHorizontal, 0.0f, fMoveVertical) * Time.fixedDeltaTime * fSpeed;
// 		print ("v3fMoveForce = " + v3fMoveForce);
		rigidbody.AddForce(v3fMoveForce);
	}
}
