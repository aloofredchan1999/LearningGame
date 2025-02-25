using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumberAdder : MonoBehaviour
{
    private int randomNumber1; // Random number within 10
    private int randomNumber2; // Random number within 100
    private int answer;

    void Start()
    {
        // Generate random numbers
        GenerateRandomNumbers();

        // Add the random numbers
        AddNumbers();

        // Display the result in the Console
        Debug.Log("Random Number 1 (1-10): " + randomNumber1);
        Debug.Log("Random Number 2 (1-100): " + randomNumber2);
        Debug.Log("Answer (Sum): " + answer);
    }

    void GenerateRandomNumbers()
    {
        // Generate random integers
        randomNumber1 = Random.Range(1, 11);  // Range includes 1 to 10
        randomNumber2 = Random.Range(1, 101); // Range includes 1 to 100
    }

    void AddNumbers()
    {
        answer = randomNumber1 + randomNumber2;
    }
}