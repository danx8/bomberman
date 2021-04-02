using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador2Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         
        
        Vector3 pos = transform.position;
 
        if (Input.GetKey(KeyCode.A) ) { 
              pos.x -= 1;   
              transform.rotation = Quaternion.Euler(0,-90,0);    
        }
        else if (Input.GetKey(KeyCode.D) ) { 
              pos.x += 1;  
              transform.rotation = Quaternion.Euler(0,90,0); 
        }
        else if (Input.GetKey(KeyCode.W) ) { 
              pos.z += 1; 
              transform.rotation = Quaternion.Euler(0,0,0);      
        }
        else if (Input.GetKey(KeyCode.S) ) { 
              pos.z -= 1;
              transform.rotation = Quaternion.Euler(0,-180,0);   
        }
        transform.position = pos;
    }
}
