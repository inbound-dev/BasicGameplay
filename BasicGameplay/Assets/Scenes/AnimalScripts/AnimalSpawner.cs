using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    public GameObject[] animalPrefab;

    GameObject animalClone;

    public float xRange = 20f;
    public float zPos = -24f;

    private float startDelay = 2;
    private float spawnDelay = 1.5f;

    public float xPos;

    void Start(){
      // runs the animal spawning function every 1.5 seconds 
      InvokeRepeating("AnimalSpawning", startDelay, spawnDelay);
    }

    // spawns an animal at a random x position
    void AnimalSpawning(){
          int animalIndex = UnityEngine.Random.Range(0, animalPrefab.Length - 1);
          
          xPos = UnityEngine.Random.Range(-20, xRange);

          Vector3 spawnPos = new Vector3(xPos, 0, zPos);

          animalClone = Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);
      }
}
