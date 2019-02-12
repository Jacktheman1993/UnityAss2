using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartPos : MonoBehaviour
{
    public Vector3 startpos;

    private void Awake()
    {
        startpos = transform.position;
    }
    public void restartPos()
    {
        print("sdsd");
        transform.position = startpos;
    }
}
