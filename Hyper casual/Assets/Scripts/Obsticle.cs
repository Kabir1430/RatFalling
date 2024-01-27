using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsticle : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        Vector3 currentPosition = transform.position;

        currentPosition.z += Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.position = currentPosition;
    }
}
