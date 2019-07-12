using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float spawnRate = 1f;
    public GameObject hexagonPrefab;
    private float nextTimeToSPawn = 0f;

    void Update()
    {
        if(Time.time>=nextTimeToSPawn)
        {
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            nextTimeToSPawn = Time.time + 1f / spawnRate;
        }
    }
}
