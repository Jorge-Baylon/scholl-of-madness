using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpenup : MonoBehaviour
{
    public GameObject Objeto;  
    public GameObject Objeto2;    
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
}
