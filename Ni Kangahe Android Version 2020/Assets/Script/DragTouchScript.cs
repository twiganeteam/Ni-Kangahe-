using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DragTouchScript : MonoBehaviour
{
    [SerializeField]
    private Transform bearplace;
    private Vector2 initialPosition;
    private Vector2 mousePosition;
    private float deltaX, deltaY;
    public static bool locked;
    public static bool locked2;
    public static bool locked3;

    // HEALTH BAR SCRIPT
    public float currHp;
    public float TotalHp;
    public float CurrentHp;
    public GameObject bar;

    //SPRITE NU

    public Sprite banana1;
    public Sprite banana2;
    public Sprite banana3;
    public Sprite answer1;
    public Sprite answer2;
    public Sprite answer3;
    public Sprite answer11;
    public Sprite answer12;
    public Sprite answer13;
    public Sprite orange1;
    public Sprite orange2;
    public Sprite orange3;
    public Sprite orange11;
    public Sprite orange12;
    public Sprite orange13;

    public Sprite cup1;
    public Sprite cup2;
    public Sprite cup3;

    public Sprite fork1;
    public Sprite fork2;
    public Sprite fork3;

    public Sprite b08;
    public Sprite b09;
    public Sprite b10;

    public Sprite answerbtn1;
    public Sprite answerbtn2;
    public Sprite answerbtn3;

    public Sprite answer111;
    public Sprite answer121;
    public Sprite answer131;



    public GameObject wrong_pop_up_msg;
    public GameObject correct_pop_up_msg;
    public GameObject switchlevels;
    public GameObject game_over;

    static public int numLives = 3;
    static public int score = 0;
    void Start()
    {
        CurrentHp = TotalHp;
        initialPosition = transform.position;
        game_over.SetActive(false);
        if(SceneManager.GetActiveScene().name == "Level-1-01")
        {
            numLives = 3;
            score = 0;
        }
        else if (SceneManager.GetActiveScene().name == "Scene-2-01")
        {
            numLives = 3;
            score = 0;
        }
        else if (SceneManager.GetActiveScene().name == "Scene-3-01")
        {
            numLives = 3;
            score = 0;
        }
        else if (SceneManager.GetActiveScene().name == "Scene-4-01")
        {
            numLives = 3;
            score = 0;
        }
    }
    void Update()
    {
        if (numLives <= 0)
        {
            game_over.SetActive(true);
        }
        else { 
        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana1 && SceneManager.GetActiveScene().name == "Level-1-01")
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch1 = Input.GetTouch(0);
                Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                switch (touch1.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                        {
                            deltaX = touchPos.x - transform.position.x;
                            deltaY = touchPos.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana1)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;

                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                score = score + 3;
                                correct_pop_up_msg.SetActive(true);
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        break;
                }
            }
        }
        //Sprite banana 2

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana2 && SceneManager.GetActiveScene().name == "Level-1-01")
        {
            if (Input.touchCount > 0 && !locked3)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana2)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked3 = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3) && numLives > 0)
                            {
                                numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        break;
                }
            }
        }

        //Sprite banana 3

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana3 && SceneManager.GetActiveScene().name == "Level-1-01")
        {
            if (Input.touchCount > 0 && !locked2)
            {
                Touch touch2 = Input.GetTouch(0);
                Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                switch (touch2.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                        {
                            deltaX = touchPos2.x - transform.position.x;
                            deltaY = touchPos2.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana3)
                        {

                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked2 = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                            {
                                numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        break;
                }
            }
        }

        //LEVEL 1 EXERCISE 2#########################################################################################################################

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer1 && SceneManager.GetActiveScene().name == "Level-1-02")
        {
            if (Input.touchCount > 0 && !locked2)
            {
                Touch touch2 = Input.GetTouch(0);
                Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                switch (touch2.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                        {
                            deltaX = touchPos2.x - transform.position.x;
                            deltaY = touchPos2.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer1)
                        {

                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked2 = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                            {
                                numLives = numLives - 1;
                                GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        break;
                }
            }
        }

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer2 && SceneManager.GetActiveScene().name == "Level-1-02")
        {
            if (Input.touchCount > 0 && !locked2)
            {
                Touch touch2 = Input.GetTouch(0);
                Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                switch (touch2.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                        {
                            deltaX = touchPos2.x - transform.position.x;
                            deltaY = touchPos2.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer2)
                        {

                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked2 = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                score = score + 3;
                                correct_pop_up_msg.SetActive(true);
                                GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                GameObject.DontDestroyOnLoad(this.gameObject);

                            }
                        break;
                }
            }
        }
        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer3 && SceneManager.GetActiveScene().name == "Level-1-02")
        {
                
            if (Input.touchCount > 0 && !locked3)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer3)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked3 = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3) && numLives > 0)
                            {
                                numLives = numLives - 1;
                                GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                        break;
                }
            }
        }

        //START LEVEL 1 EXCERSISE 3 #################################################### FORK  ############################################################################

        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer11 && SceneManager.GetActiveScene().name == "Level-1-03")
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch1 = Input.GetTouch(0);
                Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                switch (touch1.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                        {
                            deltaX = touchPos.x - transform.position.x;
                            deltaY = touchPos.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer11)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                    score = score + 3;
                                correct_pop_up_msg.SetActive(true);
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                        }
                        break;
                }
            }
        }
        //Sprite banana 2

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer12 && SceneManager.GetActiveScene().name == "Level-1-03")
        {
            if (Input.touchCount > 0 && !locked3)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer12)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked3 = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3) && numLives > 0)
                            {
                                    numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                        }
                        break;
                }
            }
        }

        //Sprite banana 3

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer13 && SceneManager.GetActiveScene().name == "Level-1-03")
        {
            if (Input.touchCount > 0 && !locked2)
            {
                Touch touch2 = Input.GetTouch(0);
                Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                switch (touch2.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                        {
                            deltaX = touchPos2.x - transform.position.x;
                            deltaY = touchPos2.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer13)
                        {

                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked2 = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                            {
                                    numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                        }
                        break;
                }
            }
        }

        //START LEVEL 1 EXCERSISE 4 #################################################### FORK  ############################################################################

        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange1 && SceneManager.GetActiveScene().name == "Level-1-04")
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch1 = Input.GetTouch(0);
                Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                switch (touch1.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                        {
                            deltaX = touchPos.x - transform.position.x;
                            deltaY = touchPos.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange1)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && numLives > 0)
                            {
                                    numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                        }
                        break;
                }
            }
        }
        //Sprite banana 2

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange2 && SceneManager.GetActiveScene().name == "Level-1-04")
        {
            if (Input.touchCount > 0 && !locked3)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange2)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked3 = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                    score = score + 3;
                                correct_pop_up_msg.SetActive(true);
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                        }
                        break;
                }
            }
        }

        //Sprite orange 3

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange3 && SceneManager.GetActiveScene().name == "Level-1-04")
        {
            if (Input.touchCount > 0 && !locked2)
            {
                Touch touch2 = Input.GetTouch(0);
                Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                switch (touch2.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                        {
                            deltaX = touchPos2.x - transform.position.x;
                            deltaY = touchPos2.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange3)
                        {

                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked2 = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                            {
                                    numLives = numLives - 1;
                                }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                        }
                        break;
                }
            }
        }

        //START LEVEL 1 EXCERSISE 5 #################################################### FORK  ############################################################################

        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange11 && SceneManager.GetActiveScene().name == "Level-1-05")
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch1 = Input.GetTouch(0);
                Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                switch (touch1.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                        {
                            deltaX = touchPos.x - transform.position.x;
                            deltaY = touchPos.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange11)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && numLives > 0)
                            {
                                    numLives = numLives - 1;
                                }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                        }
                        break;
                }
            }
        }
        //Sprite banana 2

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange12 && SceneManager.GetActiveScene().name == "Level-1-05")
        {
            if (Input.touchCount > 0 && !locked3)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange12)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked3 = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3) && numLives > 0)
                            {
                                    numLives = numLives - 1;
                                }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                        }
                        break;
                }
            }
        }

        //Sprite orange 3

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange13 && SceneManager.GetActiveScene().name == "Level-1-05")
        {
            if (Input.touchCount > 0 && !locked2)
            {
                Touch touch2 = Input.GetTouch(0);
                Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                switch (touch2.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                        {
                            deltaX = touchPos2.x - transform.position.x;
                            deltaY = touchPos2.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange13)
                        {

                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked2 = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                    score = score + 3;
                                correct_pop_up_msg.SetActive(true);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                        }
                        break;
                }
            }
        }
        //START LEVEL 2 EXCERSISE 6 #################################################### CUP  ############################################################################

        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == cup1 && SceneManager.GetActiveScene().name == "Level-2-01")
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch1 = Input.GetTouch(0);
                Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                switch (touch1.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                        {
                            deltaX = touchPos.x - transform.position.x;
                            deltaY = touchPos.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == cup1)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                    score = score + 3;
                                correct_pop_up_msg.SetActive(true);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                        }
                        break;
                }
            }
        }
        //Sprite banana 2

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == cup2 && SceneManager.GetActiveScene().name == "Level-2-01")
        {
            if (Input.touchCount > 0 && !locked3)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == cup2)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked3 = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3) && numLives > 0)
                            {
                                    numLives = numLives - 1;
                                }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                        }
                        break;
                }
            }
        }

        //Sprite cup 3

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == cup3 && SceneManager.GetActiveScene().name == "Level-2-01")
        {
            if (Input.touchCount > 0 && !locked2)
            {
                Touch touch2 = Input.GetTouch(0);
                Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                switch (touch2.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                        {
                            deltaX = touchPos2.x - transform.position.x;
                            deltaY = touchPos2.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == cup3)
                        {

                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked2 = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                            {
                                    numLives = numLives - 1;
                                }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                        }
                        break;
                }
            }
        }

        //START LEVEL 2 EXCERSISE 2 #################################################### FORK  ############################################################################

        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == fork1 && SceneManager.GetActiveScene().name == "Level-2-02")
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch1 = Input.GetTouch(0);
                Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                switch (touch1.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                        {
                            deltaX = touchPos.x - transform.position.x;
                            deltaY = touchPos.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == fork1)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && numLives > 0)
                            {
                                    numLives = numLives - 1;
                                }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                        }
                        break;
                }
            }
        }
        //Sprite banana 2

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == fork2 && SceneManager.GetActiveScene().name == "Level-2-02")
        {
            if (Input.touchCount > 0 && !locked3)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == fork2)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked3 = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                    score = score + 3;
                                correct_pop_up_msg.SetActive(true);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                        }
                        break;
                }
            }
        }

        //Sprite cup 3

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == fork3 && SceneManager.GetActiveScene().name == "Level-2-02")
        {
            if (Input.touchCount > 0 && !locked2)
            {
                Touch touch2 = Input.GetTouch(0);
                Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                switch (touch2.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                        {
                            deltaX = touchPos2.x - transform.position.x;
                            deltaY = touchPos2.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == fork3)
                        {

                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked2 = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                            {
                                    numLives = numLives - 1;
                                }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                        }
                        break;
                }
            }
        }

        //START LEVEL 2 EXCERSISE 3 #################################################### FORK  ############################################################################

        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == b08 && SceneManager.GetActiveScene().name == "Level-2-03")
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch111 = Input.GetTouch(0);
                Vector2 touchPos111 = Camera.main.ScreenToWorldPoint(touch111.position);

                switch (touch111.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos111))
                        {
                            deltaX = touchPos111.x - transform.position.x;
                            deltaY = touchPos111.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos111))
                            transform.position = new Vector2(touchPos111.x - deltaX, touchPos111.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == b08)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos111))
                            {
                                    score = score + 3;
                                correct_pop_up_msg.SetActive(true);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                        }
                        break;
                }
            }
        }
        //Sprite banana 2

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == b09 && SceneManager.GetActiveScene().name == "Level-2-03")
        {
            if (Input.touchCount > 0 && !locked3)
            {
                Touch touch311 = Input.GetTouch(0);
                Vector2 touchPos311 = Camera.main.ScreenToWorldPoint(touch311.position);

                switch (touch311.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos311))
                        {
                            deltaX = touchPos311.x - transform.position.x;
                            deltaY = touchPos311.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos311))
                            transform.position = new Vector2(touchPos311.x - deltaX, touchPos311.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == b09)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked3 = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos311) && numLives > 0)
                            {
                                    numLives = numLives - 1;
                                }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                        }
                        break;
                }
            }
        }

        //Sprite cup 3

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == b10 && SceneManager.GetActiveScene().name == "Level-2-03")
        {
            if (Input.touchCount > 0 && !locked2)
            {
                Touch touch2111 = Input.GetTouch(0);
                Vector2 touchPos2111 = Camera.main.ScreenToWorldPoint(touch2111.position);

                switch (touch2111.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2111))
                        {
                            deltaX = touchPos2111.x - transform.position.x;
                            deltaY = touchPos2111.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2111))
                            transform.position = new Vector2(touchPos2111.x - deltaX, touchPos2111.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == b10)
                        {

                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked2 = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2111  ) && numLives > 0)
                            {
                                    numLives = numLives - 1;
                                }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                        }
                        break;
                }
            }
        }

        //START LEVEL 2 EXCERSISE 4 #################################################### BUTTON  ############################################################################

        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answerbtn1 && SceneManager.GetActiveScene().name == "Level-2-04")
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch1 = Input.GetTouch(0);
                Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                switch (touch1.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                        {
                            deltaX = touchPos.x - transform.position.x;
                            deltaY = touchPos.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answerbtn1)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && numLives > 0)
                            {
                                    numLives = numLives - 1;
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                        }
                        break;
                }
            }
        }
        //Sprite banana 2

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answerbtn2 && SceneManager.GetActiveScene().name == "Level-2-04")
        {
            if (Input.touchCount > 0 && !locked3)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answerbtn2)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked3 = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                    score = score + 3;
                                correct_pop_up_msg.SetActive(true);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                        }
                        break;
                }
            }
        }

        //Sprite cup 3

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answerbtn3 && SceneManager.GetActiveScene().name == "Level-2-04")
        {
            if (Input.touchCount > 0 && !locked2)
            {
                Touch touch2 = Input.GetTouch(0);
                Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                switch (touch2.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                        {
                            deltaX = touchPos2.x - transform.position.x;
                            deltaY = touchPos2.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answerbtn3)
                        {

                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked2 = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                            {
                                    numLives = numLives - 1;
                             }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                        }
                        break;
                }
            }
        }

        //START LEVEL 2 EXCERSISE 4 #################################################### BUTTON  ############################################################################

        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer111 && SceneManager.GetActiveScene().name == "Level-2-05")
        {
            if (Input.touchCount > 0 && !locked)
            {
                Touch touch1 = Input.GetTouch(0);
                Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                switch (touch1.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                        {
                            deltaX = touchPos.x - transform.position.x;
                            deltaY = touchPos.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer111)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && numLives > 0)
                            {
                                    numLives = numLives - 1;
                                }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                        }
                        break;
                }
            }
        }
        //Sprite banana 2

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer121 && SceneManager.GetActiveScene().name == "Level-2-05")
        {
            if (Input.touchCount > 0 && !locked3)
            {
                Touch touch3 = Input.GetTouch(0);
                Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                switch (touch3.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                        {
                            deltaX = touchPos3.x - transform.position.x;
                            deltaY = touchPos3.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer121)
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked3 = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3) && numLives > 0)
                            {
                                    numLives = numLives - 1;
                                }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                        }
                        break;
                }
            }
        }

        //Sprite cup 3

        else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer131 && SceneManager.GetActiveScene().name == "Level-2-05")
        {
            if (Input.touchCount > 0 && !locked2)
            {
                Touch touch2 = Input.GetTouch(0);
                Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                switch (touch2.phase)
                {
                    case TouchPhase.Began:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                        {
                            deltaX = touchPos2.x - transform.position.x;
                            deltaY = touchPos2.y - transform.position.y;
                        }
                        break;

                    case TouchPhase.Moved:
                        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                        break;

                    case TouchPhase.Ended:
                        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer131)
                        {

                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                            locked2 = false;
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                    score = score + 3;
                                correct_pop_up_msg.SetActive(true);
                            }
                        }
                        else
                        {
                            transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                        }
                        break;
                }
            }
        }

            //######################################################################  LEVEL GAME TWO ################################################################################################
            //START LEVEL 2 EXCERSISE 1 #################################################### BUTTON  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana1 && SceneManager.GetActiveScene().name == "Scene-2-01")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch1 = Input.GetTouch(0);
                    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                    switch (touch1.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                deltaX = touchPos.x - transform.position.x;
                                deltaY = touchPos.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana1)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;

                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                {
                                    numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana2 && SceneManager.GetActiveScene().name == "Scene-2-01")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana2)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                            break;
                    }
                }
            }

            //Sprite banana 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana3 && SceneManager.GetActiveScene().name == "Scene-2-01")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana3)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                                {
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                            break;
                    }
                }
            }
            //LEVEL 2 EXERCISE 2#########################################################################################################################

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer1 && SceneManager.GetActiveScene().name == "Scene-2-02")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer1)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                                {
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                            break;
                    }
                }
            }

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer2 && SceneManager.GetActiveScene().name == "Scene-2-02")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer2)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                {
                                 
                                    numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                GameObject.DontDestroyOnLoad(this.gameObject);

                            }
                            break;
                    }
                }
            }
            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer3 && SceneManager.GetActiveScene().name == "Scene-2-02")
            {

                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer3)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                            break;
                    }
                }
            }
            //START LEVEL 2 EXCERSISE 3 #################################################### FORK  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer11 && SceneManager.GetActiveScene().name == "Scene-2-03")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch1 = Input.GetTouch(0);
                    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                    switch (touch1.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                deltaX = touchPos.x - transform.position.x;
                                deltaY = touchPos.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer11)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                {
                                    numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer12 && SceneManager.GetActiveScene().name == "Scene-2-03")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer12)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                //transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                    //correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //Sprite banana 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer13 && SceneManager.GetActiveScene().name == "Scene-2-03")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer13)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                                {
                                    
                                    //wrong_pop_up_msg.SetActive(true);
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //START LEVEL 2 EXCERSISE 4 #################################################### FORK  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange1 && SceneManager.GetActiveScene().name == "Scene-2-04")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch1 = Input.GetTouch(0);
                    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                    switch (touch1.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                deltaX = touchPos.x - transform.position.x;
                                deltaY = touchPos.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange1)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && numLives > 0)
                                {
                                    //correct_pop_up_msg.SetActive(true);
                                    numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange2 && SceneManager.GetActiveScene().name == "Scene-2-04")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange2)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                //transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                {
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //Sprite orange 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange3 && SceneManager.GetActiveScene().name == "Scene-2-04")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                                //wrong_pop_up_msg.SetActive(true);
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange3)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                    //wrong_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }
            //START LEVEL 1 EXCERSISE 5 #################################################### FORK  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange11 && SceneManager.GetActiveScene().name == "Scene-2-05")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch1 = Input.GetTouch(0);
                    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                    switch (touch1.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                deltaX = touchPos.x - transform.position.x;
                                deltaY = touchPos.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange11)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && numLives > 0)
                                {
                                    //correct_pop_up_msg.SetActive(true);
                                    numLives = numLives - 1;
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange12 && SceneManager.GetActiveScene().name == "Scene-2-05")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange12)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                //transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3) && numLives > 0)
                                {

                                    //correct_pop_up_msg.SetActive(true);
                                    numLives = numLives - 1;
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //Sprite orange 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange13 && SceneManager.GetActiveScene().name == "Scene-2-05")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                                //wrong_pop_up_msg.SetActive(true);
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange13)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                {
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }
            //START LEVEL 2 EXCERSISE 6 #################################################### CUP  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == cup1 && SceneManager.GetActiveScene().name == "Scene-2-06")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch1 = Input.GetTouch(0);
                    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                    switch (touch1.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                deltaX = touchPos.x - transform.position.x;
                                deltaY = touchPos.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == cup1)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                {
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == cup2 && SceneManager.GetActiveScene().name == "Scene-2-06")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == cup2)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                //transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                    //correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //Sprite cup 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == cup3 && SceneManager.GetActiveScene().name == "Scene-2-06")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                                //wrong_pop_up_msg.SetActive(true);
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == cup3)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                    //correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }
            //############################################################## END #########################################
            //START LEVEL 2 EXCERSISE 7 #################################################### FORK  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == fork1 && SceneManager.GetActiveScene().name == "Scene-2-07")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch1 = Input.GetTouch(0);
                    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                    switch (touch1.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                deltaX = touchPos.x - transform.position.x;
                                deltaY = touchPos.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == fork1)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && numLives > 0)
                                {
                                    //correct_pop_up_msg.SetActive(true);
                                    numLives = numLives - 1;
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == fork2 && SceneManager.GetActiveScene().name == "Scene-2-07")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == fork2)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                //transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                {
                                    numLives = numLives - 1;
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //Sprite cup 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == fork3 && SceneManager.GetActiveScene().name == "Scene-2-07")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == fork3)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                                {
                                    
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                    //correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }
            //############################################################## END #########################################
            //START LEVEL 2 EXCERSISE 8 #################################################### FORK  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == b08 && SceneManager.GetActiveScene().name == "Scene-2-08")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch111 = Input.GetTouch(0);
                    Vector2 touchPos111 = Camera.main.ScreenToWorldPoint(touch111.position);

                    switch (touch111.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos111))
                            {
                                deltaX = touchPos111.x - transform.position.x;
                                deltaY = touchPos111.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos111))
                                transform.position = new Vector2(touchPos111.x - deltaX, touchPos111.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == b08)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos111))
                                {
                                    numLives = numLives - 1;
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == b09 && SceneManager.GetActiveScene().name == "Scene-2-08")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch311 = Input.GetTouch(0);
                    Vector2 touchPos311 = Camera.main.ScreenToWorldPoint(touch311.position);

                    switch (touch311.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos311))
                            {
                                deltaX = touchPos311.x - transform.position.x;
                                deltaY = touchPos311.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos311))
                                transform.position = new Vector2(touchPos311.x - deltaX, touchPos311.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == b09)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos311) && numLives > 0)
                                {
                                    
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //Sprite cup 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == b10 && SceneManager.GetActiveScene().name == "Scene-2-08")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2111 = Input.GetTouch(0);
                    Vector2 touchPos2111 = Camera.main.ScreenToWorldPoint(touch2111.position);

                    switch (touch2111.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2111))
                            {
                                deltaX = touchPos2111.x - transform.position.x;
                                deltaY = touchPos2111.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2111))
                                transform.position = new Vector2(touchPos2111.x - deltaX, touchPos2111.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == b10)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2111) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }
            //############################################################## END #########################################
            //START LEVEL 2 EXCERSISE 9 #################################################### BUTTON  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answerbtn1 && SceneManager.GetActiveScene().name == "Scene-2-09")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch1 = Input.GetTouch(0);
                    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                    switch (touch1.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                deltaX = touchPos.x - transform.position.x;
                                deltaY = touchPos.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answerbtn1)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answerbtn2 && SceneManager.GetActiveScene().name == "Scene-2-09")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answerbtn2)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                {
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //Sprite cup 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answerbtn3 && SceneManager.GetActiveScene().name == "Scene-2-09")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answerbtn3)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }
            //############################################################## END #########################################
            //START LEVEL 2 EXCERSISE 10 #################################################### BUTTON  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer111 && SceneManager.GetActiveScene().name == "Scene-2-10")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch1 = Input.GetTouch(0);
                    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                    switch (touch1.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                deltaX = touchPos.x - transform.position.x;
                                deltaY = touchPos.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer111)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                    //correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer131 && SceneManager.GetActiveScene().name == "Scene-2-10")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer131)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                //transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                    // correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //Sprite cup 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer121 && SceneManager.GetActiveScene().name == "Scene-2-10")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer121)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                {
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }
            //############################################################## END #########################################
            //############################################################## START LEVEL THREE #########################################
            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana1 && SceneManager.GetActiveScene().name == "Scene-3-01")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch1 = Input.GetTouch(0);
                    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                    switch (touch1.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                deltaX = touchPos.x - transform.position.x;
                                deltaY = touchPos.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana1)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;

                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                {
                                    numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana2 && SceneManager.GetActiveScene().name == "Scene-3-01")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana2)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                            break;
                    }
                }
            }

            //Sprite banana 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana3 && SceneManager.GetActiveScene().name == "Scene-3-01")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana3)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                                {
                                   
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                            break;
                    }
                }
            }
            //LEVEL 2 EXERCISE 2#########################################################################################################################

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer1 && SceneManager.GetActiveScene().name == "Scene-3-02")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer1)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                            break;
                    }
                }
            }

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer2 && SceneManager.GetActiveScene().name == "Scene-3-02")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer2)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                {
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                GameObject.DontDestroyOnLoad(this.gameObject);

                            }
                            break;
                    }
                }
            }
            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer3 && SceneManager.GetActiveScene().name == "Scene-3-02")
            {

                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer3)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                //transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                            break;
                    }
                }
            }
            //START LEVEL 2 EXCERSISE 3 #################################################### FORK  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer11 && SceneManager.GetActiveScene().name == "Scene-3-03")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch1 = Input.GetTouch(0);
                    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                    switch (touch1.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                deltaX = touchPos.x - transform.position.x;
                                deltaY = touchPos.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer11)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                {
                                    numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer12 && SceneManager.GetActiveScene().name == "Scene-3-03")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer12)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                //transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3) && numLives > 0)
                                {
                                   
                                    //correct_pop_up_msg.SetActive(true);
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //Sprite banana 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer13 && SceneManager.GetActiveScene().name == "Scene-3-03")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer13)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                    //wrong_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //START LEVEL 2 EXCERSISE 4 #################################################### FORK  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange1 && SceneManager.GetActiveScene().name == "Scene-3-04")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch1 = Input.GetTouch(0);
                    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                    switch (touch1.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                deltaX = touchPos.x - transform.position.x;
                                deltaY = touchPos.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange1)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && numLives > 0)
                                {
                                    //correct_pop_up_msg.SetActive(true);
                                    numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange2 && SceneManager.GetActiveScene().name == "Scene-3-04")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange2)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                //transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                {
                                    numLives = numLives - 1;
                                    //wrong_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //Sprite orange 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange3 && SceneManager.GetActiveScene().name == "Scene-3-04")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                                //wrong_pop_up_msg.SetActive(true);
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange3)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                                {
                                    
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }
            //START LEVEL 1 EXCERSISE 5 #################################################### FORK  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange11 && SceneManager.GetActiveScene().name == "Scene-3-05")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch1 = Input.GetTouch(0);
                    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                    switch (touch1.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                deltaX = touchPos.x - transform.position.x;
                                deltaY = touchPos.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange11)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && numLives > 0)
                                {
                                    //correct_pop_up_msg.SetActive(true);
                                    numLives = numLives - 1;
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange12 && SceneManager.GetActiveScene().name == "Scene-3-05")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange12)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                //transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3) && numLives > 0)
                                {
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);

                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //Sprite orange 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange13 && SceneManager.GetActiveScene().name == "Scene-3-05")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                                //wrong_pop_up_msg.SetActive(true);
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange13)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                {

                                    //correct_pop_up_msg.SetActive(true);
                                    numLives = numLives - 1;
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }
            //START LEVEL 2 EXCERSISE 6 #################################################### CUP  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == cup1 && SceneManager.GetActiveScene().name == "Scene-3-06")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch1 = Input.GetTouch(0);
                    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                    switch (touch1.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                deltaX = touchPos.x - transform.position.x;
                                deltaY = touchPos.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == cup1)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                {
                                    numLives = numLives - 1;
                                    //correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == cup2 && SceneManager.GetActiveScene().name == "Scene-3-06")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == cup2)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                //transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3) && numLives > 0)
                                {
                                 
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //Sprite cup 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == cup3 && SceneManager.GetActiveScene().name == "Scene-3-06")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                                //wrong_pop_up_msg.SetActive(true);
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == cup3)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                    //correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }
            //############################################################## END #########################################
            //START LEVEL 2 EXCERSISE 7 #################################################### FORK  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == fork1 && SceneManager.GetActiveScene().name == "Scene-3-07")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch1 = Input.GetTouch(0);
                    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                    switch (touch1.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                deltaX = touchPos.x - transform.position.x;
                                deltaY = touchPos.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == fork1)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && numLives > 0)
                                {
                                    //correct_pop_up_msg.SetActive(true);
                                    numLives = numLives - 1;
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == fork2 && SceneManager.GetActiveScene().name == "Scene-3-07")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == fork2)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                //transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                {
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //Sprite cup 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == fork3 && SceneManager.GetActiveScene().name == "Scene-3-07")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == fork3)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                    //correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }
            //############################################################## END #########################################
            //START LEVEL 2 EXCERSISE 8 #################################################### FORK  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == b08 && SceneManager.GetActiveScene().name == "Scene-3-08")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch111 = Input.GetTouch(0);
                    Vector2 touchPos111 = Camera.main.ScreenToWorldPoint(touch111.position);

                    switch (touch111.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos111))
                            {
                                deltaX = touchPos111.x - transform.position.x;
                                deltaY = touchPos111.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos111))
                                transform.position = new Vector2(touchPos111.x - deltaX, touchPos111.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == b08)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos111))
                                {
                                    numLives = numLives - 1;
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == b09 && SceneManager.GetActiveScene().name == "Scene-3-08")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch311 = Input.GetTouch(0);
                    Vector2 touchPos311 = Camera.main.ScreenToWorldPoint(touch311.position);

                    switch (touch311.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos311))
                            {
                                deltaX = touchPos311.x - transform.position.x;
                                deltaY = touchPos311.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos311))
                                transform.position = new Vector2(touchPos311.x - deltaX, touchPos311.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == b09)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos311) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //Sprite cup 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == b10 && SceneManager.GetActiveScene().name == "Scene-3-08")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2111 = Input.GetTouch(0);
                    Vector2 touchPos2111 = Camera.main.ScreenToWorldPoint(touch2111.position);

                    switch (touch2111.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2111))
                            {
                                deltaX = touchPos2111.x - transform.position.x;
                                deltaY = touchPos2111.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2111))
                                transform.position = new Vector2(touchPos2111.x - deltaX, touchPos2111.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == b10)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2111) && numLives > 0)
                                {
                                   
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }
            //############################################################## END #########################################
            //START LEVEL 2 EXCERSISE 9 #################################################### BUTTON  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answerbtn1 && SceneManager.GetActiveScene().name == "Scene-3-09")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch1 = Input.GetTouch(0);
                    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                    switch (touch1.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                deltaX = touchPos.x - transform.position.x;
                                deltaY = touchPos.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answerbtn1)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answerbtn2 && SceneManager.GetActiveScene().name == "Scene-3-09")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answerbtn2)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                {
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //Sprite cup 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answerbtn3 && SceneManager.GetActiveScene().name == "Scene-3-09")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answerbtn3)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }
            //############################################################## END #########################################
            //START LEVEL 2 EXCERSISE 10 #################################################### BUTTON  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer111 && SceneManager.GetActiveScene().name == "Scene-3-10")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch1 = Input.GetTouch(0);
                    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                    switch (touch1.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                deltaX = touchPos.x - transform.position.x;
                                deltaY = touchPos.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer111)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                    //correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer121 && SceneManager.GetActiveScene().name == "Scene-3-10")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer121)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                //transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                    // correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //Sprite cup 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer131 && SceneManager.GetActiveScene().name == "Scene-3-10")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer131)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                {
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //############################################################## START LEVEL FOUR  #########################################
            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana1 && SceneManager.GetActiveScene().name == "Scene-4-01")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch1 = Input.GetTouch(0);
                    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                    switch (touch1.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                deltaX = touchPos.x - transform.position.x;
                                deltaY = touchPos.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana1)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;

                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                {

                                    numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana2 && SceneManager.GetActiveScene().name == "Scene-4-01")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana2)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3) && numLives > 0)
                                {
                                  
                                    numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                            break;
                    }
                }
            }

            //Sprite banana 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana3 && SceneManager.GetActiveScene().name == "Scene-4-01")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana3)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                                {

                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                            break;
                    }
                }
            }
            //LEVEL 2 EXERCISE 2#########################################################################################################################

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer1 && SceneManager.GetActiveScene().name == "Scene-4-02")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer1)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                                {
                                 
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                            break;
                    }
                }
            }

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer2 && SceneManager.GetActiveScene().name == "Scene-4-02")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer2)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                {
                                    numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                GameObject.DontDestroyOnLoad(this.gameObject);

                            }
                            break;
                    }
                }
            }
            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer3 && SceneManager.GetActiveScene().name == "Scene-4-02")
            {

                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer3)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                //transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                GameObject.DontDestroyOnLoad(this.gameObject);
                            }
                            break;
                    }
                }
            }
            //START LEVEL 2 EXCERSISE 3 #################################################### FORK  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer11 && SceneManager.GetActiveScene().name == "Scene-4-03")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch1 = Input.GetTouch(0);
                    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                    switch (touch1.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                deltaX = touchPos.x - transform.position.x;
                                deltaY = touchPos.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer11)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                {
                                    numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                    //wrong_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer12 && SceneManager.GetActiveScene().name == "Scene-4-03")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer12)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                //transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                    //correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //Sprite banana 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer13 && SceneManager.GetActiveScene().name == "Scene-4-03")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer13)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                                {
                                    
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //START LEVEL 2 EXCERSISE 4 #################################################### FORK  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange1 && SceneManager.GetActiveScene().name == "Scene-4-04")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch1 = Input.GetTouch(0);
                    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                    switch (touch1.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                deltaX = touchPos.x - transform.position.x;
                                deltaY = touchPos.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange1)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && numLives > 0)
                                {
                                    //correct_pop_up_msg.SetActive(true);
                                    numLives = numLives - 1;
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange2 && SceneManager.GetActiveScene().name == "Scene-4-04")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange2)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                //transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                {
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                    GameObject.DontDestroyOnLoad(this.gameObject);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //Sprite orange 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange3 && SceneManager.GetActiveScene().name == "Scene-4-04")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                                //wrong_pop_up_msg.SetActive(true);
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange3)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                    //wrong_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }
            //START LEVEL 1 EXCERSISE 5 #################################################### FORK  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange11 && SceneManager.GetActiveScene().name == "Scene-4-05")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch1 = Input.GetTouch(0);
                    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                    switch (touch1.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                deltaX = touchPos.x - transform.position.x;
                                deltaY = touchPos.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange11)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && numLives > 0)
                                {
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange12 && SceneManager.GetActiveScene().name == "Scene-4-05")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange12)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                //transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3) && numLives > 0)
                                {

                                    //correct_pop_up_msg.SetActive(true);
                                    numLives = numLives - 1;
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //Sprite orange 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange13 && SceneManager.GetActiveScene().name == "Scene-4-05")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                                //wrong_pop_up_msg.SetActive(true);
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == orange13)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                {
                                   
                                    //correct_pop_up_msg.SetActive(true);
                                    numLives = numLives - 1;
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }
            //START LEVEL 2 EXCERSISE 6 #################################################### CUP  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == cup1 && SceneManager.GetActiveScene().name == "Scene-4-06")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch1 = Input.GetTouch(0);
                    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                    switch (touch1.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                deltaX = touchPos.x - transform.position.x;
                                deltaY = touchPos.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == cup1)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                {
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == cup2 && SceneManager.GetActiveScene().name == "Scene-4-06")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == cup2)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                //transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                    //correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //Sprite cup 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == cup3 && SceneManager.GetActiveScene().name == "Scene-4-06")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                                //wrong_pop_up_msg.SetActive(true);
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == cup3)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                    //correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }
            //############################################################## END #########################################
            //START LEVEL 2 EXCERSISE 7 #################################################### FORK  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == fork1 && SceneManager.GetActiveScene().name == "Scene-4-07")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch1 = Input.GetTouch(0);
                    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                    switch (touch1.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                deltaX = touchPos.x - transform.position.x;
                                deltaY = touchPos.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == fork1)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && numLives > 0)
                                {
                                    //correct_pop_up_msg.SetActive(true);
                                    numLives = numLives - 1;
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == fork2 && SceneManager.GetActiveScene().name == "Scene-4-07")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == fork2)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                //transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                {
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //Sprite cup 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == fork3 && SceneManager.GetActiveScene().name == "Scene-4-07")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == fork3)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                    //correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }
            //############################################################## END #########################################
            //START LEVEL 2 EXCERSISE 8 #################################################### FORK  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == b08 && SceneManager.GetActiveScene().name == "Scene-4-08")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch111 = Input.GetTouch(0);
                    Vector2 touchPos111 = Camera.main.ScreenToWorldPoint(touch111.position);

                    switch (touch111.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos111))
                            {
                                deltaX = touchPos111.x - transform.position.x;
                                deltaY = touchPos111.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos111))
                                transform.position = new Vector2(touchPos111.x - deltaX, touchPos111.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == b08)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos111))
                                {
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == b09 && SceneManager.GetActiveScene().name == "Scene-4-08")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch311 = Input.GetTouch(0);
                    Vector2 touchPos311 = Camera.main.ScreenToWorldPoint(touch311.position);

                    switch (touch311.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos311))
                            {
                                deltaX = touchPos311.x - transform.position.x;
                                deltaY = touchPos311.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos311))
                                transform.position = new Vector2(touchPos311.x - deltaX, touchPos311.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == b09)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos311) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //Sprite cup 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == b10 && SceneManager.GetActiveScene().name == "Scene-4-08")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2111 = Input.GetTouch(0);
                    Vector2 touchPos2111 = Camera.main.ScreenToWorldPoint(touch2111.position);

                    switch (touch2111.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2111))
                            {
                                deltaX = touchPos2111.x - transform.position.x;
                                deltaY = touchPos2111.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2111))
                                transform.position = new Vector2(touchPos2111.x - deltaX, touchPos2111.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == b10)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2111) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }
            //############################################################## END #########################################
            //START LEVEL 2 EXCERSISE 9 #################################################### BUTTON  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answerbtn1 && SceneManager.GetActiveScene().name == "Scene-4-09")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch1 = Input.GetTouch(0);
                    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                    switch (touch1.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                deltaX = touchPos.x - transform.position.x;
                                deltaY = touchPos.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answerbtn1)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answerbtn2 && SceneManager.GetActiveScene().name == "Scene-4-09")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answerbtn2)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                {
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //Sprite cup 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answerbtn3 && SceneManager.GetActiveScene().name == "Scene-4-09")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answerbtn3)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }
            //############################################################## END #########################################
            //START LEVEL 2 EXCERSISE 10 #################################################### BUTTON  ############################################################################

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer111 && SceneManager.GetActiveScene().name == "Scene-4-10")
            {
                if (Input.touchCount > 0 && !locked)
                {
                    Touch touch1 = Input.GetTouch(0);
                    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch1.position);

                    switch (touch1.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                            {
                                deltaX = touchPos.x - transform.position.x;
                                deltaY = touchPos.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer111)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                    //correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                            }
                            break;
                    }
                }
            }
            //Sprite banana 2

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer121 && SceneManager.GetActiveScene().name == "Scene-4-10")
            {
                if (Input.touchCount > 0 && !locked3)
                {
                    Touch touch3 = Input.GetTouch(0);
                    Vector2 touchPos3 = Camera.main.ScreenToWorldPoint(touch3.position);

                    switch (touch3.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                            {
                                deltaX = touchPos3.x - transform.position.x;
                                deltaY = touchPos3.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3))
                                transform.position = new Vector2(touchPos3.x - deltaX, touchPos3.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer121)
                            {
                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                //transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                                locked3 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos3) && numLives > 0)
                                {
                                    numLives = numLives - 1;
                                    // correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }

            //Sprite cup 3

            else if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer131 && SceneManager.GetActiveScene().name == "Scene-4-10")
            {
                if (Input.touchCount > 0 && !locked2)
                {
                    Touch touch2 = Input.GetTouch(0);
                    Vector2 touchPos2 = Camera.main.ScreenToWorldPoint(touch2.position);

                    switch (touch2.phase)
                    {
                        case TouchPhase.Began:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                            {
                                deltaX = touchPos2.x - transform.position.x;
                                deltaY = touchPos2.y - transform.position.y;
                            }
                            break;

                        case TouchPhase.Moved:
                            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                transform.position = new Vector2(touchPos2.x - deltaX, touchPos2.y - deltaY);
                            break;

                        case TouchPhase.Ended:
                            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == answer131)
                            {

                                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                                locked2 = false;
                                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos2))
                                {
                                    score = score + 3;
                                    correct_pop_up_msg.SetActive(true);
                                }
                            }
                            else
                            {
                                transform.position = new Vector2(bearplace.position.x, bearplace.position.y);

                            }
                            break;
                    }
                }
            }
            //############################################################## END #########################################
        }
    }
    void OnDestroy()
    {
        Debug.Log("GameStatus was Destroyed");
        // PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.SetInt("Lives", numLives);
    }
}

