using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Jugador2Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 posicionInicial ;


    public int vidas;
    public void quitarVida(){
        vidas--;
        transform.position = posicionInicial;
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         
         
        Vector3 pos = transform.position;
        Quaternion rotation = transform.rotation;
 


        Vector3 derecha  = new Vector3(1,0,0);
        Vector3 izquierda = new Vector3(-1,0,0);
        Vector3 arriba = new Vector3(0,0,1);
        Vector3 abajo = new Vector3(0,0,-1);

        

        if (Input.GetKey(KeyCode.A) ) { 
            if (CheckMovement(izquierda) ){
                pos.x -= 1;
            } 
            transform.rotation = Quaternion.Euler(0,-90,0);    
        
        }
        else if (Input.GetKey(KeyCode.D) ){
            if (CheckMovement(derecha) ) { 
              pos.x += 1;
            }
            transform.rotation = Quaternion.Euler(0,90,0);  

        }
        else if (Input.GetKey(KeyCode.W) ) {
            if (CheckMovement(arriba) ) { 
              pos.z += 1;
            } 
              transform.rotation = Quaternion.Euler(0,0,0);   
     
        }
        else if (Input.GetKey(KeyCode.S) ) {
            if (CheckMovement(abajo) ) { 
              pos.z -= 1;
            } 
              transform.rotation = Quaternion.Euler(0,-180,0);  

        }
        transform.position = pos;
    }

    bool CheckMovement(Vector3 direction){
        float stepSize = 15 ;
        //Ray r = new Ray(transform.position, direction);
        //RaycastHit hit = Physics.Raycast(r.origin, r.direction, stepSize);
        if (Physics.Raycast(transform.position, direction,stepSize))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}