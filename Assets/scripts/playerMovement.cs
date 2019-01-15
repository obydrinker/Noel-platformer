using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float moveSpeed = 6f;
    public float jumpSpeed = 12f;


    public groundchecker groundcheck;

    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        //Hämtar komponenten Rigidbody från sig själv(Rigidbodyn från objektet som scriptet ligger på).
        rbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
        PlayerMovement();
        

    }
    void PlayerMovement()
    {
        //sätter hastigheten (åt höger och vänster) för spelaren.
        rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rbody.velocity.y);

        //Om hopp-knappen är nedtryckt hoppa men bara om...
        if (Input.GetKeyDown(KeyCode.W))
        {
            //...colliderna som kollar om spelaren står i backen är true.
            if (groundcheck.isGrounded > 0)
            {

                //Sätt en hastighet i hoppet.
                rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed);
            }
        }
    }

    //När objektet med scriptet kolliderar...
     private void OnTriggerStay2D(Collider2D collision)
    {
        //om objektet som (objektet med scriptet kolliderar med) har tagen Ladder sker...
        if (collision.tag == "Ladder")
        {
            //Att objektet med scriptet (i detta fallet "player") kan objektet röra sig "vertical" (upp och ner) då sätts en hastighet beroende på varibeln "moveSpeed".
            rbody.velocity = new Vector2(Input.GetAxis("Vertical") * moveSpeed, rbody.velocity.x);
        }
    }

}
