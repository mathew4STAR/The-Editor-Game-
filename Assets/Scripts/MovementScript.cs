using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    float Speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey("w"))
       {
            transform.Translate(Vector3.forward * Time.deltaTime * Speed);
       }
       if(Input.GetKey("s"))
       {
           transform.Translate(Vector3.back * Time.deltaTime * Speed);
       } 
       if(Input.GetKey("a"))
       {
           transform.Translate(Vector3.left * Time.deltaTime * Speed);
       }
       if(Input.GetKey("d"))
       {
           transform.Translate(Vector3.right * Time.deltaTime * Speed);
       }
    }
}
