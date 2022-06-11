using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Rigidbody2D myRigidBody2d;

    int numberOfTimes = 5;
    string nameOftheKey = "ENTER";
    float speedOfBreaking = 6.94f;


    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("If you press the up arrow you'll JUMP!!");
        //Debug.Log("If you press the right arrow " + numberOfTimes + " you'll move!");

        //Debug.LogWarning("if you press the " + nameOftheKey + ", nothig happens");
        //Debug.LogError("if you smash the heybord at a speed of " + speedOfBreaking + " nothing happens, you just cry");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            myRigidBody2d.velocity = new Vector2(0f,10f);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            myRigidBody2d.velocity = new Vector2(0f, -10f);
        }
      
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myRigidBody2d.velocity = new Vector2(-10f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myRigidBody2d.velocity = new Vector2(10f, 0f);
        }
        
        if (transform.position.x > 9.5f)
        {
            Debug.LogWarning("Our cube is out of bounds to the Right side!");
        }
        else if (transform.position.x < -9.5f)
        {
            Debug.LogWarning("Our cube is out of bounds to the Left side!");
        }
        else if (transform.position.y > 5.5f)
        {
            Debug.LogWarning("Our cubee is out of bounds to the Upper side!");
        }
    }
}
