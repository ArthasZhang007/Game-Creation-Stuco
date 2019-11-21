using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    //public GameObject copy;
    // Start is called before the first frame update
    void Start()
    {
        //for (int x = 0; x < 10; ++x)
            //Instantiate(copy).transform.position = new Vector3(0, 20);
    }

    // Update is called once per frame
    void Update()
    {
        var pos = (player1.transform.position+ player1.transform.position)/2;
        pos.z = -10;
        pos.y = transform.position.y;
        transform.position = pos;
        Debug.Log(transform.position);
    }
}

