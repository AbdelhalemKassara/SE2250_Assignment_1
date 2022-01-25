using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithPlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject generator;

    private Dictionary<string, int> score = new Dictionary<string, int>();

    void Start()
    {   //adds the key value pair of each pickup object
        score.Add("Cylinder(Clone)", 1);
        score.Add("Cube(Clone)", 2);
        score.Add("Capsule(Clone)", 3);
    }
    void OnCollisionEnter(Collision col)
    {
        //if this object hit the player object and if this object is in the score dictionary
        if (GameObject.ReferenceEquals(col.gameObject, player) && score.ContainsKey(gameObject.name))
        {
            generator.GetComponent<Score>().updateScore(score[gameObject.name]);    //updates the score in the score class
            generator.GetComponent<GeneratePickUp>().decNumOfObjects1();            //decrements the number of pickup objects by one
            Destroy(gameObject);                                                    //removes this object from the game
        }
    }
}
