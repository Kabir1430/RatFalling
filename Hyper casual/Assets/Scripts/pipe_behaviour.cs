using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_behaviour : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Get the current position of the object
        Vector3 currentPosition = transform.position;

        // Update the Z-axis position based on constant speed
        currentPosition.y += moveSpeed * Time.deltaTime;

        // Apply the new position to the object
        transform.position = currentPosition;
    }
}
