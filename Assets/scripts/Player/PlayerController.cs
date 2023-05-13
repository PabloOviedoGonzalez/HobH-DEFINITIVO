using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 15f;
    private Rigidbody2D rb;
    private Animator anim;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float auxiliarspeed = moveSpeed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            auxiliarspeed*= 2;
        }
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") , Input.GetAxis("Vertical")).normalized * auxiliarspeed;
        //Las animaciones van aqui 
        if (rb.velocity.x > 0.1 && rb.velocity.y < 0.1 && rb.velocity.y > -0.1)
            anim.Play("derecha");
        else if (rb.velocity.x < -0.1 && rb.velocity.y < 0.1 && rb.velocity.y > -0.1)
            anim.Play("izquierda");
        else if (rb.velocity.y > 0.1)
            anim.Play("arriba");
        else if (rb.velocity.y < -0.1)
            anim.Play("abajo");
        else if (rb.velocity.x > 0.1 && rb.velocity.y > 0.1)
            anim.Play("back_der");
        else if (rb.velocity.x < -0.1 && rb.velocity.y > 0.1)
            anim.Play("back_izq");
        else if (rb.velocity.x > 0.1 && rb.velocity.y < -0.1)
            anim.Play("frontal_der");
        else if (rb.velocity.x < -0.1 && rb.velocity.y < -0.1)
            anim.Play("frontal_izq");
    }
   
}
