using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementclouds : MonoBehaviour
{
    //set speed of cloud movement 
    public float speed = 1f;


    // Update is called once per frame
    void Update()
    {
        //get current game object postition
        Vector3 temp = this.transform.position;
        if (temp.z <= 32)
        {
            //add to the x of our current postion
            temp.z += speed * Time.deltaTime;
            //setting current postion to temp
            this.transform.position = temp;
        }
        else
        {
            temp.z = -26f;
            this.transform.position = temp;
        }
    }
}
