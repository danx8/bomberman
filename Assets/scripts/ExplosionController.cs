using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject jugador1;
    public GameObject jugador2;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnDestroy(){
        Debug.Log("exploto");
        Vector3 derecha  = new Vector3(1,0,0);
        Vector3 izquierda = new Vector3(-1,0,0);
        Vector3 arriba = new Vector3(0,0,1);
        Vector3 abajo = new Vector3(0,0,-1);
        float stepSize = 20 ;
        int layer = 256;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, derecha, out hit, stepSize,layer)){
            Debug.Log("You hit1 " + hit.transform.name);
            if (string.Compare( hit.transform.name,"Jugador1") == 0){ 
                jugador1.GetComponent<JugadorController>().quitarVida();
            }
            else if (string.Compare( hit.transform.name,"Jugador2") == 0){ 
                jugador2.GetComponent<Jugador2Controller>().quitarVida();
            } 
            else{
                Destroy(hit.transform.gameObject);
            }
        }
        if (Physics.Raycast(transform.position, izquierda, out hit, stepSize,layer)){
                     Debug.Log("You hit2 " + hit.transform.name);
            if (string.Compare( hit.transform.name,"Jugador1") == 0){ 
                jugador1.GetComponent<JugadorController>().quitarVida();
            }
            else if (string.Compare( hit.transform.name,"Jugador2") == 0){ 
                jugador2.GetComponent<Jugador2Controller>().quitarVida();
            } 
            else{
                Destroy(hit.transform.gameObject);
            }

        }
        if (Physics.Raycast(transform.position, arriba, out hit, stepSize,layer)){
                     Debug.Log("You hit3 " + hit.transform.name);
            if (string.Compare( hit.transform.name,"Jugador1") == 0){ 
                jugador1.GetComponent<JugadorController>().quitarVida();
            }
            else if (string.Compare( hit.transform.name,"Jugador2") == 0){ 
                jugador2.GetComponent<Jugador2Controller>().quitarVida();
            } 
            else{
                Destroy(hit.transform.gameObject);
            }

        }
        if (Physics.Raycast(transform.position, abajo, out hit, stepSize,layer)){
                     Debug.Log("You hit4 " + hit.transform.name);
            if (string.Compare( hit.transform.name,"Jugador1") == 0){ 
                jugador1.GetComponent<JugadorController>().quitarVida();
            }
            else if (string.Compare( hit.transform.name,"Jugador2") == 0){ 
                jugador2.GetComponent<Jugador2Controller>().quitarVida();
            } 
            else{
                Destroy(hit.transform.gameObject);
            }

        }   
    }
}
