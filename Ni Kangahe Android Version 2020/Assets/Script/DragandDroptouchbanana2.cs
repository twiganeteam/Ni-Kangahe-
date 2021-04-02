using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragandDroptouchbanana2 : MonoBehaviour
{
    [SerializeField]
    private Transform bearplace;
    private Vector2 initialPosition;
    private Vector2 mousePosition;
    private float deltaX, deltaY;
    public static bool locked;
    public Sprite banana2;

    void Start()
    {
        initialPosition = transform.position;
    }
    private void Update()
    {
        if (Input.touchCount > 0 && !locked && this.gameObject.GetComponent<SpriteRenderer>().sprite == banana2)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
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
                    if (this.gameObject.GetComponent<SpriteRenderer>().sprite == banana2)
                    {
                        transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                        locked = false;
                        SceneManager.LoadScene("Level-1");
                    }
                    else
                    {
                        transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                    }
                    break;
            }
        }
    }
    }
