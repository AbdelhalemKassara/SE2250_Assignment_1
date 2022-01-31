using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObjectsAnimation : MonoBehaviour
{
    private double previousTime;

    private float distPerSec = 0.5f;
    private float timeSec = 1f;
    private float degPerSec = 150f;
    
    // Start is called before the first frame update
    void Start()
    {
        previousTime = Time.timeAsDouble;

        //converts them to distance and degrees, since Time.fixedDeltaTime is the rate that the fixedUpdate updates
        distPerSec *= Time.fixedDeltaTime;
        degPerSec *= Time.fixedDeltaTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //makes the object rotate
        transform.Rotate(degPerSec, degPerSec, degPerSec);

        //makes the object go up for one second then down for timeSec
        if ((int)(Time.timeAsDouble - previousTime) == timeSec)
        {
            distPerSec = -distPerSec;
            previousTime = Time.timeAsDouble;
        }
        transform.position = transform.position + new Vector3(0, distPerSec, 0);

    }
}
