using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    public GameObject FoodPrefab;
    public GameObject Moose; 

    void Update()
    {
        System.Random _random = new System.Random();

        float xStart = _random.Next(-22,22);
        float yStart = 0;
        float zStart = 14;

        float speed = 1.0f;

        Vector3 newPos = new Vector3(xStart, yStart, zStart);

        Instantiate(Moose, newPos, Quaternion.identity);

        for(int i = 0; i <= 18; i++){
            zStart -= 1;
            transform.position += newPos * speed;
            if(FoodPrefab.transform.position.z == Moose.transform.position.z && FoodPrefab.transform.position.x == Moose.transform.position.x){
                Destroy(Moose);
                Destroy(FoodPrefab);
        }

        }

        if(FoodPrefab.transform.position.z == Moose.transform.position.z && FoodPrefab.transform.position.x == Moose.transform.position.x){
            Destroy(Moose);
            Destroy(FoodPrefab);
        }


    }
}
