using UnityEngine;
using System.Collections;

public class Destruccion : MonoBehaviour
{
    public float Delay = 3f;
    //Delay in seconds before destroying the gameobject

    void Start ()
    {
        Destroy (gameObject, Delay);
    }
}

