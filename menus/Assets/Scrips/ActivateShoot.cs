using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateShoot : MonoBehaviour
{
    public GameObject Objeto;  
    public GameObject Objeto2;  
    public GameObject Objeto3;  
    public GameObject Objeto4; 
    public GameObject Objeto5;  
    public GameObject Objeto6;   
    public void OpenPanel()
    {
        if (Objeto != null)
        {
            bool isActive = Objeto.activeSelf;

            Objeto.SetActive(!isActive);
        }
    }
    public void OpenPanel2()
    {
        if (Objeto2 != null)
        {
            bool isActive = Objeto2.activeSelf;

            Objeto2.SetActive(!isActive);
        }
    }
    public void OpenPane3()
    {
        if (Objeto3 != null)
        {
            bool isActive = Objeto3.activeSelf;

            Objeto3.SetActive(!isActive);
        }
    }
    public void OpenPanel4()
    {
        if (Objeto4 != null)
        {
            bool isActive = Objeto4.activeSelf;

            Objeto4.SetActive(!isActive);
        }
    }
    public void OpenPane5()
    {
        if (Objeto5 != null)
        {
            bool isActive = Objeto5.activeSelf;

            Objeto5.SetActive(!isActive);
        }
    }
    public void OpenPanel6()
    {
        if (Objeto6 != null)
        {
            bool isActive = Objeto6.activeSelf;

            Objeto6.SetActive(!isActive);
        }
    }
}
