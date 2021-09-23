using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject FoodPrefab;

    // Start is called before the first frame update
     void Start(){

        float xStart = 0;
        float yStart = 0;
        float zStart = -13;

        Vector3 StartPos = new Vector3(xStart, yStart, zStart);

        transform.position = StartPos;
    }

    //some floats that will be used later in the program
    public float speed = 0.1f;
    public float z = 0f;

    //gets the status of the input keys and converts them to object movement
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = 0;

        //Creates a new Vector3 object to contain the current positioning of the Shpere
        Vector3 moveDirection = new Vector3(x, z, y);

        //updates the positon of the Sphere every frame
        transform.position += moveDirection * speed;

        if(Input.GetKeyDown(KeyCode.Space)){
            //launch the projectile from the player
            Instantiate(FoodPrefab, transform.position, FoodPrefab.transform.rotation);
            
        }
    }
}
