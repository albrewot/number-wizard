using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    //Global Variables
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start() {
        StartGame();
    }

    //Initializing the Wizard
    void StartGame() {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Starting Game...");
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("We would like you to pick a number...");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up = Higher ; Push Down = Lower ; Push Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("Looks ike i guessed correctly.");
            StartGame();
        }
    }

    void NextGuess() {
        guess = (max + min) / 2;
        Debug.Log("Is your number is higher or lower than ..." + guess + " ?");
    }
}
