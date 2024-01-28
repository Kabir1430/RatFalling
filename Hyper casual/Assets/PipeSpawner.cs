using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    [Header("Position of spawn")]

    [SerializeField] public Transform SpawnPos;
    [SerializeField]
    public Vector3 nextSpawnPoint;


  [Header("Object")]

    [SerializeField] public GameObject objectToSpawn;

    [Header("Spawn Speed")]
    [SerializeField] public float spawnInterval = 5f;

    void Start()
    {
        StartCoroutine(SpawnObjectCoroutine());
    }

    IEnumerator SpawnObjectCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            GameObject temp = Instantiate(objectToSpawn, nextSpawnPoint, Quaternion.identity);
            nextSpawnPoint = temp.transform.GetChild(1).transform.position;
            

        }
    }
}
