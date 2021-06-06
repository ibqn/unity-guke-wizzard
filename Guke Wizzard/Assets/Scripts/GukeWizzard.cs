using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GukeWizzard : MonoBehaviour
{
    public void OnNewGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnQuitGame()
    {
        SceneManager.LoadScene("Quit");
    }
}
