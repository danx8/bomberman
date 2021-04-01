using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         
         
        Vector3 pos = transform.position;
 
        if (Input.GetKey(KeyCode.LeftArrow) ) { 
              pos.x += 1;      
        }
        if (Input.GetKey(KeyCode.RightArrow) ) { 
              pos.x -= 1;  
        }
        if (Input.GetKey(KeyCode.UpArrow) ) { 
              pos.z += 1;      
        }
        if (Input.GetKey(KeyCode.DownArrow) ) { 
              pos.z -= 1;  
        }
        transform.position = pos;
    }
}
