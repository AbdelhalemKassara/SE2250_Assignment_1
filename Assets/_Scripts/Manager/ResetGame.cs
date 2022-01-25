using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGame : MonoBehaviour
{
    public GameObject player;

    public void resetGame()
    {
        GamePauser(2);
        player.transform.position = new Vector3(0.0f, 0.5f, 0.0f);
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        gameObject.GetComponent<Score>().resetScore();
    }
    public void GamePauser(float pauseTime)
    {
        float t = Time.realtimeSinceStartup + pauseTime;

        while(Time.realtimeSinceStartup < t){
            Time.timeScale = 0;
        }
        Time.timeScale = 1;
    }
}
