using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Students : MonoBehaviour
{
  public GameObject deathEffect;
  public GameObject Objeto; 

	public float health = 4f;

	public static int EnemiesAlive = 0;

	void Start ()
	{
		EnemiesAlive++;
	}

	void OnCollisionEnter2D (Collision2D colInfo)
	{
		if (colInfo.relativeVelocity.magnitude > health)
		{
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
        }
		EnemiesAlive--;
		if (EnemiesAlive <= 0)
			Debug.Log("LEVEL WON!");

		Destroy(gameObject);
	}
}
