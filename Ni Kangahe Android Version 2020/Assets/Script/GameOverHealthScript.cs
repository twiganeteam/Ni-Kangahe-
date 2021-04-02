using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverHealthScript : MonoBehaviour
{
    void start()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        GameObject go = GameObject.Find("DragTouchScript");
        if (go == null)
        {
            Debug.LogError("Failed to find an object named HealthText");
            this.enabled = false;
            return;
            //GetComponent<Text>().text = "Ubonye: " + 0 + "Lives: " + 0;
        }
        else
        {
            GetComponent<Text>().text = " " +DragTouchScript.score;
        }
        GameStatus gs = go.GetComponent<GameStatus>();
        // GetComponent<Text>().text = "score: "+ DragTouchScript.score +  "Lives: " + DragTouchScript.numLives;
    }
}
