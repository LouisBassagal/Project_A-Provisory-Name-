using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDefaultColor : MonoBehaviour
{
    public SpriteRenderer Sprite = new SpriteRenderer();
    Color Purple = new Color(127, 0, 255);
    Color Red = new Color(237, 0, 0);
    Color Green = new Color(0, 128, 0);
    void Start()
    {
        int RandNumber = Random.Range(0, 3);
        if (RandNumber == 0)
            Sprite.color = Purple;
        if (RandNumber == 1)
            Sprite.color = Red;
        if (RandNumber == 2)
            Sprite.color = Green;
    }
}
