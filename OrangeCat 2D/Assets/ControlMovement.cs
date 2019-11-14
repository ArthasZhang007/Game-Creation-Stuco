using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMovement : MonoBehaviour
{
    // Update is called once per frame
    public float acceleration = 1f;
    public float maximumSpeed = 2;
    void Update()
    {
        bool left = Input.GetKey(KeyCode.LeftArrow);
        bool right = Input.GetKey(KeyCode.RightArrow);
        var velocity = GetComponent<Rigidbody2D>().velocity;
        float speed = velocity.x;
        if (left && speed > -maximumSpeed)
        {
            //I'm going left
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-acceleration, 0));
        } else if (right && speed < maximumSpeed)
        {
            //I'm going right
            GetComponent<Rigidbody2D>().AddForce(new Vector2(acceleration, 0));
        }
        Debug.Log(GetComponent<Rigidbody2D>().velocity);
    }
}
