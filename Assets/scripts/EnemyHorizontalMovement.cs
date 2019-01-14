using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    public float speed = 3f;
    public bool isLeft = true;
    private Rigidbody2D rBody;

    // Use this for initialization
    void Start()
    {
        //Hämtar komponenten Rigidbody från sig själv (Rigidbodyn från objektet som scriptet ligger på).
        rBody = GetComponent<Rigidbody2D>();
    }
    //till skillnad från update så används fixed update för fysik (update is called once per frame).
    private void FixedUpdate()
    {
        //kollar om objektet ser åt vänster...
        if (isLeft == true)
        {
            //...läggs hastighet till beroende på speed variabeln (åt vänster)
            rBody.velocity = -(Vector2)transform.right * speed;
            //ädrar så att spriten kollar åt vänster när skalan av spriten har ändrats.
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            //lägger till hastighet beroende på speed variabeln (åt höger)
            rBody.velocity = (Vector2)transform.right * speed;
            //ändrar så att spriten kollar åt höger när skalan av spriten har ändrats.
            transform.localScale = new Vector3(-1, 1, 1);
        }


    }
    //när triggern på objektet kolliderar händer...
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //om det är en kollision med invisibleWall...
        if (collision.tag == "invisibleWall")
        {
            //är vänster "ja" så är spriten riktad åt vänster. Om vänster är "nej" så är spriten riktad år höger.
            isLeft = !isLeft;

        }
    }
}
