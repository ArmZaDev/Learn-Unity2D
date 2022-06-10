using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    int numberOfTimes = 5;
    string nameOftheKey = "ENTER";
    float speedOfBreaking = 6.94f;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("If you press the up arrow you'll JUMP!!");
        Debug.Log("If you press the right arrow " + numberOfTimes + " you'll move!");

        Debug.LogWarning("if you press the " + nameOftheKey + ", nothig happens");
        Debug.LogError("if you smash the heybord at a speed of " + speedOfBreaking + " nothing happens, you just cry");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("up arrow key was pressed");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down arrow key was pressed");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("Left arrow key was pressed");
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            print("Right arrow key was pressed");
        }
    }
}
