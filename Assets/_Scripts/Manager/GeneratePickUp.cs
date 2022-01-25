using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePickUp : MonoBehaviour
{
    public GameObject square, cylinder, capsule, generate, player;
    public int maxNumOfObjects;

    private int numOfObjects;

    // Start is called before the first frame update
    void Start()
    {
        numOfObjects = 8;
        generateObjects(maxNumOfObjects);
    }

    // Update is called once per frame
    void Update()
    {
        if(numOfObjects == 0)
        {
            gameObject.GetComponent<ResetGame>().resetGame();
            generateObjects(maxNumOfObjects);
            numOfObjects = maxNumOfObjects;
        }
    }

    public void decNumOfObjects1()
    {
        numOfObjects--;
    }

    //this randomly generates either a square, cylinder, or capsule.
    void generateObject()
    {
        int rand = Random.Range(0, 3);

        if(rand == 0)
        {
            generate = Instantiate(square, generatePosition(), transform.rotation);

        }
        else if(rand == 1)
        {
            generate = Instantiate(cylinder, generatePosition(), transform.rotation);

        }
        else if(rand == 2)
        {
            generate = Instantiate(capsule, generatePosition(), transform.rotation);

        }
        generate.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        generate.GetComponent<CollisionWithPlayer>().player = player;
        generate.GetComponent<CollisionWithPlayer>().generator = gameObject;
    }

    void generateObjects(int num)
    {
        for (int i = 0; i < num; i++)
        {
            generateObject();
        }
    }
    Vector3 generatePosition()
    {
        //the range of the box is -4.5 to 4.5 in both x and z and the max object size is 0.5, so -4.25 to 4.25 is the max position so the objects stay in the box 
        return new Vector3(4.25f * Random.Range(-1.0f, 1.0f), 0.6f, 4.25f * Random.Range(-1.0f, 1.0f));
    }
}
