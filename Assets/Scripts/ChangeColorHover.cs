using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorHover : MonoBehaviour
{
    public TextMesh MyText;
    private void OnMouseEnter() {
        MyText.color = Color.red;
    }
    private void OnMouseExit() {
        MyText.color = Color.white;
    }
}
