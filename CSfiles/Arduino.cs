using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Arduino : MonoBehaviour
{
	public float speed = 5f;
    Vector3 temp;
    float yaw;
    Vector3 currentRotation;
    float zoom;

    public float rotationSmoothTime = 1.2f;
	Vector3 rotationSmoothVelocity;

	void Start()
	{

	}

	void Update()
	{
        yaw-= Input.GetAxis("Mouse X") * 10;
		temp = transform.localScale;
        zoom = Input.GetAxis("Mouse Y");
        temp.x += zoom;
        temp.y += zoom;
        temp.z += zoom;
        transform.localScale = temp;
        currentRotation = Vector3.SmoothDamp (currentRotation, new Vector3 (pitch, yaw), ref rotationSmoothVelocity, rotationSmoothTime);
	}
}
