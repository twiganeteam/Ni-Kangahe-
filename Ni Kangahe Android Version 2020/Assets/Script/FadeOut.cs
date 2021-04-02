using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    public float fadeOutTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DoFadeIn(GetComponent<SpriteRenderer>()));
    }
   IEnumerator DoFadeIn(SpriteRenderer _sprite)
    {
        Color tmpColor = _sprite.color;
        while (tmpColor.a < 1f)
        {
            tmpColor.a += Time.deltaTime / fadeOutTime;
            _sprite.color = tmpColor;

            if (tmpColor.a >= 1f)
                tmpColor.a = 1.0f;

            yield return null;
        }
        _sprite.color = tmpColor;
    }
}
