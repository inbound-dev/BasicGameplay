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
    }

    void Update()
    {
        AnimalSpawner spawner = animal.GetComponent<AnimalSpawner>();
        z = spawner.zPos; 

        // checks if z is less than -12.5
        if(z <= (-12.5)){
            animal.SetActive(false);
        } 

        // checks if z is greater than -12.5
        else if(z > (-12.5))
        {
            z -= 1;

            Debug.Log("z is greater than -12.5");

            //updates the positon of the Animal every frame if z !> 2 
            transform.position = new Vector3(x, 0, z) * speed;
        }
    }
}