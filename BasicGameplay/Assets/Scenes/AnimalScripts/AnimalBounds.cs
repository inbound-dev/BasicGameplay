using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBounds : MonoBehaviour
{
    public static GameObject animal;

    void Update()
    {
        if(transform.position.z >= 10){
            animal.SetActive(false);
        }
        if(transform.position.z <= -10){
            animal.SetActive(false);
        }
    }
}
