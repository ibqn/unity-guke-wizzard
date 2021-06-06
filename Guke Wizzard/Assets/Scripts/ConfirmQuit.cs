using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConfirmQuit : MonoBehaviour
{
    public void onYes()
    {
        Application.Quit();
    }

    public void OnNever()
    {
        SceneManager.LoadScene("Intro");
    }
}
