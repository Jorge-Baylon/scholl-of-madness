using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoverDerecha(){
        transform.Translate(1,0,0);
        Debug.Log("Se mueve derecha");
    }

    public void MoverIzquierda(){
        transform.Translate(-1,0,0);
        Debug.Log("Se mueve Izquierda");
    }
}

