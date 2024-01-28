using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demo : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;  // The target to follow (e.g., player)
    public float smoothSpeed = 0.125f;  // Adjust this to control the smoothness

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            // Optionally, you can make the camera look at the target
            transform.LookAt(target);
        }          
    }
}
