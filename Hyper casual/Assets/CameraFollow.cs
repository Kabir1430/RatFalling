using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset = new Vector3(0f, 2f, -5f);
    public float rotationSpeed = 5f;

    private Vector3 velocity = Vector3.zero;
    private float rotationVelocity = 0f;

    void LateUpdate()
    {
        if (target != null)
        {
            // Calculate the desired position by adding the offset to the target's position
            Vector3 desiredPosition = target.position + offset;

            // Smoothly interpolate between the current and desired positions
            transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed);

            // Set the desired rotation angles
            float desiredRotationX = 90f;  // Fixed X rotation
            float desiredRotationY = target.eulerAngles.y;

            // Smoothly interpolate between the current and desired rotation angles
            float smoothedRotationY = Mathf.SmoothDampAngle(transform.eulerAngles.y, desiredRotationY, ref rotationVelocity, rotationSpeed);

            // Update the camera's rotation
            transform.rotation = Quaternion.Euler(desiredRotationX, smoothedRotationY, 0f);
        }
    }
}
