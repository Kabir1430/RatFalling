using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_pipe : MonoBehaviour
{

    public GameObject Pipeprefab;

    public GameObject parentObject;
    
    void Start()
    {
      /*  Transform[] children = parentObject.GetComponentsInChildren<Transform>();

        foreach (Transform child in children)
        {
            if (child != parentObject.transform)
            {
                child.parent = null;
            }
        }*/
    }
      
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
           Destroy(parentObject);

            Debug.Log(other);
        }
    }
}
