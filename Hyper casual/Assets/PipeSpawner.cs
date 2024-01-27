using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnInterval = 5f;

    void Start()
    {
        StartCoroutine(SpawnObjectCoroutine());
    }

    IEnumerator SpawnObjectCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        }
    }
}
