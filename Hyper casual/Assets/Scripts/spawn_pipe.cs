using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_pipe : MonoBehaviour
{

    public GameObject Pipeprefab;
    Vector3 nextspawnpos;

    void Spawnpipe()
    {
            GameObject temp = Instantiate(Pipeprefab,nextspawnpos, Quaternion.identity);
            nextspawnpos = temp.transform.GetChild(1).transform.position;
           //Time.timeScale = 0f;
          // Debug.Log("spawn");
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "pipe")
        {
         Spawnpipe();
         //Time.timeScale = 0f;
         //Destroy(other, 10f);
        }
    }

}
