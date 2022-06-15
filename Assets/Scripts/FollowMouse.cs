using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public float MaxMoveSpeed = 0.2f;
    public float SmoothTime = 0.3f;
    public SpriteRenderer ActualSprite;
    private float Timer = 0.0f;
    Vector2 CurrentVelocity;

    void FixedUpdate()
    {
        Vector2 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0) && Timer == 0)
        {
            MaxMoveSpeed = 0.5f;
            Vector3 ActualScaling = this.transform.localScale;
            ActualScaling *= 0.8f;
            ActualSprite.transform.localScale = ActualScaling;
            Timer += Time.deltaTime;
        }
        if (Timer < 1.0f)
        {
            Timer += Time.deltaTime;
        }
        else
        {
            MaxMoveSpeed = 0.2f;
            Timer = 0.0f;
        }
        transform.position = Vector2.SmoothDamp(transform.position, cursorPosition, ref CurrentVelocity, SmoothTime, MaxMoveSpeed);
    }
}
