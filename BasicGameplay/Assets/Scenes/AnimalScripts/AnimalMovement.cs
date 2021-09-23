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

        zStart -= 1;

        Vector3 newPos = new Vector3(xStart, yStart, zStart);

        Instantiate(Moose, newPos, Quaternion.identity);

        if(FoodPrefab.transform.position.z == Moose.transform.position.z && FoodPrefab.transform.position.x == Moose.transform.position.x){
            Moose.SetActive(false);
            FoodPrefab.SetActive(false);
        }
    }
}
