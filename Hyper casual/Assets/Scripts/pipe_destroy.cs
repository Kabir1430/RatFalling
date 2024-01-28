using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_destroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.tag == "pipedelete")
      {
        Destroy(other.gameObject);
      }
    }
}
