using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideBackground : MonoBehaviour
{
    public GameObject background;
    // Start is called before the first frame update
    void Start()
    {
        background.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
