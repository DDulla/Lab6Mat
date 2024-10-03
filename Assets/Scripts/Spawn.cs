using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject objectSpawn;
    public float spawnInterval = 2f;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnObject();
            timer = 0f;
        }
    }

    void SpawnObject()
    {
        Vector3 spawnPosition = Random.onUnitSphere * 2f; 
        spawnPosition.y = Mathf.Abs(spawnPosition.y); 
        Instantiate(objectSpawn, spawnPosition, Quaternion.identity);
    }
}