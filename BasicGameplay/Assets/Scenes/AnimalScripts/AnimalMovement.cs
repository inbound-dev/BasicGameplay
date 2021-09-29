using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMovement : MonoBehaviour
{    
    public static GameObject animal;

    public float speed = 0.1f;

    public float x = animal.GetComponent<AnimalSpawner>().xPos;
    public float y = animal.GetComponent<AnimalSpawner>().yPos;
    public float z = animal.GetComponent<AnimalSpawner>().zPos;

    void Update()
    {
        if(z >= 30){
            animal.SetActive(false);
        }
        if(z <= -40){
            animal.SetActive(false);
        } 
        
        z -= 1;

        Debug.Log(z);
        
        //updates the positon of the Animal every frame
        animal.transform.position = new Vector3(x, y, z) * speed;
    }
}
