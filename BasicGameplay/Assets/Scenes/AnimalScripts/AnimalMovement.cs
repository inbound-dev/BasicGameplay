using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    float speed = 5f;

    //public GameObject animal;

    void Update()
    {
      transform.Translate(Vector3.forward * Time.deltaTime * speed);

      if(transform.position.z <= (-18f)){
          Destroy(gameObject);
      }
    }
}