using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item1 : MonoBehaviour
{
    public GameObject Objeto;  
    public GameObject Objeto2;   
  public void desactivarObjetoEnUso()
    {
        if (Objeto != null)
        {
            bool isActive = Objeto.activeSelf;

            Objeto.SetActive(!isActive);
        }
    }
    public void ActivarItem2()
    {
        if (Objeto2 != null)
        {
            bool isActive = Objeto2.activeSelf;

            Objeto2.SetActive(!isActive);
        }
    }
    
}
