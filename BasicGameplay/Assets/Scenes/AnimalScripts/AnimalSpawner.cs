using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    Public GameObject[] animalPrefab;

    void Update()
    {
      if(Input.GetKeyDown(KeyCode.S)) {
          //Random rand = new Random();
          int animalIndex = System.Random(0, animalPrefab.Length());
          Instantiate(animalPrefab[animalIndex], new Vector3(0,0,20), animalPrefab[animalIndex].transform.rotation);
        }
    }
}
