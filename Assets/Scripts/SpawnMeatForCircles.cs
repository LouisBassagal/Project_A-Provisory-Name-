using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeatForCircles : MonoBehaviour
{
    public Object GameObject = new Object();
    public Camera Cam = new Camera();
    private float x;
    private float y;
    private float Timer = 0.0f;

    void Start()
    {
        float CamHalfHeight = Cam.orthographicSize;
        float CamHalfWidth = Cam.aspect * CamHalfHeight;
        for (int i = 0; i < 20; i += 1)
        {
            x = (Random.Range(-CamHalfWidth, CamHalfWidth));
            y = (Random.Range(-CamHalfHeight, CamHalfHeight));
            Vector3 Position = new Vector3(x, y, 0f);
            Instantiate(GameObject, Position, Quaternion.identity);
        }
    }

    void FixedUpdate()
    {
        float CamHalfHeight = Cam.orthographicSize;
        float CamHalfWidth = Cam.aspect * CamHalfHeight;
        Timer += Time.deltaTime;
        if (Timer >= 2.0f && GameObject != null)
        {
            x = (Random.Range(-CamHalfWidth, CamHalfWidth));
            y = (Random.Range(-CamHalfHeight, CamHalfHeight));
            Vector3 Position = new Vector3(x, y, 0f);
            Instantiate(GameObject, Position, Quaternion.identity);
            Timer = 0f;
        }
    }
}
