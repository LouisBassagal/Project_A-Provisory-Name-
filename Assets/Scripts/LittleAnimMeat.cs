using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleAnimMeat : MonoBehaviour
{
    public SpriteRenderer Sprite = new SpriteRenderer();
    private float Timer = 0f;
    void Start()
    {
        Quaternion Rotate = transform.localRotation;
        float Number = Random.Range(0, 360);
        Rotate.z += Number;
        transform.localRotation = Rotate;
    }

    void FixedUpdate()
    {
        Quaternion Rotate = transform.localRotation;
        Timer += Time.deltaTime;
        if (Timer >= 0.075f)
        {
            Rotate.z += 0.02f;
            if (Rotate.z > 1)
                Rotate.z = 0;
            if (Rotate.z < 0)
                Rotate.z = 1;
            transform.localRotation = Rotate;
            Timer = 0;
        }
    }
}
