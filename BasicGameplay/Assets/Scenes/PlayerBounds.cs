using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour
{
    void Update()
    {

        float x = Input.GetAxis("Horizontal"); 

        Vector3 moveDirection = new Vector3(x, 0, 0);

        // try calling from position instead of trying to get player pos from getaxis
        if(x >= 22){
            transform.position = new Vector3(22, 0, 0);
        }
        if(x <= (-22)){
            transform.position = new Vector3((-22), 0, 0);

            System.Diagnostics.Debug.WriteLine("Here");
        }
    }
}
