using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OppositeControlMovement : MonoBehaviour
{
    // Update is called once per frame
    public float acceleration = 2.5f;
    public float maximumSpeed = 5;
    void Update()
    {
        bool left = Input.GetKey(KeyCode.A);
        bool right = Input.GetKey(KeyCode.D);
        var velocity = GetComponent<Rigidbody2D>().velocity;
        float speed = velocity.x;
        if (left && speed > -maximumSpeed)
        {
            //I'm going left
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-acceleration, 0));
        }
        else if (right && speed < maximumSpeed)
        {
            //I'm going right
            GetComponent<Rigidbody2D>().AddForce(new Vector2(acceleration, 0));
        }
        //Debug.Log(GetComponent<Rigidbody2D>().velocity);
    }
}
