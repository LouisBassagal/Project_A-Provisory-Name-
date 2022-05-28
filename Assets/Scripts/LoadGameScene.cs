using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameScene : MonoBehaviour
{
    private void OnMouseUp()
    {
        SceneManager.LoadScene("Game");
    }
}
