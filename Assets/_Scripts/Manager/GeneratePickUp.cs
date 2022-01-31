using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePickUp : MonoBehaviour
{
    public GameObject square, cylinder, capsule, player;
    public int maxNumOfObjects;

    private int numOfObjects;
    private GameObject generate;

    // Start is called before the first frame update
    void Start()
    {
        generateObjects(maxNumOfObjects);
    }

    // Update is called once per frame
    void Update()
    {
        if(numOfObjects == 0)
        {
            gameObject.GetComponent<ResetGame>().resetGame();
            generateObjects(maxNumOfObjects);
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
            generate = Instantiate(square, generatePosition(), transform.rotation);//rotation of this object

        }
        else if(rand == 1)
        {
            generate = Instantiate(cylinder, generatePosition(), transform.rotation);

        }
        else if(rand == 2)
        {
            generate = Instantiate(capsule, generatePosition(), transform.rotation);

        }
        //this generates a random color
        //hueMin, hueMax, sturationMin, saturationMax, valueMin, valueMax
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
        numOfObjects = num;
    }
    Vector3 generatePosition()
    {
        //boundary of intersection on the x and z axis is 1 unit
        Vector3 halfExtends = new Vector3(0.5f, 0, 0.5f);
        Vector3 newPos;

        do {
            //the range of the box is -4.5 to 4.5 in both x and z and the max object size is 0.5, so -4.25 to 4.25 is the max position so the objects stay in the box
            newPos = new Vector3(Random.Range(-4.25f, 4.25f), 0.6f, Random.Range(-4.25f, 4.25f));
            Collider[] col = Physics.OverlapBox(newPos, halfExtends);//creates a square centered at the new location that is 1x1 and returns the colliders containing gameObjects that intersect
            
            //if this new position doesn't intersect with anything, exit
            if(col.Length == 0) {
                break;
            }
        } while(true);
        
        return newPos;
    }
}
