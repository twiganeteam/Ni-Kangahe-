using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragTouchBanana3 : MonoBehaviour
{
    [SerializeField]
    private Transform bearplace;
    private Vector2 initialPosition;
    private Vector2 mousePosition;
    private float deltaX, deltaY;
    public static bool locked;
    public Sprite banana3;
    void Start()
    {
        initialPosition = transform.position;
    }
    private void Update()
    {
        if (Input.touchCount > 0 && !locked && this.gameObject.GetComponent<SpriteRenderer>().sprite == banana3)
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
                    if (Mathf.Abs(transform.position.x - bearplace.position.x) <= 0.5f &&
            Mathf.Abs(transform.position.y - bearplace.position.y) <= 0.5f)
                    {
                        transform.position = new Vector2(bearplace.position.x, bearplace.position.y);
                        locked = false;
                        transform.position = new Vector2(initialPosition.x, initialPosition.y);
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
