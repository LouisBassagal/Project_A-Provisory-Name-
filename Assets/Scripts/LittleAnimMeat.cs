using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleAnimMeat : MonoBehaviour
{
    public GameObject Meat;
    public float Rotation = 3f;
    private float Timer = 0f;
    void Start()
    {
        float Number = Random.Range(0, 360);
        Meat.transform.Rotate(0f, 0f, Number);
    }

    void FixedUpdate()
    {
        Timer += Time.deltaTime;
        if (Timer >= 0.075f)
        {
            Meat.transform.Rotate(0f, 0f, Rotation);
            Timer = 0;
        }
    }
}
