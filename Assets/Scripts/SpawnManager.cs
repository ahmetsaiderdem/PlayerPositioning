using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal()
    {
        Vector3 randomPos = new Vector3(Random.Range(-20, 20), 0, 20);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], randomPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
