using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    // Speed at which the object moves along the Z-axis
    public float moveSpeed = 5f;

    void Update()
    {
        Vector3 currentPosition = transform.position;

        currentPosition.y += moveSpeed * Time.deltaTime;

        transform.position = currentPosition;

    
    }
}
