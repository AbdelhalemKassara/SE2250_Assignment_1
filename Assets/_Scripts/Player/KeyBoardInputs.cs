using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardInputs : MonoBehaviour
{ 
    private float force = 7.0f;
    private Rigidbody sphere;
    // Start is called before the first frame update
    void Start()
    {
        //gets the rigidbody from the game object
        sphere = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            sphere.AddForce(0, 0, force, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            sphere.AddForce(0, 0, -force, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            sphere.AddForce(-force, 0, 0, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            sphere.AddForce(force, 0, 0, ForceMode.Force);
        }
    }
}
