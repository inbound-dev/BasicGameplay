using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMovement : MonoBehaviour
{    
    public GameObject animal;

    public float speed = 0.1f;

    float x, y, z;

    void Start(){
        AnimalSpawner spawner = animal.GetComponent<AnimalSpawner>();
        z = -24f;
        x = spawner.xPos;
        y = 0;

    }

    void Update()
    {
        z -= 1;
        
        //updates the positon of the Animal every frame
        transform.position = new Vector3(x, y, z) * speed;
    }
}
