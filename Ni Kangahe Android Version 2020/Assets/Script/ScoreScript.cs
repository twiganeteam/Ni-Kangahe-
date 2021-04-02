using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoretxt;
    public GameObject switchlevels;
    void Start()
    {
        scoretxt.text = "1-4";
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Level-1-02" || SceneManager.GetActiveScene().name == "Level-1-03" || SceneManager.GetActiveScene().name == "Level-1-04"
            || SceneManager.GetActiveScene().name == "Level-1-05" || SceneManager.GetActiveScene().name == "Level-2-01" || SceneManager.GetActiveScene().name == "Level-2-02"
            || SceneManager.GetActiveScene().name == "Level-2-03" || SceneManager.GetActiveScene().name == "Level-2-04" || SceneManager.GetActiveScene().name == "Level-2-05"
            || SceneManager.GetActiveScene().name == "Level-1-01")
        {
            scoretxt.text = "1-4";
        }
        else if (SceneManager.GetActiveScene().name == "Scene-2-01" || SceneManager.GetActiveScene().name == "Scene-2-02" || SceneManager.GetActiveScene().name == "Scene-2-03"
            || SceneManager.GetActiveScene().name == "Scene-2-04" || SceneManager.GetActiveScene().name == "Scene-2-05" || SceneManager.GetActiveScene().name == "Scene-2-06"
            || SceneManager.GetActiveScene().name == "Scene-2-07" || SceneManager.GetActiveScene().name == "Scene-2-08" || SceneManager.GetActiveScene().name == "Scene-2-09"
            || SceneManager.GetActiveScene().name == "Scene-2-10")
        {
            scoretxt.text = "2-4";
        }
        else if (SceneManager.GetActiveScene().name == "Scene-3-01" || SceneManager.GetActiveScene().name == "Scene-3-02" || SceneManager.GetActiveScene().name == "Scene-3-03"
            || SceneManager.GetActiveScene().name == "Scene-3-04" || SceneManager.GetActiveScene().name == "Scene-3-05" || SceneManager.GetActiveScene().name == "Scene-3-06"
            || SceneManager.GetActiveScene().name == "Scene-3-07" || SceneManager.GetActiveScene().name == "Scene-3-08" || SceneManager.GetActiveScene().name == "Scene-3-09"
            || SceneManager.GetActiveScene().name == "Scene-3-10")
        {
            scoretxt.text = "3-4";
        }
        else if (SceneManager.GetActiveScene().name == "Scene-4-01" || SceneManager.GetActiveScene().name == "Scene-4-02" || SceneManager.GetActiveScene().name == "Scene-4-03"
            || SceneManager.GetActiveScene().name == "Scene-4-04" || SceneManager.GetActiveScene().name == "Scene-4-05" || SceneManager.GetActiveScene().name == "Scene-4-06"
            || SceneManager.GetActiveScene().name == "Scene-4-07" || SceneManager.GetActiveScene().name == "Scene-4-08" || SceneManager.GetActiveScene().name == "Scene-4-09"
            || SceneManager.GetActiveScene().name == "Scene-4-10")
        {
            scoretxt.text = "4-4";
        }
    }
}
