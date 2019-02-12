using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SqhereMovent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 postion = this.transform.position;
            postion.z++;
            this.transform.position = postion;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 postion = this.transform.position;
            postion.z--;
            this.transform.position = postion;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 postion = this.transform.position;
            postion.x++;
            this.transform.position = postion;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 postion = this.transform.position;
            postion.x--;
            this.transform.position = postion;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 postion = this.transform.position;
            postion.y++;
            this.transform.position = postion;
        }
        if (Input.GetKey(KeyCode.C))
        {
            Vector3 postion = this.transform.position;
            postion.y--;
            this.transform.position = postion;
        }
    }
}
