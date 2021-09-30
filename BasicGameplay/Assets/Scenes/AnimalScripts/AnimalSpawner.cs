using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    public GameObject[] animalPrefab;

    public float xRange = 20f;
    public float zPos = 12.5f;

    private float startDelay = 2;
    private float spawnDelay = 1.5f;

    public float xPos;

    void Start(){
      InvokeRepeating("AnimalSpawning", startDelay, spawnDelay);
    }
    void AnimalSpawning(){
          int animalIndex = UnityEngine.Random.Range(0, animalPrefab.Length - 1);
          
          xPos = UnityEngine.Random.Range(-20, xRange);

          Vector3 spawnPos = new Vector3(xPos, 0, 12.5f);

          Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);
      }
}
