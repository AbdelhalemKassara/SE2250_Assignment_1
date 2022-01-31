using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardInputs : MonoBehaviour
{ 
    public float force = 7.0f;
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
            //push forward
            sphere.AddForce(0, 0, force, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //push backwards
            sphere.AddForce(0, 0, -force, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //push to the left
            sphere.AddForce(-force, 0, 0, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //push to the right
            sphere.AddForce(force, 0, 0, ForceMode.Force);
        }
    }
}
