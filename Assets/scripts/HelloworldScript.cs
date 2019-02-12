using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloworldScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            print("Respect");
        }
    }
}
