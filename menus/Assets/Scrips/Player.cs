using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
public float speed=2f;
private Rigidbody2D rb2d;
public float maxSpeed = 5f;
private Animator anim;  
private PolygonCollider2D cc2d;
private bool movement = true;
private  SpriteRenderer spr;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        cc2d= GetComponent<PolygonCollider2D>();
        spr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("speed", Mathf.Abs(rb2d.velocity.x));
    }

    void FixedUpdate(){
    float h = Input.GetAxis("Horizontal");
    if(!movement) h=0;
    rb2d.AddForce(Vector2.right * speed * h);

    float limitedSpeed = Mathf.Clamp(rb2d.velocity.x, -maxSpeed, maxSpeed);
    rb2d.velocity = new Vector2(limitedSpeed, rb2d.velocity.y);

    if(h > 0.1f){
    transform.localScale = new Vector3(-1f ,1f,1f);
    }

    if(h< -0.1f){
    transform.localScale = new Vector3(1f ,1f,1f);
    }

    }
}
