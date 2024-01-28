using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_pipe : MonoBehaviour
{

    public GameObject Pipeprefab;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "pipe")
        {
            Instantiate(Pipeprefab, new Vector3(0,0,0), Quaternion.identity);
           // Time.timeScale = 0f;
        }
    }
        private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "pipe")
        {
           Destroy(other.gameObject);
        }
    }
}
