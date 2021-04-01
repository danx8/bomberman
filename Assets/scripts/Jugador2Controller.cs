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
         
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");
       
        Vector3 direcion = new Vector3(movHorizontal,0.0f,movVertical);
        Vector3 pos = transform.position;
 
        if (Input.GetKey(KeyCode.A) ) { 
              pos.x += 1;      
        }
        if (Input.GetKey(KeyCode.D) ) { 
              pos.x -= 1;  
        }
        if (Input.GetKey(KeyCode.W) ) { 
              pos.z += 1;      
        }
        if (Input.GetKey(KeyCode.S) ) { 
              pos.z -= 1;  
        }
        transform.position = pos;
    }
}
