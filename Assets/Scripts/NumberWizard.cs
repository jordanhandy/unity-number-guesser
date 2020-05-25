// Import needed modules
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    //  Serialize the fields for the minimum and maximum
    // game numbers
    // for easy access from the Inspector
    [SerializeField] int min, max;
    
    // Holds the information for the guess Text object
    [SerializeField] Text guessText;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        // Start the game
        StartGame();
    }

    void StartGame()
    {
        // Star the game and initiate a guess from the algorithm
        NextGuess();
    }
    public void OnPressHigher()
    {
        // If the user presses "Higher"
        // alter the minimum guess, and initiate the next guess
        min = guess + 1;
        NextGuess();
    }
    public void OnPressLower()
    {
        // If the user presses "Lower"
        // alter the minimum guess, and initiate the next guess
        max = guess - 1;
        NextGuess();
    }

    // Update is called once per frame
    void NextGuess()
    {
        // Generate the initial guess from the min and max range
        // per game run

        // Assign the user guess (string) to
        // the text object
        guess = Random.Range(min,max+1);
        guessText.text = guess.ToString();
    }
}
