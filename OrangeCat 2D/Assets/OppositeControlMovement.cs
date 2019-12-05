using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OppositeControlMovement : MonoBehaviour
{
    // Update is called once per frame
    public float acceleration = 7.0f;
    public float maximumSpeed = 15.5f;
    public GameObject background;
    void Update()
    {
        bool left = Input.GetKey(KeyCode.A);
        bool right = Input.GetKey(KeyCode.D);
        var velocity = GetComponent<Rigidbody2D>().velocity;
        var mass = GetComponent<Rigidbody2D>().mass;
        float speed = velocity.x;
        if (left && speed > -maximumSpeed)
        {
            //I'm going left
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-acceleration * mass, 0));
        }
        else if (right && speed < maximumSpeed)
        {
            //I'm going right
            GetComponent<Rigidbody2D>().AddForce(new Vector2(acceleration * mass, 0));
        }
        float factor = 0.12f;
        GetComponent<Rigidbody2D>().AddForce(new Vector2(-velocity.x * factor * mass, -velocity.y * factor * mass));
        //Debug.Log(GetComponent<Rigidbody2D>().velocity);
        if (GetComponent<Rigidbody2D>().position.y < -40)
        {
            background.SetActive(true);
        }
    }
}
