using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    //Save info into something persist( User Prefabs, a save file)
    //Static class data. This is PROBABLY not the preference becouse
    // it is easy to goof up as a begenner
    //
    //DontDestroyOnload

    public Sprite banana1;
    public Sprite banana2;
    public Sprite banana3;
    //
    //
    public static bool locked;
    public static bool locked2;
    public static bool locked3;
    static public int numLives = 3;
    static public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch1 = Input.GetTouch(0);
            switch (touch1.phase)
            {
                case TouchPhase.Ended:
                    score = score + 3;
                    numLives = numLives - 1;
                    break;
            }
        }

    }
    void OnDestroy()
    {
        Debug.Log("GameStatus was Destroyed");
        //PlayerPrefs.SetInt("Lives", numLives);
    }
}
