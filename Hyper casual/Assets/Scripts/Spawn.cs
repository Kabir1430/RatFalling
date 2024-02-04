using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn: MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject groundTile;
    Vector3 nextSpawnPoint;
    public void SpawnTile()
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;

    }
    // Update is called once per frame

   

}
