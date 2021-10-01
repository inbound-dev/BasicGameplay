using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBounds : MonoBehaviour
{
    public GameObject animal;

    void Start()
    {
        AnimalSpawner spawner = animal.GetComponent<AnimalSpawner>();
    }

    void Update()
    {
        float z = spawner.zPos;
        
        if(z > 2){
            Destroy(animal);
        }
    }
}
