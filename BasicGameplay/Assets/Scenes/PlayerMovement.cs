using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
     void Start(){

        float xStart = 8;
        float yStart = 5;
        float zStart = 0;

        Vector3 StartPos = new Vector3(xStart, zStart, yStart);

        transform.position = StartPos;
    }

    //some floats that will be used later in the program
    public float speed = 0.1f;
    public float z = 0f;

    //gets the status of the input keys and converts them to object movement
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");


        //Up and Down movement is currently broken (Issue: once "GetKey" has returned true, it will never return false)
        if(Input.GetKey("space")){
            z += 1;
        }
        if(Input.GetKey(KeyCode.LeftShift) && z <= 0){
            z -= 1;
        }

        //Creates a new Vector3 object to contain the current positioning of the Shpere
        Vector3 moveDirection = new Vector3(x, z, y);

        //updates the positon of the Sphere every frame
        transform.position += moveDirection * speed;
    }
}
