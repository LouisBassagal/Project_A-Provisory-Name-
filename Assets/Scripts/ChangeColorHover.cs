using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeColorHover : MonoBehaviour
{
    public TextMeshPro MyText;
    void OnMouseEnter()
    {
        MyText.color = Color.red;
    }
    void OnMouseExit()
    {
        MyText.color = Color.white;
    }
    void OnMouseDown()
    {
        MyText.color = Color.blue;
    }
}
