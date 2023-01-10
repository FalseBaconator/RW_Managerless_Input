using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            gameObject.transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            gameObject.transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            gameObject.transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            gameObject.transform.Translate(0, 0, -speed * Time.deltaTime);
        }
    }
}
