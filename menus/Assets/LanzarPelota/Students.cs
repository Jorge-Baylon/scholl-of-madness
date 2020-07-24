using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Students : MonoBehaviour
{
  public GameObject deathEffect;
  public GameObject Objeto; 
 

	public float health = 4f;

	public static int StudentsAlive = 0;

	void Start ()
	{
		StudentsAlive++;
		
	}

	void OnCollisionEnter2D (Collision2D colInfo)
	{
		if (colInfo.relativeVelocity.magnitude > health)
		{
			 ScoreScript.scoreValue += 100;
			 Debug.Log("Se suma uno al score");
			Die();
		}
	}
    
       
    
	void Die ()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		 if (Objeto != null)
    	{
			 bool isActive = Objeto.activeSelf;

            Objeto.SetActive(!isActive);

		Destroy(gameObject);
       }
		StudentsAlive--;
		if (StudentsAlive <= 0)
			Debug.Log("LEVEL WON!");
	}
}
