using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumyBeans : MonoBehaviour
{
    public float force;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            print("Down");
            rb.AddForce(0, 50, 0, ForceMode.Impulse);
        }

    }
}
