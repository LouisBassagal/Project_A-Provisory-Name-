using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public float MaxMoveSpeed = 0.1f;
    public float SmoothTime = 0.3f;
    Vector2 CurrentVelocity;

    void FixedUpdate()
    {
        Vector2 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.SmoothDamp(transform.position, cursorPosition, ref CurrentVelocity, SmoothTime, MaxMoveSpeed);
    }
}
