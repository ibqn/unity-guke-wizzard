using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GukeGuess : MonoBehaviour
{
    [SerializeField]
    int minimal;
    [SerializeField]
    int maximal;

    int max;
    int min;

    int guess;

    [SerializeField]
    TMP_Text guessText;
    // Start is called before the first frame update
    void Start()
    {
        min = minimal;
        max = maximal;
        NextGuess();
    }

    public void OnHigher()
    {
        min = Math.Min(guess + 1, maximal);
        NextGuess();
    }
    public void OnLower()
    {
        max = Math.Max(minimal, guess - 1);
        NextGuess();
    }
    public void OnMatch()
    {
        SceneManager.LoadScene("Win");
    }

    void NextGuess()
    {
        guess = UnityEngine.Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}
