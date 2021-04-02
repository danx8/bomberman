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
        Quaternion rotation = transform.rotation;
 
        if (Input.GetKey(KeyCode.LeftArrow) ) { 
              pos.x -= 1; 
              transform.rotation = Quaternion.Euler(0,-90,0);    
        }
        else if (Input.GetKey(KeyCode.RightArrow) ) { 
              pos.x += 1;
              transform.rotation = Quaternion.Euler(0,90,0);  
        }
        else if (Input.GetKey(KeyCode.UpArrow) ) { 
              pos.z += 1; 
              transform.rotation = Quaternion.Euler(0,0,0);   
     
        }
        else if (Input.GetKey(KeyCode.DownArrow) ) { 
              pos.z -= 1; 
              transform.rotation = Quaternion.Euler(0,-180,0);  

        }
        transform.position = pos;
    }
}
