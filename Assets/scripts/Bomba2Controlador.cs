using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba2Controlador : MonoBehaviour
{   

    public GameObject bomba;
    public GameObject jugador;
    private int conteo_bombas;
    private int maximo_bombas;
    public GameObject explosionPrefab;
    public AudioSource SonidoExplosion;

    // Start is called before the first frame update
    void Start()
    {
        maximo_bombas= 10;
        conteo_bombas= 0;
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKeyDown(KeyCode.F))
        {   
            if(conteo_bombas < maximo_bombas) 
            {
                poner_bomba();
            }  
        }


    }
    void Explode() 
    {
     
    }

    void poner_bomba()
    {
        Destroy(Instantiate(bomba, jugador.transform.position, Quaternion.identity), (float)3);
        conteo_bombas= conteo_bombas + 1;
     //   Explode();
    }
    void OnDestroy()
    {
        Destroy(Instantiate(explosionPrefab, transform.position, Quaternion.identity), 2);
        SonidoExplosion.Play();
    }
}
