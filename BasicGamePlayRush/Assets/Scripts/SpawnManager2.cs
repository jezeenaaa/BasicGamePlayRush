using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager2 : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeZ = 5;
    private float spawnPosX = -100;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandonAnimal", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandonAnimal()
    {
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

}
