using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float Speed = 2000;
    public Vector3 LeftDir = new Vector3(-1, 0, 0);
    public Vector3 RightDir = new Vector3(1, 0, 0);
    //public bool localPosition = false;
    // Update is called once per frame
    void Update()
    {
        
        Vector3 deltaLeft = Speed * LeftDir* Time.deltaTime;
        Vector3 deltaRight = Speed * RightDir* Time.deltaTime;
        Debug.Log(Speed);
        Debug.Log(LeftDir);
        Debug.Log(Time.deltaTime);
        bool left = Input.GetKeyDown(KeyCode.LeftArrow);
        bool right = Input.GetKeyDown(KeyCode.RightArrow);


        if (left)
        {
            transform.position += deltaLeft;
            
        }
        else if (right)
        {
            transform.position += deltaRight;
// Debug.Log("right");
        }
        //else
        //    transform.position += delta;
    }
}
