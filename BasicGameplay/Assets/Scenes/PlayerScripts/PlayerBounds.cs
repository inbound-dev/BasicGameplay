using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour
{
    void Update(){

        // uses transform.positon.x to get the x position of the player and uses that to create the bounding box
        if(transform.position.x <= (-22)){
            transform.position = new Vector3(-22, 0, -13);
        }
        if(transform.position.x >= (22)){
            transform.position = new Vector3(22, 0, -13);
        }
    }
}
