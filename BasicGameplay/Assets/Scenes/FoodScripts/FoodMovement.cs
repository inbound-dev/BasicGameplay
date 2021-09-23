using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMovement : MonoBehaviour
{
    public GameObject food;

    public float speed = 40.0f;

    void Update()
    {
        // moves the food from the player at a defined speed 
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if(transform.position.z >= 14){
            food.SetActive(false);
        }
    }
}
