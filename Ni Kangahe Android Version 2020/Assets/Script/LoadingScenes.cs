using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LoadingScenes : MonoBehaviour
{
    public Sprite back;
    public GameObject switchlevels;
    public GameObject switchnextlevels;
    public GameObject wrong_pop_up_msg;
    public GameObject correct_pop_up_msg;
    public GameObject Score;
    public GameObject viewsettings;
    private bool isBeingHeld = false;

    public void OnChooselevelClick()
    {
        switchlevels.SetActive(true);
    }
    public void OnCloseClickButton ()
    {
        SceneManager.LoadScene("Home");
    }
    public void OnSettingsClick()
    {
        viewsettings.SetActive(true);
    }
    public void OnPrayClick()
    {
        SceneManager.LoadScene("Level-1-01");
    }
    public void OnClickBack()
    {
        SceneManager.LoadScene("Home");
    }
    public void OnQuitApplication()
    {
        Application.Quit();
    }
    private void Update()
    {
        if (isBeingHeld == true)
        {
            SceneManager.LoadScene("Home");
        }
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == back)
            {
                SceneManager.LoadScene("Home");
            }
        }
    }

    public void OncloseButtonpopup()
    {
        SceneManager.LoadScene("Home");
    }
    public void OnCorrectAnswerClick()
    {
        SceneManager.LoadScene("Level-1-02");
    }
    public void OncorectAnswer2Click()
    {
        SceneManager.LoadScene("Level-1-03");
    }
    public void OnCorrectAnswer3Click()
    {
        SceneManager.LoadScene("Level-1-04");
    }
    public void OnCorrectAnswer4Click()
    {
        SceneManager.LoadScene("Level-1-05");
    }
    public void OnCorrectAnswer5Click()
    {
        SceneManager.LoadScene("Level-2-01");
    }
    public void OnCorrectAnswer6Click()
    {
        SceneManager.LoadScene("Level-2-02");
    }
    public void OnCorrectAnswer7Click()
    {
        SceneManager.LoadScene("Level-2-03");
    }
    public void OnCorrectAnswer8Click()
    {
        SceneManager.LoadScene("Level-2-04");
    }
    public void OnCorrectAnswer9Click()
    {
        SceneManager.LoadScene("Level-2-05");
    }
    public void OnFinishLevelClick()
    {
        switchnextlevels.SetActive(false);
        switchlevels.SetActive(true);
        correct_pop_up_msg.SetActive(false);
    }
    public void SwitchNextLevelClick()
    {
        switchnextlevels.SetActive(true);
        switchlevels.SetActive(false);
        correct_pop_up_msg.SetActive(false);
    }
    public void switchtonextlevel()
    {
        switchnextlevels.SetActive(true);
        switchlevels.SetActive(false);
        correct_pop_up_msg.SetActive(false);
        Destroy(this.Score);

    }
    public void OnGameOver()
    {
        SceneManager.LoadScene("Home");
    }
    public void LoadLevelClick()
    {
        correct_pop_up_msg.SetActive(false);
        switchlevels.SetActive(true);
    }

    //###################################  LEVEL 2 ############################################
    public void OnScene1SubLoad()
    {
        SceneManager.LoadScene("Scene-2-01");
    }
    public void OnScene101SubLoad()
    {
        SceneManager.LoadScene("Scene-2-02");
    }
    public void OnScene102SubLoad()
    {
        SceneManager.LoadScene("Scene-2-03");
    }
    public void OnScene103SubLoad()
    {
        SceneManager.LoadScene("Scene-2-04");
    }
    public void OnScene104SubLoad()
    {
        SceneManager.LoadScene("Scene-2-05");
    }
    public void OnScene105SubLoad()
    {
        SceneManager.LoadScene("Scene-2-06");
    }
    public void OnScene106SubLoad()
    {
        SceneManager.LoadScene("Scene-2-07");
    }
    public void OnScene107SubLoad()
    {
        SceneManager.LoadScene("Scene-2-08");
    }
    public void OnScene108SubLoad()
    {
        SceneManager.LoadScene("Scene-2-09");
    }
    public void OnScene109SubLoad()
    {
        SceneManager.LoadScene("Scene-2-10");
    }

    //###################################  LEVEL 3 ############################################

    public void OnScene1DivLoad()
    {
        SceneManager.LoadScene("Scene-3-01");
    }
    public void OnScene301SubLoad()
    {
        SceneManager.LoadScene("Scene-3-02");
    }
    public void OnScene302SubLoad()
    {
        SceneManager.LoadScene("Scene-3-03");
    }
    public void OnScene303SubLoad()
    {
        SceneManager.LoadScene("Scene-3-04");
    }
    public void OnScene304SubLoad()
    {
        SceneManager.LoadScene("Scene-3-05");
    }
    public void OnScene305SubLoad()
    {
        SceneManager.LoadScene("Scene-3-06");
    }
    public void OnScene306SubLoad()
    {
        SceneManager.LoadScene("Scene-3-07");
    }
    public void OnScene307SubLoad()
    {
        SceneManager.LoadScene("Scene-3-08");
    }
    public void OnScene308SubLoad()
    {
        SceneManager.LoadScene("Scene-3-09");
    }
    public void OnScene309SubLoad()
    {
        SceneManager.LoadScene("Scene-3-10");
    }
    public void OnNexrClick()
    {
        switchlevels.SetActive(true);
        correct_pop_up_msg.SetActive(false);
    }
    public void OnSuccesslevel3Click()
    {
        switchlevels.SetActive(false);
        switchnextlevels.SetActive(true);
    }

    //###################################  LEVEL 3 ############################################

    public void OnScene1MultLoad()
    {
        SceneManager.LoadScene("Scene-4-01");
    }
    public void OnScene401DivLoad()
    {
        SceneManager.LoadScene("Scene-4-02");
    }
    public void OnScene402DivLoad()
    {
        SceneManager.LoadScene("Scene-4-03");
    }
    public void OnScene403DivLoad()
    {
        SceneManager.LoadScene("Scene-4-04");
    }
    public void OnScene404DivLoad()
    {
        SceneManager.LoadScene("Scene-4-05");
    }
    public void OnScene405DivLoad()
    {
        SceneManager.LoadScene("Scene-4-06");
    }
    public void OnScene406DivLoad()
    {
        SceneManager.LoadScene("Scene-4-07");
    }
    public void OnScene407DivLoad()
    {
        SceneManager.LoadScene("Scene-4-08");
    }
    public void OnScene408DivLoad()
    {
        SceneManager.LoadScene("Scene-4-09");
    }
    public void OnScene409DivLoad()
    {
        SceneManager.LoadScene("Scene-4-10");
    }
    public void OnNexLevel4Click()
    {
        switchlevels.SetActive(true);
        correct_pop_up_msg.SetActive(false);
    }
    public void OnSuccesslevel4Click()
    {
        switchlevels.SetActive(false);
        switchnextlevels.SetActive(true);
    }
}
