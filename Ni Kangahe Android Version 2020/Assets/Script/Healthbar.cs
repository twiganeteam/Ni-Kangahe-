using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthbar : MonoBehaviour
{
    public float TotalHp=100;
    public float CurrentHp;
    // Start is called before the first frame update
  void Start()
    {
        CurrentHp = TotalHp;
    }
    // Update is called once per frame
  void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
            TakeDamage();
        }
    }
    void TakeDamage()
    {
        CurrentHp -= 5;
        transform.localScale = new Vector3((CurrentHp / TotalHp), 1, 1);
    }
}
