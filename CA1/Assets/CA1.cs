using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputScript : MonoBehaviour
{
    // Task 1: Variables for comparison
    public int num1 = 5;
    public int num2 = 10;

    // Update is called once per frame
    void Update()
    {
        // Check for key presses and call corresponding functions
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            IntCompare();
        }
        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            LoopNums();
        }
        if (Keyboard.current.gKey.wasPressedThisFrame)
        {
            PrintHelloWorld();
        }
    }

    // Task 1: Function to compare two integers
    void IntCompare()
    {
        if (num1 == num2)
        {
            Debug.Log("The numbers are equal.");
        }
        else
        {
            int larger = num1 > num2 ? num1 : num2;
            Debug.Log("The larger number is: " + larger);
        }
    }

    // Task 2: Function to print numbers 1 to 10 in a single line
    void LoopNums()
    {
        string result = "";
        for (int i = 1; i <= 10; i++)
        {
            result += i + " ";
        }
        Debug.Log(result.Trim());
    }

    // Task 3: Function to print "Hello World" 10 times
    void PrintHelloWorld()
    {
        int count = 0;
        while (count < 10)
        {
            Debug.Log("Hello World");
            count++;
        }
    }
}
