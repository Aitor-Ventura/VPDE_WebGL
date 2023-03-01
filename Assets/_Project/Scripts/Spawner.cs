using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefabs;
    public float spawnInterval = 3f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnPrefab), 0f, 1f);
    }

    private void SpawnPrefab()
    {
        var position = transform.position;
        
        Instantiate(
            prefabs[Random.Range(0, prefabs.Length-1)],
            new Vector3(
                Random.Range(position.x - 8, position.x + 8), 
                position.y, 
                position.z + 1),
            Quaternion.identity);
    }
}
