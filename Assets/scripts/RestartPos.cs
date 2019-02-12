using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartPos : MonoBehaviour
{
    public Vector3 startPos;
    private void Awake()
    {
        startPos = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = startPos;
        }
    }
}
