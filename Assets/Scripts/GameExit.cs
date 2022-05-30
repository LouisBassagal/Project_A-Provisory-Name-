using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameExit : MonoBehaviour
{
    void OnMouseUp()
    {
        Application.Quit();
        print("Game is quitting !");
    }
}
