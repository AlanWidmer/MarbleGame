using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{
	public Transform transformToFollow;
	public Vector3 v3fFollowingOffset;
	
	// Called at the end of every frame
	void LateUpdate()
	{
		transform.position = transformToFollow.position + v3fFollowingOffset;
	}
}