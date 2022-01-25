using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObjectsAnimation : MonoBehaviour
{
    private double previousTime;
    private float dir = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        previousTime = Time.timeAsDouble;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //makes the object rotate
        transform.Rotate(3f, 3f, 3f);

        //makes the object go up for one second then down for one second
        if ((int)(Time.timeAsDouble - previousTime) == 1)
        {
            dir = -dir;
            previousTime = Time.timeAsDouble;
        }
        transform.position = transform.position + new Vector3(0, dir, 0);

    }
}
