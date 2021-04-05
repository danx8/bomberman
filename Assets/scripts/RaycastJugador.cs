using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastJugador : MonoBehaviour
{
    private void Update()
    {   
        Vector3 distancia = new Vector3(0, 0, 500);
        Ray ray= new Ray(transform.position + Vector3.up + distancia,transform.forward + distancia);
        Debug.DrawRay(ray.origin, ray.direction, Color.red);
        if(Input.GetButtonDown("Jump"))
        {
            Debug.Log(Physics.Raycast(ray));
        }
    }
}