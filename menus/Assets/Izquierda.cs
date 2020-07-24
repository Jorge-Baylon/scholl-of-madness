using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Izquierda : MonoBehaviour
{
    private GameObject Nucleo;
    // Start is called before the first frame update
    void Start()
    {
        Nucleo = GameObject.Find("Nucleo");
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }

     public void Onclick(){
       Nucleo.SendMessage("MoverIzquierda");
        Debug.Log("Se presiono");
    }
    
}