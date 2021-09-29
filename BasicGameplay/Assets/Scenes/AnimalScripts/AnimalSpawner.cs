using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    public GameObject[] animalPrefab;

    public float xRange = 20f;
    public float zPos = 12.5f;

    void Update()
    {

      if(Input.GetKeyDown(KeyCode.S)){
          int animalIndex = UnityEngine.Random.Range(0, animalPrefab.Length - 1);

          Vector3 spawnPos = new Vector3(UnityEngine.Random.Range(-20, xRange), 0, zPos);

          animalPrefab[animalIndex].transform.Rotate(0f, 180f, 0f);

          Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);

          animalPrefab[animalIndex].SetActive(true);

          //Debug.Log(animalPrefab.Length);
        }
    }
}
