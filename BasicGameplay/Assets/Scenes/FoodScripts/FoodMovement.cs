using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMovement : MonoBehaviour
{
    public float speed = 40.0f;

    void Update()
    {
        // moves the food from the player at a defined speed 
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if(transform.position.z >= 25){
            Destroy(gameObject);
        }
    }
}
