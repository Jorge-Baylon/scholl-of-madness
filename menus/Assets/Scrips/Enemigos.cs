using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    // Start is called before the first frame update
   void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.name == "sucess")
        {
            
            Debug.Log ("Sucess!!!");
        }
    }
}
